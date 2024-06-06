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

namespace LAB_05
{
    public partial class FormBT4_Display : UserControl
    {
        public FormBT4_Display(string name, string url, string img)
        {
            InitializeComponent();
            LoadLabel(name, url);
            LoadImg(img);
            GetInfo(url, img, name);
        }
        private string url_film;
        private string img_film;
        private string name_film;

        private void LoadLabel(string name, string url)
        {
            label_name.Text = name;
            label_link.Text = url;
        }

        private void LoadImg(string img_url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imgBytes = webClient.DownloadData($"{img_url}");

                    using (var ms = new System.IO.MemoryStream(imgBytes))
                    {
                        Image img = Image.FromStream(ms);
                        pictureBox_film.Image = img;
                        pictureBox_film.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong truy cap dc");
            }
        }

        private void GetInfo(string url, string img, string name)
        {
            url_film = url;
            img_film = img;
            name_film = name;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            FormBT4_DetailFilm f = new FormBT4_DetailFilm(url_film);
            f.Show();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            FormBT4_Buy f = new FormBT4_Buy(name_film, img_film);
            f.Show();
        }
    }
}
