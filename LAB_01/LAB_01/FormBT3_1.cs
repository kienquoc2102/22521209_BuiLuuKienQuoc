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
    public partial class FormBT3_1 : Form
    {
        public FormBT3_1()
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

        private string Read(long num_read)
        {
            long a, b, c;
            string str_a = "", str_b = "", str_c = "", str_num = "";

            //Hang tram
            c = (num_read / 100);
            //Hang chuc
            b = (num_read % 100) / 10;
            //Hang don vi
            a = num_read % 10;

            switch (c) 
            {
                case 0: str_c = "";
                    break;
                case 1: str_c = "một trăm";
                    break;
                case 2:
                    str_c = "hai trăm";
                    break;
                case 3:
                    str_c = "ba trăm";
                    break;
                case 4:
                    str_c = "bốn trăm";
                    break;
                case 5:
                    str_c = "năm trăm";
                    break;
                case 6:
                    str_c = "sáu trăm";
                    break;
                case 7:
                    str_c = "bảy trăm";
                    break;
                case 8:
                    str_c = "tám trăm";
                    break;
                case 9:
                    str_c = "chín trăm";
                    break;
            }

            switch (b)
            {
                case 0:
                    if (c == 0 || a ==0)
                    {
                        str_b = "";
                    }   
                    else
                    {
                        str_b = "lẻ";
                    }
                    break;
                case 1:
                    str_b = "mười";
                    break;
                case 2:
                    str_b = "hai mươi";
                    break;
                case 3:
                    str_b = "ba mươi";
                    break;
                case 4:
                    str_b = "bốn mươi";
                    break;
                case 5:
                    str_b = "năm mươi";
                    break;
                case 6:
                    str_b = "sáu mươi";
                    break;
                case 7:
                    str_b = "bảy mươi";
                    break;
                case 8:
                    str_b = "tám mươi";
                    break;
                case 9:
                    str_b = "chín mươi";
                    break;
            }

            switch (a)
            {
                case 0:
                    str_a = "";
                    break;
                case 1:
                    str_a = "một";
                    break;
                case 2:
                    str_a = "hai";
                    break;
                case 3:
                    str_a = "ba";
                    break;
                case 4:
                    str_a = "bốn";
                    break;
                case 5:
                    str_a = "năm";
                    break;
                case 6:
                    str_a = "sáu";
                    break;
                case 7:
                    str_a = "bảy";
                    break;
                case 8:
                    str_a = "tám";
                    break;
                case 9:
                    str_a = "chín";
                    break;
            }

            return str_num = str_c + " " + str_b + " " + str_a;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string str_Output = "";
            string str_Input = txt_Input.Text;
            if (long.TryParse(str_Input, out long int_Input))
            {
                long a, b, c, d;
                d = int_Input % 1000;
                c = (int_Input / 1000) % 1000;
                b = (int_Input / 1000000) % 1000;
                a = int_Input / 1000000000;

                if (a != 0)
                {
                    str_Output += Read(a) + " tỷ ";
                }
                else
                {
                    str_Output += "";
                }

                if (b != 0)
                {
                    str_Output += Read(b) + " triệu ";
                }
                else
                {
                    str_Output += "";
                }

                if (c != 0)
                {
                    str_Output += Read(c) + " nghìn ";
                }
                else
                {
                    str_Output += "";
                }

                if (d != 0)
                {
                    str_Output += Read(d);
                }
                else
                {
                    str_Output += "";
                }
            }
            else
                MessageBox.Show("Vui lòng nhập số nguyên!");

            txt_Output.Text = str_Output;
        }
    }
}
