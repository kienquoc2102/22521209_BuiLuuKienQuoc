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
    public partial class Form_TCPclient_BT3 : Form
    {
        public Form_TCPclient_BT3()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient = new TcpClient();
        private NetworkStream ns;

        private void Connect()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ip, 8080);
            try
            {
                tcpClient.Connect(ipep);
                ns = tcpClient.GetStream();
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến Server");
                btn_Connect.Enabled = true;
            }
        }

        private void Send()
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(txt_Message.Text + "\n");
            ns.Write(data, 0, data.Length);
            txt_Message.Text = null;
        }

        private void Disconnect()
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes("quit\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
            
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            btn_Disconnect.Enabled = false;
            btn_Connect.Enabled = true;
            tcpClient = new TcpClient();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
