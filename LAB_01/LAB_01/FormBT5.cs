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
    public partial class FormBT5 : Form
    {
        public FormBT5()
        {
            InitializeComponent();
            LoadCalc();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txt_InputA.Text = null;
            txt_InputB.Text = null;
            txt_Output.Text = null;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string str_InputA = txt_InputA.Text;
            string str_InputB = txt_InputB.Text;
            //double A = double.Parse(str_InputA);
            //double B = double.Parse(str_InputB);

            if (double.TryParse(str_InputA, out double A) && double.TryParse(str_InputB, out double B))
            {
                if ((int)cb_calc.SelectedValue == 1)
                {
                    txt_Output.Text = null;
                    //(A-B)!
                    txt_Output.Text += "(A - B)! = " + Calc_2(A, B).ToString() + Environment.NewLine;

                    //S
                    txt_Output.Text += "S = A^1 + A^2 + ... + A^B = " + Calc_3(A, B).ToString() + Environment.NewLine;
                }
                else
                {
                    txt_Output.Text = null;
                    //Bảng cửu chương 
                    double X = B - A;
                    txt_Output.Text += "B - A = " + (B - A).ToString() + Environment.NewLine;
                    txt_Output.Text += "Bảng cửu chương B - A" + Environment.NewLine;
                    Calc_1(X);
                }
            }
            else
                MessageBox.Show("Vui lòng nhập số!");
        }

        //Hiển thị comboBox
        Dictionary<int, string> calc = new Dictionary<int, string>();
        private void LoadCalc()
        {
            calc = new Dictionary<int, string>()
            {
                {0, "Bảng cửu chương" },
                {1, "Tính giá trị" }
            };

            cb_calc.DataSource = new BindingSource(calc, null) ;
            cb_calc.DisplayMember = "Value";
            cb_calc.ValueMember = "Key";
        }

        //Hàm tính giá trị
        //Bảng cửu chương
        private void Calc_1(double x)
        {
            string str_x = x.ToString();
            for (int i = 0; i <= 10; i++)
            {
                txt_Output.Text += str_x + " x " + i.ToString() + " = " + (x*i).ToString() + Environment.NewLine;
            }
        }

        //Tính (A-B)!
        private double Calc_2(double a, double b)
        {
            double result = 0;
            double c = a - b;
            if (c == 0)
                return 1;
            if (c > 0)
            {
                for (int i= 1; i <= c; i++)
                {
                    result += i;
                }
                return result;
            }
            else
            {
                double temp = c * -1;
                for(int i= 1;i <= temp; i++)
                {
                    result += i;
                }
                return -result;
            }
        }

        //Tính S
        private double Calc_3(double a, double b)
        {
            double result = 0;
            for (int i= 1;i<=b; i++)
            {
                result += Math.Pow(a, i);
            }    
            return result;
        }
    }
}
