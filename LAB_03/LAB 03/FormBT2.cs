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
    public partial class FormBT2 : Form
    {
        public FormBT2()
        {
            InitializeComponent();
        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            //Socket bên gửi
            Socket clientSocket;

            //Socket bên nhận
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(IPepServer);

            //Bắt đầu lắng nghe
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            lv_Cmd.Items.Add(new ListViewItem("New client connected"));

            //Nhận dữ liệu
            while (clientSocket.Connected)
            {
                string txt = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    txt += Encoding.ASCII.GetString(recv);
                } while (txt[txt.Length - 1] != '\n');
                lv_Cmd.Items.Add(new ListViewItem(txt));
            }
            listenerSocket.Close();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_Listen.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread severThread = new Thread(new ThreadStart(StartUnsafeThread));
            severThread.Start();
        }
    }
}
