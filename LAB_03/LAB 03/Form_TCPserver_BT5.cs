using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class Form_TCPserver_BT5 : Form
    {
        public Form_TCPserver_BT5()
        {
            InitializeComponent();
            LoadMenu();
            
        }

        //I. Khai báo
        private TcpListener tcpServer;
        private Dictionary<string, TcpClient> client_list = new Dictionary<string, TcpClient>();
        private delegate void LoadMenuDelegate();
        private List<string[]> food_List = new List<string[]>();

        //Chuỗi -> Mảng
        private string[] GetArr(string str_request)
        {
            string[] arr = str_request.Split('\n');
            return arr;
        }


        //Mảng -> Chuỗi
        private string GetString()
        {
            string message = "";
            foreach (string[] food in food_List)
            {
                message += $"{food[0]} - Địa chỉ: {food[1]} \n";
            }
            return message;
        }

        //II. Cơ sở dữ liệu
        //Chuỗi kết nối
        public string connectionString = @"Data Source=DESKTOP-DSII5ET\SQLEXPRESS;Initial Catalog=BAITAP4;Integrated Security=True;";

        //Lấy món ăn từ CSDL
        private DataSet GetAllFood()
        {
            DataSet data = new DataSet();

            //Chuỗi truy vấn
            string query = "select TenMonAn as 'Ten Mon an', Ten as 'Ten Quan an' From NhaCungCap, MonAn where NhaCungCap.IDNCC = MonAn.IDNCC";

            //SQL Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return data;
        }

        //Thêm món ăn
        private void AddFood(string[] request)
        {
            string request_add_rest = request[0];
            string request_add_food = request[1];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(request_add_rest, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(request_add_food, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //Hiển thị món ăn
        private void LoadMenu()
        {
            if (dG_DisplayFood.InvokeRequired)
            {
                var invoke = new LoadMenuDelegate(LoadMenu);
                dG_DisplayFood.Invoke(invoke);
            }
            else
            {
                dG_DisplayFood.DataSource = GetAllFood().Tables[0];
                dG_DisplayFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                food_List = GetFoodFromDb();
            }
        }

        //Hàm tạo mảng món ăn
        private List<string[]> GetFoodFromDb()
        {
            List<string[]> food_list = new List<string[]>();
            foreach (DataGridViewRow dg in dG_DisplayFood.Rows)
            {
                if (!dg.IsNewRow && dg.Cells[0].Value != null)
                {
                    string[] food = new string[2];
                    food[0] = dg.Cells[0].Value.ToString();
                    food[1] = dg.Cells[1].Value.ToString();
                    food_list.Add(food);
                }
            }
            return food_list;
        }

        //III. Kết nối
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
        private void sendAllclient(Packet_BT5 sendData, TcpClient sender)
        {
            byte[] data = sendData.GetDataStream();
            foreach (TcpClient client in client_list.Values)
            {
                NetworkStream ns = client.GetStream();
                ns.Write(data, 0, data.Length);
                ns.Flush();
            }
        }


        private string GetStringLast()
        {
            string message = "";
            message += $"{food_List[food_List.Count - 1][0]} - Địa chỉ: {food_List[food_List.Count - 1][1]} \n";
            return message;
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
                Packet_BT5 receivedData = new Packet_BT5(data);
                Packet_BT5 sendData = new Packet_BT5()
                {
                    RequestDataIdentifier = receivedData.RequestDataIdentifier,
                    RequestName = receivedData.RequestName,
                };
                string message = "";
                switch (receivedData.RequestDataIdentifier)
                {
                    case RequestIdentifier.Login:
                        if (!client_list.ContainsKey(receivedData.RequestName))
                        {
                            client_list.Add(receivedData.RequestName, client);
                            
                        }
                        message = GetString();
                        sendData.RequestMessage = message;
                        break;
                    case RequestIdentifier.Request:
                        AddFood(GetArr(receivedData.RequestMessage));
                        LoadMenu();
                        message = GetString();
                        sendData.RequestMessage = message;
                        break;
                    case RequestIdentifier.Logout:
                        foreach (KeyValuePair<string, TcpClient> kvp in client_list)
                        {
                            if (kvp.Value.Equals(client))
                            {
                                client_list.Remove(kvp.Key);
                                break;
                            }
                        }
                        break;
                }
                sendAllclient(sendData, client);
            }
        }
        
        //Hàm thao tác
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            btn_Listen.Enabled = false;
            Thread serverThread = new Thread(new ThreadStart(Connect));
            serverThread.IsBackground = true;
            serverThread.Start();
        }
    }
}
