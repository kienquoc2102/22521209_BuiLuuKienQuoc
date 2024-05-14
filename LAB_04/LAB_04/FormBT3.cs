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
using HtmlAgilityPack;

namespace LAB_04
{
    public partial class FormBT3 : Form
    {
        public FormBT3()
        {
            InitializeComponent();
            LoadWebBrowser();
        }

        //Khai báo
        WebBrowser webBrowser;

        //Hiển thị trang web
        private void LoadWebBrowser()
        {
            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            pn_website.Controls.Add(webBrowser);
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void LoadWebsite()
        {
            if (!string.IsNullOrEmpty(txt_url.Text))
                webBrowser.Navigate(txt_url.Text);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadWebsite();
        }

        //Down load Files
        private void DownLoadFiles(string filepath)
        {
            try
            {
                WebClient webClient = new WebClient();
                Stream reponse;
                reponse = webClient.OpenRead(txt_url.Text);
                StreamReader rd = new StreamReader(reponse);
                string html = rd.ReadToEnd();
                webClient.DownloadFile(txt_url.Text, filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Down load Resources
        private void DownLoadResources(string folderpath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(txt_url.Text);

            string source = document.DocumentNode.OuterHtml;
            string filname = Path.GetFileName(txt_url.Text);
            string filepath = Path.Combine(folderpath, filname + ".html");
            File.WriteAllText(filepath, source);

            HandleSource(document.DocumentNode, folderpath);
        }

        private void HandleSource(HtmlAgilityPack.HtmlNode node, string folderpath)
        {
            if (node.NodeType == HtmlNodeType.Element)
            {
                if (node.Name == "img" || node.Name == "link" || node.Name == "script")
                {
                    string sourceURL = node.GetAttributeValue("src", null) ?? node.GetAttributeValue("href", null);
                    if (!string.IsNullOrEmpty(sourceURL))
                    {
                        string fileName = Path.GetFileName(sourceURL);
                        string filePath = Path.Combine(folderpath, fileName);

                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(sourceURL, filePath);
                        }
                    }
                }
            }
            foreach (HtmlAgilityPack.HtmlNode childNode in node.ChildNodes)
            {
                HandleSource(childNode, folderpath);
            }
        }

        private void btn_dFiles_Click(object sender, EventArgs e)
        {
            DownLoadFiles("BT3.html");
        }

        private void btn_dResources_Click(object sender, EventArgs e)
        {
            DownLoadResources("C:\\KIENQUOC\\KienQuoc_UIT\\Lập trình mạng căn bản\\Thực hành\\TH_Lab_04\\LAB_04\\LAB_04\\bin\\Debug\\net8.0-windows");
        }
    }
}
