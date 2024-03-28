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
    public partial class FormBT6 : Form
    {
        public FormBT6()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int selectedDay = dateTimePicker1.Value.Day;
            int selectedMonth = dateTimePicker1.Value.Month;
            string output = "";
            
            switch (selectedMonth)
            {
                case 1:
                    if (selectedDay >= 21 && selectedDay <= 31)
                        output += "Bảo Bình";
                    if (selectedDay >= 1 && selectedDay <= 20)
                        output += "Ma Kết";
                    break;
                case 2:
                    if (selectedDay >= 1 && selectedDay <= 19)
                        output += "Bảo Bình";
                    if (selectedDay >= 20 && selectedDay <= 29)
                        output += "Song Ngư";
                    break;
                case 3:
                    if (selectedDay >= 1 && selectedDay <= 20)
                        output += "Song Ngư";
                    if (selectedDay >= 21 && selectedDay <= 31)
                        output += "Bạch Dương";
                    break;
                case 4:
                    if (selectedDay >= 1 && selectedDay <= 20)
                        output += "Bạch Dương";
                    if (selectedDay >= 21 && selectedDay <= 30)
                        output += "Kim Ngưu";
                    break;
                case 5:
                    if (selectedDay >= 1 && selectedDay <= 21)
                        output += "Kim Ngưu";
                    if (selectedDay >= 22 && selectedDay <= 31)
                        output += "Song Tử";
                    break;
                case 6:
                    if (selectedDay >= 1 && selectedDay <= 21)
                        output += "Song Tử";
                    if (selectedDay >= 22 && selectedDay <= 30)
                        output += "Cự Giải";
                    break;
                case 7:
                    if (selectedDay >= 1 && selectedDay <= 22)
                        output += "Cự Giải";
                    if (selectedDay >= 23 && selectedDay <= 31)
                        output += "Sư Tử";
                    break;
                case 8:
                    if (selectedDay >= 1 && selectedDay <= 22)
                        output += "Sư Tử";
                    if (selectedDay >= 23 && selectedDay <= 31)
                        output += "Xử Nữ";
                    break;
                case 9:
                    if (selectedDay >= 1 && selectedDay <= 23)
                        output += "Xử Nữ";
                    if (selectedDay >= 24 && selectedDay <= 30)
                        output += "Thiên Bình";
                    break;
                case 10:
                    if (selectedDay >= 1 && selectedDay <= 23)
                        output += "Thiên Bình";
                    if (selectedDay >= 24 && selectedDay <= 31)
                        output += "Thần Nông";
                    break;
                case 11:
                    if (selectedDay >= 1 && selectedDay <= 22)
                        output += "Thần Nông";
                    if (selectedDay >= 23 && selectedDay <= 30)
                        output += "Nhân Mã";
                    break;
                case 12:
                    if (selectedDay >= 1 && selectedDay <= 21)
                        output += "Nhân Mã";
                    if (selectedDay >= 22 && selectedDay <= 31)
                        output += "Ma Kết";
                    break;
            }
            txt_Output.Text = output;
        }
    }
}
