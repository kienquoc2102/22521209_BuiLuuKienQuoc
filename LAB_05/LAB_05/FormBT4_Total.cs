using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LAB_05
{
    public partial class FormBT4_Total : Form
    {
        public FormBT4_Total(string nameclient, string email, string phone, string namefilm, string room, List<string> seats)
        {
            InitializeComponent();
            LoadTicket(nameclient, email, phone, namefilm, room, seats);
        }

        public FormBT4_Buy fb;

        private void LoadTicket(string nameclient, string email, string phone, string namefilm, string room, List<string> seats)
        {
            lb_nameClient.Text = nameclient;
            lb_phone.Text = phone;
            lb_email.Text = email;
            lb_nameFilm.Text = namefilm;
            lb_room.Text = room;
            lb_seats.Text = null;
            foreach (string seat in seats)
            {
                lb_seats.Text += $"{seat} ";
            }
            lb_price.Text = $"{45000}/vé";
            lb_total.Text = (seats.Count() * 45000).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fb.Close();
            this.Close();
        }
    }
}
