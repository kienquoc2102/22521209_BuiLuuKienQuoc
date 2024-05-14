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
    public partial class FormBT5 : Form
    {
        public FormBT5()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void btn_OpenClient_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_TCPclient_BT5());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_TCPserver_BT5());
        }
    }
}
