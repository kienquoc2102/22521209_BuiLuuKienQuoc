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
    public partial class Form_PrivateChat_Server : Form
    {
        public Form_PrivateChat_Server()
        {
            InitializeComponent();
        }

        //Khai báo
        private Socket tcpMe;
        private Socket tcpYou;
        private delegate void MessageDelegate(string message);
        private EndPoint remote_ip = (EndPoint)new IPEndPoint(IPAddress.Loopback, 12000);

        //Hàm hiển thị
        private void DisplayMessage(string message)
        {
            if (lb_message.InvokeRequired)
            {
                var invoke = new MessageDelegate(DisplayMessage);
                lb_message.Invoke(invoke, new object[] { message });
            }
            else
                lb_message.Items.Add(message);
        }

        //Các hàm kết nối
        private void Connect()
        {
            tcpMe = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint local_ip = (EndPoint)new IPEndPoint(IPAddress.Loopback, 11000);
            tcpMe.Bind(local_ip);
            tcpMe.Listen(1);

            while (true)
            {
                tcpYou = tcpMe.Accept();
                while (tcpYou.Connected)
                {
                    byte[] data = new byte[1024];
                    int byte_length = tcpYou.ReceiveFrom(data, ref remote_ip);
                    if (byte_length == 0)
                        break;

                    Packet receivedData = new Packet(data);
                    string message = "";

                    switch (receivedData.ChatDataIdentifier)
                    {
                        case DataIdentifier.Login:
                            message = $"You can chat with {receivedData.ChatName}";
                            break;
                        case DataIdentifier.Logout:
                            message = $"{receivedData.ChatName} has left!";
                            break;
                        case DataIdentifier.Message:
                            message = $"{receivedData.ChatName}: {receivedData.ChatMessage}";
                            break;
                    }
                    DisplayMessage(message);
                }
            }
        }

        private void Disconnect()
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.Logout,
                ChatName = this.Text,
                ChatMessage = ""
            };
            byte[] data = sendData.GetDataStream();
            tcpYou.SendTo(data, remote_ip);
            tcpYou.Shutdown(SocketShutdown.Send);
        }

        private void Send()
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.Message,
                ChatName = this.Text,
                ChatMessage = txt_Message.Text
            };
            byte[] data = sendData.GetDataStream();
            tcpYou.SendTo(data, remote_ip);
            DisplayMessage($"Me: {txt_Message.Text}");
            txt_Message.Text = null;
        }

        private void Form_PrivateChat_Server_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Connect));
            thread.Start();
        }

        private void Form_PrivateChat_Server_Leave(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
