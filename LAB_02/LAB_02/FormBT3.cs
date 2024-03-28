using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02
{
    public partial class FormBT3 : Form
    {
        public FormBT3()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] ArrCalc;

        private void buttonRead_Click(object sender, EventArgs e)
        {
            //Đọc File
            FileStream fs = new FileStream("Input3.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            //display Input
            txt_displayInput.Text = sr.ReadToEnd();
            sr.Close();

            //Xử lý tách mảng
            sr = new StreamReader("Input3.txt");
            ArrCalc = sr.ReadToEnd().Split(new char[] { '\n', });
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            //Tính kết quả
            List<string> arrResult = new List<string>();
            for (int i = 0; i < ArrCalc.Length; i++)
            {
               arrResult.Add(CalcInput(ArrCalc[i]).ToString());
            }

            //Ghi File
            FileStream fs = new FileStream("Output3.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            string temp = "";
            for (int i = 0; i < arrResult.Count; i++)
            {
                temp += ArrCalc[i] + " = " + arrResult[i].ToString() + Environment.NewLine;
            }

            sw.Write(temp);
            sw.Close();
            fs.Close();

            //Display output
            txt_displayOutput.Text = temp;
        }

        //Hàm tính
        private double CalcInput(string input)
        {
            while (input.Contains("("))
            {
                int openingIndex = input.LastIndexOf('(');
                int closingIndex = input.IndexOf(')', openingIndex);

                if (closingIndex == -1)
                {
                    MessageBox.Show("Lỗi: Dấu ngoặc không phù hợp!");
                    return double.NaN;
                }

                string subExpression = input.Substring(openingIndex + 1, closingIndex - openingIndex - 1);
                double subResult = CalcInput(subExpression);
                if (double.IsNaN(subResult))
                    return double.NaN;

                input = input.Remove(openingIndex, closingIndex - openingIndex + 1).Insert(openingIndex, subResult.ToString());
            }

            string[] tokens = Regex.Split(input, @"(\+|\-|\*|\/)");
            double result = double.Parse(tokens[0]);
            for (int i = 1; i < tokens.Length - 1; i += 2)
            {
                string op = tokens[i]; // Lấy toán tử
                double operand = double.Parse(tokens[i + 1]);
                switch (op)
                {
                    case "+":
                        result += operand; break;
                    case "-":
                        result -= operand; break;
                    case "*":
                        result *= operand; break;
                    case "/":
                        if (operand != 0)
                            result /= operand;
                        else
                        {
                            MessageBox.Show("Lỗi: Phép chia cho 0!");
                            return double.NaN;
                        }
                        break;
                }
            }
            return result;
        }
    }
}
