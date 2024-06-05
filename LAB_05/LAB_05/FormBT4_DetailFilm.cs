using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_05
{
    public partial class FormBT4_DetailFilm : Form
    {
        public FormBT4_DetailFilm(string url)
        {
            InitializeComponent();
            LoadWebBrowser();
            LoadWebsite(url);
        }

        WebBrowser webBrowser;

        private void LoadWebBrowser()
        {
            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            panel_Website.Controls.Add(webBrowser);
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void LoadWebsite(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                this.Text = url;
                webBrowser.Navigate(url);
            }
        }
    }
}
