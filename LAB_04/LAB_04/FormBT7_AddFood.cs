using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_04
{
    public partial class FormBT7_AddFood : Form
    {
        public FormBT7_AddFood()
        {
            InitializeComponent();
        }

        //Khai báo
        public FormBT7_Menu f = new FormBT7_Menu();
        private string url = "https://nt106.uitiot.vn/api/v1/monan/add";
        private string Name;
        private string Price;
        private string Address;
        private string Image;
        private string Description;

        //Hàm thêm món ăn
        private async void AddFood()
        {
            Name = txt_food.Text;
            Price = txt_price.Text;
            Address = txt_addr.Text;
            Image = txt_img.Text;
            Description = txt_desc.Text;

            var newFood = new
            {
                ten_mon_an = Name,
                gia = Price,
                mo_ta = Description,
                hinh_anh = Image,
                dia_chi = Address
            };

            string json = JsonConvert.SerializeObject(newFood);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var accessToken = f.GetInfoUser()[2];
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Add Food successful!");
                }
                else
                {
                    MessageBox.Show("Add Food failed: " + response.ReasonPhrase);
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            AddFood();
            f.LoadForm(1, 5);
        }
    }
}
