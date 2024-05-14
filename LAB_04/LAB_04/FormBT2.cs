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
    public partial class FormBT2 : Form
    {
        public FormBT2()
        {
            InitializeComponent();
        }

        //Khai báo
        private WebClient myClient = new WebClient();
        Stream response;

        //Hàm hiển thị
        private void Display(string html)
        {
            richTextBox_Display.Text = html;
        }

        //Hàm DownLoad
        private void DownLoad(string url, string filepath)
        {
            string html = GetHTML(url);
            Display(html);

            WebClient myclient = new WebClient();
            Stream response = myclient.OpenRead(url);
            myclient.DownloadFile(url, filepath);

        }

        private string GetHTML(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(dataStream);
            string html = sr.ReadToEnd();
            response.Close();
            return html;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            DownLoad(txt_URL.Text, txt_filePath.Text);
        }
    }
}
