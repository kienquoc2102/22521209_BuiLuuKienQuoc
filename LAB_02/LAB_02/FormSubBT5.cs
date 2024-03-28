using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02
{
    public partial class FormSubBT5 : Form
    {
        private FormBT5 parentForm { get; set; }
        public FormSubBT5(FormBT5 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            LoadInfo();
        }
        public void LoadInfo()
        {
            text_Name.Text = parentForm.OutputName();
            text_Film.Text = parentForm.Outputfilm();
            text_Total.Text = parentForm.OutputTotal().ToString();
            text_type_Ticket.Text = parentForm.OutputTicket();
            text_Seat.Text = parentForm.OutputSeat();
            text_Room.Text = parentForm.OutputRoom();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
