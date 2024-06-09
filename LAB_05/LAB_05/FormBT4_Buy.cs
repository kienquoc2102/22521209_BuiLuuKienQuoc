using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using MailKit.Net.Smtp;
using MimeKit;
using System.Xml.Linq;

namespace LAB_05
{
    public partial class FormBT4_Buy : Form
    {
        public FormBT4_Buy(string name, string img)
        {
            InitializeComponent();
            LoadImg(img);
            LoadName(name);
            GetInfoFromJsonFile(name);
            DisplayRoom();
        }

        //Khai báo
        string img;
        Movie movie = new Movie();
        Room current_room = new Room();
        List<string> temp_seats = new List<string>();

        //Lấy thông tin chi tiết từ file JSon
        public void GetInfoFromJsonFile(string name)
        {
            List<Movie> movies = new List<Movie>();
            string filePath = "movies.json";
            try
            {
                string json = File.ReadAllText(filePath);
                movies = JsonSerializer.Deserialize<List<Movie>>(json);
                foreach (Movie m in movies)
                {
                    if (m.MovieName == name)
                    {
                        movie = m;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hiển thị
        public void LoadName(string name)
        {
            label_name.Text = name;
        }

        public void LoadImg(string img_url)
        {
            try
            {
                img = img_url;
                using (WebClient webClient = new WebClient())
                {
                    byte[] imgBytes = webClient.DownloadData($"{img_url}");

                    using (var ms = new System.IO.MemoryStream(imgBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pictureBox_film.Image = img;
                        pictureBox_film.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong truy cap dc");
            }
        }

        public void DisplayRoom()
        {
            List<Room> rooms = movie.Rooms;
            rooms.Insert(0, new Room { name = "Vui lòng chọn phòng chiếu phim" });
            comboBox_Rooms.DataSource = movie.Rooms;
            comboBox_Rooms.DisplayMember = "name";
            comboBox_Rooms.ValueMember = "name";
            comboBox_Rooms.SelectedIndex = 0;
        }

        private void DisplaySeat(Room room)
        {
            // Xóa tất cả các điều khiển hiện tại trên panel_Seats
            panel_Seats.Controls.Clear();

            if (room.available_seats == null)
            {
                label_room.Text = "Bạn chưa chọn phòng chiếu phim kìa!";
            }
            else
            {
                foreach (List<string> row in room.available_seats)
                {
                    // Tạo panel chứa các nút bấm chọn
                    Panel panel = new Panel();
                    panel.Size = new System.Drawing.Size(1026, 45);

                    // Xác định vị trí mặc định của panel
                    if (panel_Seats.Controls.Count > 0)
                    {
                        Panel lastPanel = (Panel)panel_Seats.Controls[panel_Seats.Controls.Count - 1];
                        panel.Top = lastPanel.Bottom + 10; // Vị trí Y của panel mới là vị trí dưới cùng của panel trước đó cộng với một khoảng trống (10 pixel)
                    }
                    else
                    {
                        panel.Top = 0;
                    }

                    // Thêm panel vào panel_Seats
                    panel_Seats.Controls.Add(panel);

                    // Thêm các nút bấm vào panel
                    foreach (string btn in row)
                    {
                        if (room.bought_seats.Contains(btn))
                        {
                            // Tạo nút bấm
                            Button button = new Button();
                            button.Size = new System.Drawing.Size(45, 45);
                            button.Text = btn;
                            button.BackColor = Color.Red;
                            button.ForeColor = Color.White;

                            // Xác định vị trí X của nút mới
                            if (panel.Controls.Count > 0)
                            {
                                Button lastButton = (Button)panel.Controls[panel.Controls.Count - 1];
                                button.Left = lastButton.Right + 1; // Vị trí X của nút mới là vị trí bên phải của nút trước đó cộng với một khoảng trống (1 pixel)


                            }
                            else
                            {
                                button.Left = 0;
                            }

                            // Thêm nút vào panel
                            panel.Controls.Add(button);
                        }
                        else
                        {
                            // Tạo nút bấm
                            Button button = new Button();
                            button.Size = new System.Drawing.Size(45, 45);
                            button.Text = btn;

                            button.Click += new EventHandler(Button_Click);

                            // Xác định vị trí X của nút mới
                            if (panel.Controls.Count > 0)
                            {
                                Button lastButton = (Button)panel.Controls[panel.Controls.Count - 1];
                                button.Left = lastButton.Right + 1; // Vị trí X của nút mới là vị trí bên phải của nút trước đó cộng với một khoảng trống (1 pixel)


                            }
                            else
                            {
                                button.Left = 0;
                            }

                            // Thêm nút vào panel
                            panel.Controls.Add(button);
                        }

                    }
                }
            }
        }

        // Hàm xử lý sự kiện click của nút bấm
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (!temp_seats.Contains(clickedButton.Text))
                {
                    // Thực hiện các hành động khác với seatNumber ở đây
                    clickedButton.BackColor = Color.DeepSkyBlue;
                    clickedButton.ForeColor = Color.White;
                    temp_seats.Add(clickedButton.Text);
                }
                else
                {
                    clickedButton.BackColor = Color.White;
                    clickedButton.ForeColor = Color.Black;
                    temp_seats.Remove(clickedButton.Text);
                }
            }
        }

        private void comboBox_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_room = comboBox_Rooms.Text;
            foreach (Room room in movie.Rooms)
            {
                if (room.name == id_room)
                {
                    current_room = room;
                    DisplaySeat(room);
                    label_room.Text = room.name;
                    break;
                }
                else
                {
                    label_room.Text = "Bạn chưa chọn phòng chiếu phim kìa!";
                }
            }
        }

        //Hàm thao tác mua vé
        private void BuyTicket()
        {
            string nameclient = txt_nameclient.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string namefilm = label_name.Text;
            string room = current_room.name;
            List<string> seats = temp_seats;

            FormBT4_Total f = new FormBT4_Total(nameclient, email, phone, namefilm, room, seats);
            UpdateJsonFile(namefilm, room, seats);
            SendMail(nameclient, email, phone, namefilm, room, seats);
            f.Show();
            f.fb = this;
        }

        private void SendMail(string nameclient, string email, string phone, string namefilm, string room, List<string> seats)
        {
            string subject = "THÔNG BÁO ĐẶT VÉ THÀNH CÔNG";
            string str_seat = "";
            string total = (seats.Count() * 45000).ToString();
            foreach (string seat in seats)
            {
                str_seat += $"{seat} ";
            }

            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("rapphimdomdom@gmail.com", "osmw jcan gwag wxwc");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("rapphimdomdom", "rapphimdomdom@gmail.com"));
            message.To.Add(new MailboxAddress("", $"{email}"));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = $"BẠN ĐÃ ĐẶT VÉ THÀNH CÔNG\n" +
                $"- Họ và tên: {nameclient}\n" +
                $"- Email: {email}\n" +
                $"- Số điện thoại: {phone}\n" +
                $"- Phim: {namefilm}\n" +
                $"- Phòng chiếu: {room}\n" +
                $"- Ghế: {str_seat}\n" +
                $"- Giá vé: 45000/vé\n" +
                $"- Tổng tiền: {total}"
            };

            client.Send(message);
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            BuyTicket();
        }

        //Hàm cập nhật lại số lượng vé sau khi được mua
        private List<Movie> GetListFilm()
        {
            List<Movie> listfilm = new List<Movie>();
            string filePath = "movies.json";

            string json = File.ReadAllText(filePath);
            listfilm = JsonSerializer.Deserialize<List<Movie>>(json);
            return listfilm;
        }

        private void UpdateJsonFile(string namefilm, string room, List<string> seats)
        {
            string filePath = "movies.json";
            List<Movie> list = GetListFilm();

            foreach (Movie movie in list)
            {
                if (movie.MovieName == namefilm)
                {
                    foreach (Room r in movie.Rooms)
                    {
                        if (r.name == room)
                        {
                            foreach (List<string> row in r.available_seats)
                            {
                                foreach (string s in seats)
                                {
                                    if (row.Contains(s))
                                    {
                                        //row.Remove(s);
                                        r.bought_seats.Add(s);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                string jsonString = JsonSerializer.Serialize(list, options);

                // Ghi chuỗi JSON vào tệp với encoding UTF-8
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    sw.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
