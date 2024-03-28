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
    public partial class FormBT7 : Form
    {
        public FormBT7()
        {
            InitializeComponent();
        }

        //Thông tin sinh viên
        string name_SV = "";
        List<string> score_SV = new List<string>();

        //Xử lý mảng nhận từ Input
        private void HandleArray()
        {
            string str_Input = txt_Input.Text;
            string[] arr_info = str_Input.Split(",");
            name_SV = arr_info[0];
            for (int i = 1; i < arr_info.Length; i++)
                score_SV.Add(arr_info[i]);
        }

        //Hàm xuất tên
        public string OutputName ()
        {
            HandleArray();
            return name_SV;
        }
        //Hàm xuất điểm
        public string OutputScore ()
        {
            string state = "";
            string txt_score = "";
            for (int i = 0; i < score_SV.Count; i++)
            {
                if (int.Parse(score_SV[i]) >= 5)
                    state = "Đậu";
                else
                    state = "Rớt";
                txt_score += "Môn " + (i + 1).ToString() + ": " + score_SV[i] + " - " + state + Environment.NewLine;
            }
            return txt_score;
        }

        //Hàm tính điểm trung bình
        public string OutputAvg ()
        {
            double avg = 0, sum = 0;
            for (int i = 0; i< score_SV.Count;i++)
            {
                sum += double.Parse(score_SV[i]);
            }
            avg = sum / score_SV.Count;
            return avg.ToString(); 
        }

        //Hàm tìm môn cao nhất
        public string OutputMax()
        {
            int i_max = 0;
            double max_score = double.Parse(score_SV[0]);
            for (int i = 0; i< score_SV.Count;i++)
            {
                if (double.Parse(score_SV[i]) >= max_score)
                {
                    max_score = double.Parse(score_SV[i]);
                    i_max = i;
                }
            }
            return "Môn " + (i_max+1).ToString();
        }

        //Hàm tìm môn thấp nhất
        public string OutputMin()
        {
            int i_min = 0;
            double min_score = double.Parse(score_SV[0]);
            for (int i = 0; i < score_SV.Count;i++)
            {
                if (double.Parse(score_SV[i]) <= min_score)
                {
                    min_score = double.Parse(score_SV[i]);
                    i_min = i;
                }
            }
            return "Môn " + (i_min+1).ToString();
        }

        //Hàm xếp loại
        public bool CheckScore(double x)
        {
            double min_score = double.Parse(score_SV[0]);
            for (int i = 0; i < score_SV.Count; i++)
            {
                if (double.Parse(score_SV[i]) <= min_score)
                {
                    min_score = double.Parse(score_SV[i]);
                }
            }
            if (min_score >= x)
                return true;
            else return false;
        }
        public string OutputType ()
        {
            string type = "";
            double ave_score = double.Parse(OutputAvg());
            if (ave_score >= 8 && CheckScore(6.5))
                type += "Giỏi";
            else if(ave_score >= 6.5 && CheckScore(5))
                type += "Khá";
            else if (ave_score >= 5 && CheckScore(3.5))
                type += "TB";
            else if (ave_score >= 3.5 && CheckScore(2))
                type += "Yếu";
            else
                type += "Kém";
            return type;
        }

        //Hàm mở form xem điểm
        public void XuatDiem(Form sub_form)
        {
            sub_form.Show();
        }

        //Reset mảng
        public void Reset()
        {
            name_SV = null;
            score_SV.Clear();
        }

        //Bấm Enter để xuất điểm
        private void btn_Enter_Click(object sender, EventArgs e)
        {
           
             XuatDiem(new FormSubBT7(this));
        }
    }
}
