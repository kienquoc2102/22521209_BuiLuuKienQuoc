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
    public partial class FormBT1 : Form
    {
        public FormBT1()
        {
            InitializeComponent();
        }

        List<Form> list_opened_form = new List<Form>();

        private void OpenForm(Form form)
        {
            form.Show();
            list_opened_form.Add(form);
        }

        private void CloseAllForms()
        {
            foreach (Form form in list_opened_form)
            {
                form.Close();
            }
        }

        private void btn_open_Server_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_UDPserver_BT1());
        }

        private void btn_open_Client_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_UDPclient_BT1());
        }

        private void FormBT1_Leave(object sender, EventArgs e)
        {
            CloseAllForms();
            this.Close();
        }
    }
}
