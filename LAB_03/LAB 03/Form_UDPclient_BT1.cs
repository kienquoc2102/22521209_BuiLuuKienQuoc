using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class Form_UDPclient_BT1 : Form
    {
        public Form_UDPclient_BT1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //Tạo kết nối UDP
            UdpClient udpClient = new UdpClient();

            //Chuyển text message -> byte
            Byte[] sendBytes = Encoding.UTF8.GetBytes(txt_Message.Text);
            
            //Gửi không cần kết nối Server
            udpClient.Send(sendBytes, sendBytes.Length, txt_IP.Text, int.Parse(txt_Port.Text));

            displayMessage(txt_Message.Text);
            txt_Message.Clear();
        }

        //Hàm hiển thị tin nhắn đã gửi
        private void displayMessage (string mess)
        {
            lv_Message.Items.Add(mess);
        }
    }
}
