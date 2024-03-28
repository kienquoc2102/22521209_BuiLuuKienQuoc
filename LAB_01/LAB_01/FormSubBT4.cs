using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01
{
    public partial class FormSubBT4 : Form
    {
        private FormBT4 parentForm { get; set; }
        public FormSubBT4(FormBT4 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            LoadInfo();
        }
        
        public void LoadInfo()
        {
            display_name.Text = parentForm.OutputName();
            display_film.Text = parentForm.Outputfilm();
            display_total.Text = parentForm.OutputTotal().ToString();
            display_ticket.Text = parentForm.OutputTicket();
            display_seat.Text = parentForm.OutputSeat();
            display_room.Text = parentForm.OutputRoom();
        }
    }
}
