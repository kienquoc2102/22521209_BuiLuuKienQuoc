using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LAB_02.FormBT5;

namespace LAB_02
{
    public partial class FormBT5 : Form
    {
        public FormBT5()
        {
            InitializeComponent();
            LoadListFilm();
            DisplayListFilm();
            DisplayTypeTicket();
        }

        //Tạo biến
        List<Film> films = new List<Film>();
        List<Type_Ticket> type_Tickets = new List<Type_Ticket>();
        List<Ticket> total_tickets = new List<Ticket>();
        List<Statis> statis = new List<Statis>();
        long total = 0;
        string curType = "";
        long price_curFilm = 0;

        //Tạo class Ticket
        public class Ticket
        {
            public string name { get; set; }
            public string film { get; set; }
            public long total { get; set; }
            public Ticket(string name, string film, long total)
            {
                this.name = name;
                this.film = film;
                this.total = total;
            }
            public string ToString()
            {
                return $"{name} - {film} - {total}";
            }
        }

        //Tạo class Type_Ticket
        public class Type_Ticket
        {
            public string type_name { get; set; }
            public string[] seats { get; set; }
            public Type_Ticket(string type_name, string[] seats)
            {
                this.type_name = type_name;
                this.seats = seats;
            }
        }

        //Tạo class Film
        public class Film
        {
            public string film_name { get; set; }
            public long price_ticket { get; set; }
            public string[] room { get; set; }
            public Film(string Film_name, long Price_ticket, string[] Room)
            {
                film_name = Film_name;
                price_ticket = Price_ticket;
                room = Room;
            }
            public string ToString()
            {
                return $"Film: {film_name}, price: {price_ticket}, room: {room}";
            }
        }

        //Tạo class thống kê
        public class Statis
        {
            public string film_name { get; set; }
            public int sold_ticket { get; set; }
            public int remain_ticket { get; set; }
            public long total_money { get; set; }
            //public int rank { get; set; }
            public Statis(string film_name, int sold_ticket, int remain_ticket, long total_money)
            {
                this.film_name = film_name;
                this.sold_ticket = sold_ticket;
                this.remain_ticket = remain_ticket;
                this.total_money = total_money;
                //this.rank = rank;
            }
            public string ToString()
            {
                return $"{film_name}-{sold_ticket}-{remain_ticket}-{total_money}";
            }
        }
        //Deserialize Input5
        public List<Film> DeserializeToFileStream(string filePath)
        {
            List<Film> films = new List<Film>();
            try
            {
                using (StreamReader rd = new StreamReader(filePath))
                {
                    string line;
                    while ((line = rd.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" - ");
                        if (parts.Length == 3)
                        {
                            string name = parts[0];
                            long price = long.Parse(parts[1]);
                            string[] room = parts[2].Split(",");
                            films.Add(new Film(name, price, room));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return films;
        }

        //Load Danh sách film
        public void LoadListFilm()
        {
            films = DeserializeToFileStream("Input5.txt");
           
        }
        public void DisplayListFilm()
        {
            cb_ListFilm.DataSource = films;
            cb_ListFilm.DisplayMember = "film_name";
        }
        //Hiển thị phòng chiếu phim
        private void cb_ListFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Film film = cb.SelectedValue as Film;
                price_curFilm = film.price_ticket;
                cb_ListRoom.DataSource = film.room;
                string[] type_0 = { "A2", "A3", "A4", "C2", "C3", "C4" };
                string[] type_1 = { "A1", "A5", "C1", "C5" };
                string[] type_2 = { "B2", "B3", "B4" };
                type_Tickets = new List<Type_Ticket>()
                {
                    new Type_Ticket("Vé thường", type_0),
                    new Type_Ticket("Vé vớt", type_1),
                    new Type_Ticket("Vé VIP", type_2),
                };
                DisplayTypeTicket();
            }
            
        }
        //Hiển thị loại vé
        private void DisplayTypeTicket()
        {
            cb_List_TypeTicket.DataSource = type_Tickets;
            cb_List_TypeTicket.DisplayMember = "type_name";
        }
        //Hiển thị chỗ ngồi
        private void cb_List_TypeTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Type_Ticket type = cb.SelectedValue as Type_Ticket;
                curType = type.type_name;
                cb_ListSeat.DataSource = type.seats;
            }
        }

        //Thao tác mua vé
        void buy_Ticket(Form sub_form)
        {
            //Xóa vé đã mua
            string selectedSeat = cb_ListSeat.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedSeat))
            {
                Type_Ticket selectedTicket = cb_List_TypeTicket.SelectedItem as Type_Ticket;
                if (selectedTicket != null)
                {
                    selectedTicket.seats = selectedTicket.seats.Where(seat => seat != selectedSeat).ToArray();
                    UpdateSeats(selectedTicket);
                }
            }
            cb_ListSeat.Items.Remove(selectedSeat);

            sub_form.Show();
        }
        private void UpdateSeats(Type_Ticket ticket)
        {
            cb_ListSeat.DataSource = null;
            cb_ListSeat.DataSource = ticket.seats;
        }
        public string OutputName()
        {
            return text_Name.Text;
        }

        public long OutputTotal()
        {
            if (curType == "Vé VIP")
            {
                total = 2 * price_curFilm;
            }
            if (curType == "Vé thường")
            {
                total = price_curFilm;
            }
            if (curType == "Vé vớt")
            {
                total = price_curFilm / 4;
            }
            return total;
        }

        public string Outputfilm()
        {
            return cb_ListFilm.Text;
        }

        public string OutputTicket()
        {
            return cb_List_TypeTicket.Text;
        }

        public string OutputSeat()
        {
            return cb_ListSeat.Text;
        }

        public string OutputRoom()
        {
            return cb_ListRoom.Text;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            buy_Ticket(new FormSubBT5(this));
            total_tickets.Add(new Ticket(OutputName(), Outputfilm(), OutputTotal()));
        }

        //Xử lý thống kê
        //Serialize Output5
        public static void SerializeToFileStream_Output5(string filePath, List<Statis> items)
        {
            try
            {
                using (StreamWriter wr = new StreamWriter(filePath))
                {
                    foreach (Statis item in items)
                    {
                        wr.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        //Tính toán thống kê
        public void GetInfoStatis(string Film_Name)
        {
            int sold = 0;
            int remain = 0;
            long totalMoney = 0;
            foreach (Ticket ticket in total_tickets)
            {
                if (ticket.film == Film_Name)
                {
                    sold++;
                    remain = 100 - sold;
                    totalMoney += ticket.total;
                }
            }
            statis.Add(new Statis(Film_Name, sold, remain, totalMoney));
        }

        private void buttonStatis_Click(object sender, EventArgs e)
        {
            foreach (Film film in films)
            {
                GetInfoStatis(film.film_name);
            }    
            SerializeToFileStream_Output5("Output5.txt", statis);
            Statis_Form(new FormSubBT5_1(this));
        }

        public void Statis_Form (Form sub_form)
        {
            sub_form.Show();
        }
    }

}
