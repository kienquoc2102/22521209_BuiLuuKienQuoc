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
    public partial class FormBT1 : Form
    {
        public FormBT1()
        {
            InitializeComponent();
        }

        //Hàm lấy chuỗi HTML
        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string html = reader.ReadToEnd();
            response.Close();
            return html;
        }

        //Hàm hiển thị
        private void Display(string html)
        {
            richTextBox_Display.Text = html;
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            Display(getHTML(txt_URL.Text));
        }
    }
}
