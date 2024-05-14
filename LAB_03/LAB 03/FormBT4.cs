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
    public partial class FormBT4 : Form
    {
        public FormBT4()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void btn_OpenClient_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_TCPclient_BT4());
        }

        private void btn_OpenServer_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_TCPserver_BT4());
        }
    }
}
