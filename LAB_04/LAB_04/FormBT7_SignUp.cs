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
    public partial class FormBT7_SignUp : Form
    {
        public FormBT7_SignUp()
        {
            InitializeComponent();
        }

        //Khai báo
        
        private string url = "https://nt106.uitiot.vn/api/v1/user/signup";
        private string Username;
        private string Password;
        private string Email;
        private string FirstName;
        private string LastName;
        private string Phone;
        private string Birthday;
        private int Sex;
        private string Language;
        
        //Hàm Sign up
        private async void SignUp()
        {
            Username = txt_username.Text;
            Password = txt_password.Text;
            Email = txt_email.Text;
            FirstName = txt_firstname.Text;
            LastName = txt_lastname.Text;
            Phone = txt_phone.Text;
            Birthday = dateTimePicker_birthday.Value.ToString("yyyy-MM-dd");
            Language = cb_language.Text;
            if (checkBox_male.Checked )
                Sex = 0;
            else if (checkBox_female.Checked )
                Sex = 1;

            var user = new
            {
                username = Username,
                email = Email,
                password = Password,
                first_name = FirstName,
                last_name = LastName,
                sex = Sex,
                birthday = Birthday,
                language = Language,
                phone = Phone,
            };


            string json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sign up successful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sign up failed: "+response.ReasonPhrase);
                }
            }
        }

        //Thao tác
        private void btn_submit_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = null;
            txt_password.Text = null;
            txt_firstname.Text = null;
            txt_lastname.Text = null;
            txt_email.Text = null;
            txt_phone.Text = null;
            checkBox_male.Checked = false;
            checkBox_female.Checked = false;
        }
    }
}
