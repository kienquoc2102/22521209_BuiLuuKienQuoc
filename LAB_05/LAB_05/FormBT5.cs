using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MailKit.Net.Imap;
using MailKit;
using System.Text.RegularExpressions;
namespace LAB_05
{
    public partial class FormBT5 : Form
    {
        public FormBT5()
        {
            InitializeComponent();
            GetFoodFromDB();
            ReceiveMail();
            DisplayMenu();
        }

        //I. Khai báo
        private string connectionString = "Data Source=DESKTOP-DSII5ET\\SQLEXPRESS;Initial Catalog=FoodDB;Integrated Security=True;";
        private List<Food> foods = new List<Food>();

        private class Food
        {
            public int foodID { get; set; }
            public string foodName { get; set; }
            public string foodAddr { get; set; }
            public string contributor { get; set; }
            public decimal price { get; set; }
            public string img { get; set; }
        }

        //II. Thao tác với CSDL
        private void GetFoodFromDB()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM food";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Food food = new Food()
                            {
                                foodID = reader.GetInt32(0),
                                foodName = reader.GetString(1),
                                foodAddr = reader.GetString(2),
                                contributor = reader.GetString(3),
                                price = reader.GetDecimal(4),
                                img = reader.GetString(5)
                            };
                            foods.Add(food);
                        }
                    }
                }
            }
        }

        private void AddFood(Food food)
        {
            string query = $"INSERT INTO food (MaMonAn, TenMonAn, DiaChi, NguoiDongGop, Gia, IMGurl) VALUES ({food.foodID}, N'{food.foodName}', N'{food.foodAddr}', N'{food.contributor}', {food.price}, N'{food.img}');";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            foods.Add(food);
        }

        //III. Hiển thị
        private void DisplayMenu()
        {
            panel_Menu.Controls.Clear();
            if (foods.Count == 0)
            {
                MessageBox.Show("Chưa có món ăn nào trong Menu!");
            }
            else
            {
                foreach (var food in foods)
                {
                    // Tạo panel
                    Panel panel = new Panel();
                    panel.Size = new Size(704, 154);

                    if (panel_Menu.Controls.Count > 0)
                    {
                        Panel lastPanel = (Panel)panel_Menu.Controls[panel_Menu.Controls.Count - 1];
                        panel.Top = lastPanel.Bottom; // Vị trí Y của panel mới là vị trí dưới cùng của panel trước đó cộng với một khoảng trống (10 pixel)
                    }

                    panel_Menu.Controls.Add(panel);

                    FormBT5_Food form = new FormBT5_Food(food.foodID,food.foodName, food.price, food.foodAddr, food.contributor, food.img);
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    panel.Controls.Add(form);
                    panel.Tag = form;
                    form.Show();
                }
            }
        }

        //Hàm random id
        private int RandID()
        {
            Random random = new Random();
            int id = random.Next(0, 1000);
            return id;
        }

        //Xử lý tách chuỗi thành mảng
        private string[] HandleString(string str)
        {
            string[] arr = str.Split(';');
            return arr;
        }

        //IV. Nhận mail thêm món ăn
        private void ReceiveMail()
        {
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate("rapphimdomdom@gmail.com", "osmw jcan gwag wxwc");
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = 0; i < inbox.Count; i++)
            {
                //Lấy thông tin món ăn từ email
                var message = inbox.GetMessage(i);
                // Kiểm tra tiêu đề của email
                if (message.Subject.Contains("Đóng góp món ăn"))
                {
                    // Lấy thông tin món ăn từ email
                    string[] info = HandleString(message.TextBody);
                    string contrib = GetNameFromInput(message.From.ToString());
                    Food food = new Food()
                    {
                        foodID = RandID(),
                        foodName = info[0],
                        foodAddr = info[1],
                        contributor = contrib,
                        price = decimal.Parse(info[2]),
                        img = info[3]
                    };

                    // Kiểm tra xem món ăn có tồn tại trong danh sách hay không
                    bool exists = foods.Any(f =>
                        f.foodName == food.foodName &&
                        f.foodAddr == food.foodAddr &&
                        f.contributor == food.contributor &&
                        f.img == food.img
                    );

                    // Add món ăn được lấy từ email vào CSDL nếu chưa tồn tại
                    if (!exists)
                    {
                        AddFood(food);
                        
                    }
                }
            }

        }

        //Hàm Reload lại menu
        private void Reload()
        {
            ReceiveMail();
            DisplayMenu();
        }
        public void btn_Reload_Click(object sender, EventArgs e)
        {
            Reload();
        }


        //Xử lý lấy tên người đóng góp từ message.From
        string GetNameFromInput(string input)
        {
            // Tìm vị trí của dấu ngoặc kép đầu tiên và cuối cùng trong chuỗi
            int firstQuoteIndex = input.IndexOf('\"');
            int lastQuoteIndex = input.LastIndexOf('\"');

            // Kiểm tra nếu cả hai dấu ngoặc kép đều tồn tại
            if (firstQuoteIndex != -1 && lastQuoteIndex != -1 && firstQuoteIndex != lastQuoteIndex)
            {
                // Lấy phần chuỗi giữa hai dấu ngoặc kép
                return input.Substring(firstQuoteIndex + 1, lastQuoteIndex - firstQuoteIndex - 1);
            }

            // Trường hợp không tìm thấy dấu ngoặc kép hợp lệ
            return input;
        }

        //V. Lấy ngẫu nhiên món ăn
        private void GetRandFood()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, foods.Count - 1);
            FormBT5_Food f = new FormBT5_Food(foods[index].foodID, foods[index].foodName, foods[index].price, foods[index].foodAddr, foods[index].contributor, foods[index].img);
            f.Show();
        }

        private void btn_RandomFind_Click(object sender, EventArgs e)
        {
            GetRandFood();
        }
    }
}
