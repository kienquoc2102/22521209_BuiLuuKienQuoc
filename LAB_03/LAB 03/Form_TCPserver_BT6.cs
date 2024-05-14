using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class Form_TCPserver_BT6 : Form
    {
        public Form_TCPserver_BT6()
        {
            InitializeComponent();
        }

        //Khai báo
        private TcpListener tcpServer;
        private Dictionary<string, TcpClient> client_list = new Dictionary<string, TcpClient>();
        private delegate void messageDelegate(string message);

        //Hàm hiển thị
        private void displayMessage(string message)
        {
            if (lv_message.InvokeRequired)
            {
                var invoke = new messageDelegate(displayMessage);
                lv_message.Invoke(invoke, new object[] { message });
            }
            else
                lv_message.Items.Add(message);
        }

        //Hàm kết nối
        private void Connect()
        {
            tcpServer = new TcpListener(IPAddress.Any, 8080);
            tcpServer.Start();
            try
            {
                while (true)
                {
                    TcpClient client = tcpServer.AcceptTcpClient();
                    Thread Listen = new Thread(Receive);
                    Listen.IsBackground = true;
                    Listen.Start(client);
                }
            }
            catch
            {
                MessageBox.Show("Loi o Server");
                tcpServer = new TcpListener(IPAddress.Any, 10000);
            }
        }

        //Hàm gửi đến tất cả client
        private void sendAllclient(Packet sendData, TcpClient sender)
        {
            byte[] data = sendData.GetDataStream();
            foreach (TcpClient client in client_list.Values)
            {
                if (client != sender)
                {
                    NetworkStream ns = client.GetStream();
                    ns.Write(data, 0, data.Length);
                    ns.Flush();
                }
            }
        }

        //Hàm gửi đến Client chỉ định
        private void sendIdenClient(Packet sendData, string name_client)
        {
            byte[] data = sendData.GetDataStream();
            foreach (KeyValuePair<string, TcpClient> kvp in client_list)
            {
                if (kvp.Key == name_client)
                {
                    NetworkStream ns = kvp.Value.GetStream();
                    ns.Write(data, 0, data.Length);
                    ns.Flush();
                }
            }
        }
        
        //Hàm nhận
        private void Receive(object obj)
        {
            TcpClient client = obj as TcpClient;
            while (client.Connected)
            {
                NetworkStream ns = client.GetStream();
                byte[] data = new byte[1024];
                int byte_length = ns.Read(data, 0, data.Length);
                if (byte_length == 0)
                    break;
                Packet receivedData = new Packet(data);
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = receivedData.ChatDataIdentifier,
                    ChatName = receivedData.ChatName,
                };
                string message = "";
                switch (receivedData.ChatDataIdentifier)
                {
                    case DataIdentifier.Login:
                        if (!client_list.ContainsKey(receivedData.ChatName))
                        {
                            client_list.Add(receivedData.ChatName, client);
                            message += $"{receivedData.ChatName} connected from {client.Client.RemoteEndPoint} \n";
                        }
                        sendData.ChatMessage = "";
                        break;
                    case DataIdentifier.Logout:
                        foreach (KeyValuePair<string, TcpClient> kvp in client_list)
                        {
                            if (kvp.Value.Equals(client))
                            {
                                client_list.Remove(kvp.Key);
                                break;
                            }
                        }
                        message += $"{receivedData.ChatName} has left!";
                        sendData.ChatMessage = $"{receivedData.ChatName} offline!";
                        break;
                    case DataIdentifier.Message:
                        message += $"{receivedData.ChatName}: {receivedData.ChatMessage}";
                        sendData.ChatMessage = receivedData.ChatMessage;
                        break;
                    case DataIdentifier.Private:
                        sendData.ChatMessage = receivedData.ChatMessage;
                        sendIdenClient(sendData, receivedData.ChatName);
                        break;
                }
                sendAllclient(sendData, client);
                displayMessage(message);
            }
        }

        //Hàm thao tác
        private void btn_listen_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            Thread serverThread = new Thread(new ThreadStart(Connect));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

    }
}
