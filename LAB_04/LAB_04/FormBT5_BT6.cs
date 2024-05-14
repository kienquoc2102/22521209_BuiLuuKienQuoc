using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace LAB_04
{
    public partial class FormBT5_BT6 : Form
    {
        public FormBT5_BT6()
        {
            InitializeComponent();
        }

        //Khai báo
        string url;
        string username;
        string password;

        //Hàm Login
        private async void Login()
        {
            url = txt_URL.Text;
            username = txt_Name.Text;
            password = txt_Pass.Text;
            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    {new StringContent(username), "username" },
                    {new StringContent(password), "password"}
                };

                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                var responseObject = JObject.Parse(responseString);

                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    richTextBox_Info.Text += $"Detail: {detail} \n";
                    return;
                }

                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();

                richTextBox_Info.Text += $"Token Type: {tokenType} \n";
                richTextBox_Info.Text += $"Access Token: {accessToken} \n";

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var getUserURL = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserURL);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();

                richTextBox_Info.Text += $"{getUserResponseString}";
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
