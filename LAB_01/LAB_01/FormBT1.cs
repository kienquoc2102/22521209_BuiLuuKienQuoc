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
    public partial class FormBT1 : Form
    {
        public FormBT1()
        {
            InitializeComponent();
        }

        private void bntCalc_Click(object sender, EventArgs e)
        {
            string str_Input_1 = txtInput_1.Text;
            string str_Input_2 = txtInput_2.Text;

            if (int.TryParse(str_Input_1, out int int_Input_1) && int.TryParse(str_Input_2, out int int_Input_2))
            {
                int sum = 0;
                sum = int_Input_1 + int_Input_2;
                txtOutput.Text = sum.ToString();
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput_1.Text = null;
            txtInput_2.Text = null;
            txtOutput.Text = null;
        }
    }
}
