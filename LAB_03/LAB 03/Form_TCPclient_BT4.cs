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
    public partial class Form_TCPclient_BT4 : Form
    {
        public Form_TCPclient_BT4()
        {
            InitializeComponent();
        }

        //Khai báo
        public class Ticket
        {
            public string name { get;set;}
            public List<Film> film { get;set;}

            public Ticket(string name, List<Film> film)
            {
                this.name = name;
                this.film = film;
            }
        }

        public class Film
        {
            public string name { get;set;} 
            public List<Room> room { get;set;}
            public Film(string name, List<Room> room)
            {
                this.name = name;
                this.room = room;
            }
        }

        public class Room
        {
            public string name { get;set;}
            public List<TypeTicket> type { get;set;}
            public Room(string name, List<TypeTicket> type)
            {
                this.name = name;
                this.type = type;
            }
        }

        public class TypeTicket
        {
            public string name { get;set;}
            public List<string> seats { get;set;}  
            public TypeTicket(string name, List<string> seats)
            {
                this.name = name;
                this.seats = seats;
            }
        }

        public List<string> GetRow(string type)
        {
            List<string> row = new List<string>();
            if (type == "VIP")
            {
                for (int i = 0; i < 100; i++)
                {
                    row[i] = $"C{i}";
                }
            }
            else if (type == "Thuờng")
            {
                for (int i = 0; i < 100; i++)
                {
                    row[i] = $"B{i}";
                }
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    row[i] = $"A{i}";
                }
            }
            return row;
        }

        private List<Ticket> ticket_List = new List<Ticket>();
        private List<Film> film_list = new List<Film>();
        private List<Room> room_list = new List<Room>();
        private List<TypeTicket> type_list = new List<TypeTicket>();
        private delegate void filmDelegate();
        private delegate void roomDelegate();
        private delegate void typeTicketDelegate();
        private delegate void seatDelegate();

        //Hàm hiển thị
        private void DisplayFilm()
        {
            if (cb_listFilm.InvokeRequired)
            {
                var invoke = new filmDelegate(DisplayFilm);
                cb_listFilm.Invoke(invoke);
            }
            else
            {
                cb_listFilm.DataSource = "";
            }
        }
    }
}
