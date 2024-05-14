using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class Form_TCPclient_BT6 : Form
    {
        public Form_TCPclient_BT6()
        {
            InitializeComponent();

        }

        //Khai báo biến
        private TcpClient tcpClient;
        private IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        private delegate void messageDelegate(string message);
        private delegate void participantsDelegate(string username);
        private delegate void noticeDelegate();

        //Hàm hiển thị
        private void DisplayMessage(string message)
        {
            if (lv_Message.InvokeRequired)
            {
                var invoke = new messageDelegate(DisplayMessage);
                lv_Message.Invoke(invoke, new object[] { message });
            }
            else
            {
                lv_Message.Items.Add(message);
            }
        }

        private void DisplayNotice()
        {
            if (lb_notice.InvokeRequired || btn_Accept.InvokeRequired)
            {
                var invoke  = new noticeDelegate(DisplayNotice);
                lb_notice.Invoke(invoke);
                btn_Accept.Invoke(invoke);
            }
            else
            {
                btn_Accept.Visible = true;
                lb_notice.Visible = true;
            }
        }

        private void DisplayParticipants(string username)
        {
            if (lv_connected_client.InvokeRequired)
            {
                var invoke = new participantsDelegate(DisplayParticipants);
                lv_connected_client.Invoke(invoke, new object[] { username });
            }
            else
            {
                lv_connected_client.Items.Add(username);
            }
        }

        //Hàm kết nối
        private void Connect()
        {
            tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect(ip);
                this.Text = txt_name_client.Text.Trim();
                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;

                //Gửi đến Server khi kết nối thành công
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.Login,
                    ChatName = txt_name_client.Text.Trim(),
                    ChatMessage = ""
                };
                byte[] data = sendData.GetDataStream();
                NetworkStream ns = tcpClient.GetStream();
                ns.Write(data, 0, data.Length);
                ns.Flush();

                //Lắng nghe sau khi kết nối
                Thread Listen = new Thread(Receive);
                Listen.IsBackground = true;
                Listen.Start();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới Server!");
            }
        }

        //Hàm đóng kết nối
        private void Disconnect()
        {
            btn_connect.Enabled = true;

            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.Logout,
                ChatName = txt_name_client.Text.Trim(),
                ChatMessage = ""
            };
            if (tcpClient.Connected)
            {
                byte[] data = sendData.GetDataStream();
                NetworkStream ns = tcpClient.GetStream();
                ns.Write(data, 0, data.Length);
                ns.Flush();

                tcpClient.Client.Shutdown(SocketShutdown.Send);
            }
        }

        //Hàm nhận
        private void Receive()
        {
            while (true)
            {
                NetworkStream ns = tcpClient.GetStream();

                byte[] data = new byte[1024];
                int byte_length = ns.Read(data, 0, data.Length);
                if (byte_length == 0)
                    break;

                Packet receivedData = new Packet(data);
                if (receivedData.ChatDataIdentifier == DataIdentifier.Message)
                {
                    DisplayMessage($"{receivedData.ChatName}: {receivedData.ChatMessage}");
                    if (!lv_connected_client.Items.Equals(receivedData.ChatName))
                        DisplayParticipants(receivedData.ChatName);
                }
                else if (receivedData.ChatDataIdentifier == DataIdentifier.Private)
                {
                    DisplayNotice();
                }
                else
                {
                    if (receivedData.ChatMessage != "")
                        DisplayMessage(receivedData.ChatMessage);
                }
            }
        }

        //Hàm gửi
        private void Send()
        {
            Packet sendData = new Packet()
            {
                ChatDataIdentifier = DataIdentifier.Message,
                ChatName = txt_name_client.Text.Trim(),
                ChatMessage = txt_message.Text
            };
            byte[] data = sendData.GetDataStream();
            NetworkStream ns = tcpClient.GetStream();
            ns.Write(data, 0, data.Length);
            ns.Flush();
            DisplayMessage($"Me: {txt_message.Text}");
        }

        //Hàm thao tác
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name_client.Text))
            {
                MessageBox.Show("Hãy nhập Username!");
            }
            Connect();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Send();
            txt_message.Text = null;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void lv_connected_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lv_connected_client.SelectedItems[0].Index;
            if (index != -1)
            {
                Packet sendData = new Packet()
                {
                    ChatDataIdentifier = DataIdentifier.Private,
                    ChatName = lv_connected_client.Items[index].ToString(),
                    ChatMessage = ""
                };
                byte[] data = sendData.GetDataStream();
                NetworkStream ns = tcpClient.GetStream();
                ns.Write(data, 0, data.Length);
                ns.Flush();

                Form_PrivateChat_Server Me = new Form_PrivateChat_Server()
                {
                    Text = txt_name_client.Text.Trim()
                };
                Me.Show();
            }
            else
                MessageBox.Show("There is not participants!");
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Form_PrivateChat_Client You = new Form_PrivateChat_Client()
            {
                Text = txt_name_client.Text
            };
            You.Show();
        }
    }
}
