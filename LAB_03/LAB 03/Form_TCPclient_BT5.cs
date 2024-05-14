using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class Form_TCPclient_BT5 : Form
    {
        public Form_TCPclient_BT5()
        {
            InitializeComponent();
        }

        //Khai báo
        private TcpClient tcpClient;
        private IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        private delegate void menufoodDelegate(string[] menu);
        private delegate void clearDelegate();

        //Hiển thị
        private void DisplayMenu(string[] menu)
        {
            if (lb_DisplayFood.InvokeRequired)
            {
                var invoke = new menufoodDelegate(DisplayMenu);
                lb_DisplayFood.Invoke(invoke, new object[] { menu });
            }
            else
            {
                foreach (string food in menu)
                    lb_DisplayFood.Items.Add(food);
            }
        }

        private void ClearMenu()
        {
            if (lb_DisplayFood.InvokeRequired)
            {
                var invoke = new clearDelegate(ClearMenu);
                lb_DisplayFood.Invoke(invoke);
            }
            else
                lb_DisplayFood.Items.Clear();
        }

        //Chuỗi -> mảng
        private string[] GetArr(string menu)
        {
            string[] arr = menu.Split('\n');
            return arr;
        }

        //Lấy Request
        private string GetRequest()
        {
            int ran_id_rest = RandomID();
            int ran_id_food = RandomID();
            string request = $"INSERT INTO NhaCungCap(IDNCC, Ten, QuyenHan) VALUES ('{ran_id_rest}', '{txt_Name.Text}', 'Chu Quan') \nINSERT INTO MonAn (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES ('{ran_id_food}', '{txt_Food.Text}', 'food.png', '{ran_id_rest}');";
            return request;
        }

        //Hàm Random
        private int RandomID()
        {
            Random rand = new Random();
            int rand_id = rand.Next(202, 2000);
            return rand_id;
        }

        //Kết nối
        private void Connect()
        {
            tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(ip);

                Packet_BT5 sendData = new Packet_BT5()
                {
                    RequestDataIdentifier = RequestIdentifier.Login,
                    RequestName = txt_userName.Text,
                    RequestMessage = ""
                };
                byte[] data = sendData.GetDataStream();
                NetworkStream ns = tcpClient.GetStream();
                ns.Write(data, 0, data.Length);
                ns.Flush();

                Thread Listen = new Thread(Receive);
                Listen.IsBackground = true;
                Listen.Start();
            }
            catch { }
        }

        private void Disconnect()
        {
            Packet_BT5 sendData = new Packet_BT5()
            {
                RequestDataIdentifier = RequestIdentifier.Logout,
                RequestName = "User",
                RequestMessage = ""
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

        private void Receive()
        {
            while (true)
            {
                NetworkStream ns = tcpClient.GetStream();

                byte[] data = new byte[1024];
                int byte_length = ns.Read(data, 0, data.Length);
                if (byte_length == 0)
                    break;

                Packet_BT5 receivedData = new Packet_BT5(data);
                if (receivedData.RequestDataIdentifier == RequestIdentifier.Login)
                {
                    ClearMenu();
                    DisplayMenu(GetArr(receivedData.RequestMessage));
                }
                else if (receivedData.RequestDataIdentifier == RequestIdentifier.Request)
                {
                    ClearMenu();
                    DisplayMenu(GetArr(receivedData.RequestMessage));
                }
                else
                {
                    if (receivedData.RequestMessage != "")
                        DisplayMenu(GetArr(receivedData.RequestMessage));
                }
            }
        }

        private void Send()
        {
            Packet_BT5 sendData = new Packet_BT5()
            {
                RequestDataIdentifier = RequestIdentifier.Request,
                RequestName = txt_userName.Text,
                RequestMessage = GetRequest()
            };
            byte[] data = sendData.GetDataStream();
            NetworkStream ns = tcpClient.GetStream();
            ns.Write(data, 0, data.Length);
            ns.Flush();
        }

        //Hàm thao tác
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Send();
            txt_Food.Text = null;
            txt_Name.Text = null;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            btn_Connect.Enabled = false;
            Connect();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Disconnect();
            this.Close();
        }

        //Tìm món ăn ngẫu nhiên
        private string RandomFood()
        {
            Random rd = new Random();
            string food = "";
            int max = lb_DisplayFood.Items.Count - 1;
            int rand_i = rd.Next(0, max);
            food = lb_DisplayFood.Items[rand_i].ToString();
            return food;
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            txt_DisplayFood.Text = RandomFood();
        }
    }
}
