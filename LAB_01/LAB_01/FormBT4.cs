using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01
{
    public partial class FormBT4 : Form
    {
        public FormBT4()
        {
            InitializeComponent();
            LoadFilm();
            LoadTicket();
        }

        //Mua vé
        public int total = 0;
        void buy_Ticket(Form sub_form)
        {
            //Xóa vé đã mua
            string selectedSeat = type_Seat.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedSeat))
            {
                Ticket selectedTicked = type_Ticket.SelectedItem as Ticket;
                if (selectedTicked != null)
                {
                    selectedTicked.seats.Remove(selectedSeat);
                    UpdateSeats(selectedTicked);
                }
            }
            type_Seat.Items.Remove(selectedSeat);

            sub_form.Show();
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {

            //Xuất vé
            buy_Ticket(new FormSubBT4(this));
        }

        //Hàm cập nhật lại danh sách
        private void UpdateSeats (Ticket ticket)
        {
            type_Seat.DataSource = null;
            type_Seat.DataSource = ticket.seats;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Thành phần tính giá tổng
        int price_curFilm = 0;
        string curType = "";

        //Hiển thị các phim được chiếu
        private List<Film> Films = new List<Film>();
        class Film
        {
            public string name_film { get; set; }
            public int price_ticket { get; set; }
            public List<int> room_show = new List<int>();
        }
        private void LoadFilm()
        {
            Films = new List<Film>()
            {
                new Film() {name_film = "Đào, phở và piano", price_ticket = 45000, room_show = {1, 2, 3} },
                new Film() {name_film = "Mai", price_ticket = 100000, room_show = {2, 3} },
                new Film() {name_film = "Gặp lại chị bầu", price_ticket = 70000, room_show = {1} },
                new Film() {name_film = "Đào, phở và piano", price_ticket = 90000, room_show = {3} }
            };

            list_Film.DataSource = Films;
            list_Film.DisplayMember = "name_film";
        }

        //Hiển thị phòng chiếu phim
        private void list_Film_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Film film = cb.SelectedValue as Film;
                price_curFilm = film.price_ticket;
                list_Room.DataSource = film.room_show;
            }
        }

        //Hiển thị loại vé
        class Ticket
        {
            public string type_ticket { get; set; }
            public List<string> seats = new List<string>();
        }
        List<Ticket> Tickets = new List<Ticket>();
        private void LoadTicket()
        {
            Tickets = new List<Ticket>()
            {
                new Ticket () {type_ticket = "Vé thường", seats = {"A2","A3","A4","C2","C3","C4"} },
                new Ticket () {type_ticket = "Vé vớt", seats = {"A1","A5","C1","C5"} },
                new Ticket () {type_ticket = "Vé VIP", seats = {"B2","B3","B4"} }
            };

            type_Ticket.DataSource = Tickets;
            type_Ticket.DisplayMember = "type_ticket";
        }

        //Hiển thị chỗ ngồi
        private void type_Ticket_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Ticket ticket = cb.SelectedValue as Ticket;
                curType = ticket.type_ticket;
                type_Seat.DataSource = ticket.seats;
            }
        }

        public string OutputName()
        {
            return txt_Name.Text;
        }

        public int OutputTotal()
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
            return list_Film.Text;
        }

        public string OutputTicket()
        {
            return type_Ticket.Text;
        }

        public string OutputSeat()
        {
            return type_Seat.Text;
        }

        public string OutputRoom()
        {
            return list_Room.Text;
        }

    }
}
