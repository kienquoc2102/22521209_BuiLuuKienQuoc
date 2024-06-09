using MailKit;
using MailKit.Net.Imap;
using MimeKit.Utils;
using MimeKit;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LAB_05
{
    public partial class FormBT2_BT3 : Form
    {
        public FormBT2_BT3()
        {
            InitializeComponent();
            InitialListView();
            InitialComboBox();
        }

        private void InitialListView()
        {
            listView_Info.View = View.Details;
            listView_Info.FullRowSelect = true;
            listView_Info.GridLines = true;

            listView_Info.Columns.Add("#", 60, HorizontalAlignment.Left);
            listView_Info.Columns.Add("Subject", 200, HorizontalAlignment.Left);
            listView_Info.Columns.Add("From", 300, HorizontalAlignment.Left);
            listView_Info.Columns.Add("Date", 300, HorizontalAlignment.Left);
        }

        private void InitialComboBox()
        {
            string[] protocols = { "IMAP", "POP" };
            cb_protocols.Items.Clear();
            cb_protocols.DataSource = protocols;
        }

        private void DisplayInfo(MimeMessage message, int index, string subject, string from, string date)
        {
            var item = new ListViewItem();
            item.Tag = message;
            item.Text = index.ToString();
            item.SubItems.Add(subject);
            item.SubItems.Add(from);
            item.SubItems.Add(date);

            listView_Info.Items.Add(item);
        }

        private void UseIMAP()
        {
            listView_Info.Items.Clear();
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(txt_email.Text, txt_pass.Text);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            for (int i = inbox.Count - 1; i >= 0; i--)
            {
                var message = inbox.GetMessage(i);
                int index = inbox.Count - 1 - i;
                string subject = message.Subject;
                string from = message.From.ToString();
                string date = message.Date.ToString();
                DisplayInfo(message, index, subject, from, date);
            }
            lb_total.Visible = true;
            lb_recent.Visible = true;
            lb_total.Text = inbox.Count.ToString();
            lb_recent.Text = inbox.Recent.ToString();
        }

        private void UsePOP()
        {
            listView_Info.Items.Clear();
            using (var client = new MailKit.Net.Pop3.Pop3Client())
            {
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(txt_email.Text, txt_pass.Text);
                for (int i = client.Count - 1; i >= 0; i--)
                {
                    var message = client.GetMessage(i);
                    int index = client.Count - 1 - i;
                    string subject = message.Subject;
                    string from = message.From.ToString();
                    string date = message.Date.ToString();
                    DisplayInfo(message, index, subject, from, date);
                }
                lb_total.Visible = true;
                lb_recent.Visible = true;
                lb_total.Text = client.Count.ToString();
                lb_recent.Text = client.Count.ToString();
            }
        }

        private void Login()
        {
            if (cb_protocols.SelectedItem.ToString() == "IMAP")
            {
                UseIMAP();
            }
            else if (cb_protocols.SelectedItem.ToString() == "POP")
            {
                UsePOP();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
