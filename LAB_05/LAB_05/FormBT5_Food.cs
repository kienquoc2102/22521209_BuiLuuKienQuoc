using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_05
{
    public partial class FormBT5_Food : Form
    {
        public FormBT5_Food(int id, string name, decimal price, string addr, string contri, string img)
        {
            InitializeComponent();
            LoadInfo(name, price.ToString(), addr, contri);
            LoadImg(img);
        }

        private void LoadInfo(string name, string price, string addr, string contributor)
        {
            this.Text = $"Ăn {name} điiiiiiii!";
            label_food.Text = name;
            label_price.Text = price;
            label_addr.Text = addr;
            label_contrib.Text = contributor;
        }

        private void LoadImg(string img)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imgBytes = webClient.DownloadData(img);

                    using (var ms = new System.IO.MemoryStream(imgBytes))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox_food.Image = image;
                        pictureBox_food.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
