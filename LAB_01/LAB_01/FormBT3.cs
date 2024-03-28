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
    public partial class FormBT3 : Form
    {
        public FormBT3()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txt_Input.Text = null;
            txt_Output.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string str_Input = txt_Input.Text;
            string str_Output = "";
            if (int.TryParse(str_Input, out int int_Input))
            {
                switch (int_Input)
                {
                    case 0:
                        str_Output = "Không";
                        break;
                    case 1:
                        str_Output = "Một";
                        break;
                    case 2:
                        str_Output = "Hai";
                        break;
                    case 3:
                        str_Output = "Ba";
                        break;
                    case 4:
                        str_Output = "Bốn";
                        break;
                    case 5:
                        str_Output = "Năm";
                        break;
                    case 6:
                        str_Output = "Sáu";
                        break;
                    case 7:
                        str_Output = "Bảy";
                        break;
                    case 8:
                        str_Output = "Tám";
                        break;
                    case 9:
                        str_Output = "Chín";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9");
            }    
            txt_Output.Text = str_Output;
        }
    }
}
