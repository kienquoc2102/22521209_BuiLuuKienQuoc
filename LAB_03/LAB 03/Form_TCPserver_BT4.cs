using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_03
{
    public partial class Form_TCPserver_BT4 : Form
    {
        public Form_TCPserver_BT4()
        {
            InitializeComponent();
            Loadfilm();
            DisplayInfo();
        }

        //I. Khai báo
        public class Film
        {
            public string name { get; set; }
            public long price { get; set; }
            public string[] rooms { get; set; }
            public int num_seats { get; set; }

            public Film(string name, long price, string[] rooms, int num_seats)
            {
                this.name = name;
                this.price = price;
                this.rooms = rooms;
                this.num_seats = num_seats;
            }

            public string getRoom(string[] rooms)
            {
                string str = "";
                for (int i = 0; i < rooms.Length; i++)
                {
                    if (i == rooms.Length - 1)
                        str += rooms[i];
                    else
                        str += $"{rooms[i]}, ";
                }    
                return str;
            }
        }
        private List<Film> list_film = new List<Film>();
        private delegate void infoDelegate();

        //II. Đọc File và hiển thị thông tin
        //Đọc File
        public List<Film> DeserializeToFileStream(string filepath)
        {
            List<Film> list_film = new List<Film> ();
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(" - ");
                        if (parts.Length == 4)
                        {
                            string name = parts[0];
                            long price = long.Parse(parts[1]);
                            string[] rooms = parts[2].Split(",");
                            int num_seats = int.Parse(parts[3]);
                            list_film.Add(new Film(name, price, rooms, num_seats));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list_film;
        }

        //Load danh sách phim
        private void Loadfilm()
        {
            list_film = DeserializeToFileStream("Input5.txt");
        }

        //Hiển thị
        private void DisplayInfo()
        {
            if (lb_InfoCine.InvokeRequired)
            {
                var invoke = new infoDelegate(DisplayInfo);
                lb_InfoCine.Invoke(invoke);
            }
            else
            {
                foreach(Film film in list_film)
                {
                    lb_InfoCine.Items.Add($"Phim: {film.name} - Giá (VNĐ/người): {film.price} - Phòng: {film.getRoom(film.rooms)} - Số lượng vé: {film.num_seats} \n");
                }    
            }   
        }
    }
}
