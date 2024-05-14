using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_04
{
    public partial class FormBT7_DisplayFood : Form
    {
        public FormBT7_DisplayFood(string name, long price, string addr, string contri, string img)
        {
            InitializeComponent();
            LoadName(name, price.ToString(), addr, contri);
            LoadImage(img);
        }
        
        //Hiển thị thông tin món ăn
        private void LoadName(string name, string price, string addr, string contributor)
        {
            this.Text = $"Ăn {name} điiiiii!";
            lb_food.Text = name;
            lb_price.Text = price;
            lb_addr.Text = addr;
            lb_contributor.Text = contributor;
        }


        //Hiển thị hình ảnh món khi biết link ảnh
        private void LoadImage(string imgURL)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imgBytes = webClient.DownloadData(imgURL);

                    using (var ms = new System.IO.MemoryStream(imgBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pictureBox_food.Image = img;
                        pictureBox_food.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
