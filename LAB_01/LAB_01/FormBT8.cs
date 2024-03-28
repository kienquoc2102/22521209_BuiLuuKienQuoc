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
    public partial class FormBT8 : Form
    {
        public FormBT8()
        {
            InitializeComponent();
            LoadList();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> list_food = new List<string>();
        private void createList()
        {
            list_food = new List<string>()
            {
                "Bún riêu",
                "Bún thịt nướng",
                "Cơm tấm sườn bì chả",
                "Phở",
                "Gỏi cuốn",
            };
        }
        //Hiển thị danh sách mặc định
        private void LoadList()
        {
            string output = "";
            createList();
            for (int i = 0; i < list_food.Count; i++)
            {
                output += list_food[i] + Environment.NewLine;
            }
            txt_Display.Text = output;
        }

        //Thêm món ăn
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string add_food = txt_Input.Text;
            list_food.Add(add_food);
            txt_Display.Text += add_food + Environment.NewLine;
            txt_Input.Text = null;
        }

        //Xóa thành phần đã thêm
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string output = "";
            list_food.RemoveAt(list_food.Count - 1);
            txt_Display.Text = null;
            for (int i = 0; i < list_food.Count; i++)
            {
                output += list_food[i] + Environment.NewLine;
            }
            txt_Display.Text = output;

        }

        //Hàm random
        private void btn_Rand_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index_rand = rand.Next(0, list_food.Count);
            txt_Output.Text = list_food[index_rand];
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            txt_Output.Text = null;
        }
    }
}
