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
    public partial class Form_PrivateChat_Client : Form
    {
        public Form_PrivateChat_Client()
        {
            InitializeComponent();
        }

        //Khai báo
        private Socket tcpYou;
        private EndPoint remote_ip = (EndPoint)new IPEndPoint(IPAddress.Loopback, 11000);
        private delegate void MessageDelegate(string message);

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
            tcpYou = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint local_ip = (EndPoint)new IPEndPoint(IPAddress.Loopback, 12000);
            tcpYou.Bind(local_ip);
            try
            {
                tcpYou.Connect(remote_ip);
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.Login,
                    ChatName = this.Text,
                    ChatMessage = ""
                };
                byte[] data = sendData.GetDataStream();
                tcpYou.SendTo(data, remote_ip);
                Thread Listen = new Thread(Receive);
                Listen.IsBackground = true;
                Listen.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if (tcpYou.Connected)
            {
                byte[] data = sendData.GetDataStream();
                tcpYou.SendTo(data, remote_ip);
                tcpYou.Shutdown(SocketShutdown.Send);
            }
        }

        private void Receive()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                int byte_length = tcpYou.ReceiveFrom(data, ref remote_ip);
                if (byte_length == 0)
                    break;
                Packet receivedData = new Packet(data);
                if (receivedData.ChatDataIdentifier == DataIdentifier.Message)
                    DisplayMessage($"{receivedData.ChatName}: {receivedData.ChatMessage}");
                if (receivedData.ChatDataIdentifier == DataIdentifier.Logout)
                    DisplayMessage($"{receivedData.ChatName} has left!");
            }
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

        private void Form_PrivateChat_Client_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Form_PrivateChat_Client_Leave(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
