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
    public partial class FormBT2 : Form
    {
        public FormBT2()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput_1.Text = null;
            txtInput_2.Text = null;
            txtInput_3.Text = null;
            txtOutput_Max.Text = null;
            txtOutput_Min.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string str_Input1 = txtInput_1.Text;
            string str_Input2 = txtInput_2.Text;
            string str_Input3 = txtInput_3.Text;
            if (float.TryParse(str_Input1, out float int_Input1) && float.TryParse(str_Input2, out float int_Input2) && float.TryParse(str_Input3, out float int_Input3))
            {
                float[] listInput = { int_Input1, int_Input2, int_Input3 };
                float max = listInput[0];
                float min = listInput[0];
                for (int i = 0; i < listInput.Length; i++)
                {
                    if (max <= listInput[i])
                        max = listInput[i];
                }
                txtOutput_Max.Text = max.ToString();

                for (int i = 0; i < listInput.Length; i++)
                {
                    if (min >= listInput[i])
                        min = listInput[i];
                }
                txtOutput_Min.Text = min.ToString();
            }
            else
                MessageBox.Show("Vui lòng nhập số!");
        }
    }
}
