using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_04
{
    public partial class FormBT7_Login : Form
    {
        public FormBT7_Login()
        {
            InitializeComponent();
        }
        //Khai báo
        private string url;
        private string username;
        private string password;
        private string accessToken;

        //Hàm Login
        private async void Login()
        {
            url = "https://nt106.uitiot.vn/auth/token";
            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                using (var client = new HttpClient())
                {
                    var content = new MultipartFormDataContent
                    {
                        { new StringContent(username), "username" },
                        { new StringContent(password), "password" }
                    };

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        var responseObject = JObject.Parse(responseString);

                        accessToken = responseObject["access_token"].ToString();
                        string userInfo = $"{username} - {password} - {accessToken}";
                        WriteInfo(userInfo);
                        OpenForm(new FormBT7_Menu());
                        this.Close();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.ReasonPhrase}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Ghi thông tin User vào 1 file
        private void WriteInfo(string info)
        {
            try
            {
                using(StreamWriter wr = new StreamWriter("UserInfo.txt"))
                {
                    wr.Write(info);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Thao tác
        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void link_open_fSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm(new FormBT7_SignUp());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
