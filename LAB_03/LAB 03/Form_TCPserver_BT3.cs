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
    public partial class Form_TCPserver_BT3 : Form
    {
        public Form_TCPserver_BT3()
        {
            InitializeComponent();
        }

        private void StartUnSafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            Socket clientSocket;

            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 8080);

            listenerSocket.Bind(ipep);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            lv_Message.Items.Add(new ListViewItem("New Client connected"));
            while (clientSocket.Connected)
            {
                string txt = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    txt += Encoding.UTF8.GetString(recv);
                } while (txt[txt.Length - 1] != '\n');
                if (txt == "quit\n")
                {
                    lv_Message.Items.Add(new ListViewItem(txt));
                    listenerSocket.Close();
                    btn_Listen.Enabled = true;
                    break;
                }
                else
                    lv_Message.Items.Add(new ListViewItem(txt));
            }
            //listenerSocket.Close();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_Listen.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread severThread = new Thread(new ThreadStart(StartUnSafeThread));
            severThread.Start();
        }
    }
}
