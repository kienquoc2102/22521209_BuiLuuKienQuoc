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
    public partial class Form_UDPserver_BT1 : Form
    {
        public Form_UDPserver_BT1()
        {
            InitializeComponent();
        }

        private void serverThread()
        {
            UdpClient udpClient = new UdpClient(8080);
            while (true)
            {
                IPEndPoint RemoteIPEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIPEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string message = RemoteIPEndPoint.ToString() + ": " + returnData + Environment.NewLine;
                displayMessage(message);
            }
        }

        private void displayMessage(string mess)
        {
            lv_Messages.Items.Add(mess);
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_Listen.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
    }
}
