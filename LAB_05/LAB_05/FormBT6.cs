using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;

namespace LAB_05
{
    public partial class FormBT6 : Form
    {
        public FormBT6()
        {
            InitializeComponent();
            InitialListView();
            InitializeProgressBar();
        }

        //Khai báo
        private ImapClient client;
        public string account;
        public string password;
        public string imap;
        public string smtp;
        public int port_imap;
        public int port_smtp;


        //Hàm hiển thị lên ListView
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

        private void InitializeProgressBar()
        {
            progressBar.Visible = false;
            progressBar.Minimum = 0;
            progressBar.Step = 1;
        }

        //Hàm lấy mail
        private async Task GetMailsAsync()
        {
            listView_Info.Items.Clear();
            progressBar.Controls.Clear();

            account = txt_account.Text;
            password = txt_password.Text;
            imap = txt_imap.Text;
            port_imap = int.Parse(txt_portIMAP.Text);

            progressBar.Value = 0;
            progressBar.Visible = true;

            client = new ImapClient();
            await client.ConnectAsync(imap, port_imap, true);
            await client.AuthenticateAsync(account, password);
            var inbox = client.Inbox;
            await inbox.OpenAsync(FolderAccess.ReadOnly);

            progressBar.Maximum = inbox.Count;

            for (int i = inbox.Count - 1; i >= 0; i--)
            {
                var message = await inbox.GetMessageAsync(i);
                int index = inbox.Count - 1 - i;
                string subject = message.Subject;
                string from = GetNameFromInput(message.From.ToString());
                string date = message.Date.ToString();
                DisplayInfo(message, index, subject, from, date);
                progressBar.PerformStep();
            }

            progressBar.Visible = false;
            await client.DisconnectAsync(true);
        }

        //Hàm Đăng Nhập
        private async void Login()
        {
            try
            {
                await GetMailsAsync();

                btn_Login.Visible = false;
                btn_Logout.Visible = true;
                btn_Refresh.Visible = true;
                btn_SendMail.Visible = true;
                txt_account.Enabled = false;
                txt_password.Enabled = false;
                txt_imap.Enabled = false;
                txt_smtp.Enabled = false;
                txt_portIMAP.Enabled = false;
                txt_portSMTP.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        //Log out
        private void LogOut()
        {
            client.DisconnectAsync(true);
            btn_Login.Visible = true;
            btn_Logout.Visible = false;
            btn_Refresh.Visible = false;
            btn_SendMail.Visible = false;

            txt_account.Enabled = true;
            txt_password.Enabled = true;
            txt_imap.Enabled = true;
            txt_smtp.Enabled = true;
            txt_portIMAP.Enabled = true;
            txt_portSMTP.Enabled = true;

            txt_account.Text = null;
            txt_password.Text = null;
            txt_imap.Text = null;
            txt_portIMAP.Text = null;
            txt_smtp.Text = null;
            txt_portSMTP.Text = null;
            listView_Info.Items.Clear();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        //Refresh
        private async void Refresh()
        {
            await GetMailsAsync();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        //Hàm lấy địa chỉ mail từ message.From
        string GetNameFromInput(string input)
        {
            int firstQuoteIndex = input.IndexOf('<');
            int lastQuoteIndex = input.LastIndexOf('>');

            if (firstQuoteIndex != -1 && lastQuoteIndex != -1 && firstQuoteIndex != lastQuoteIndex)
            {
                return input.Substring(firstQuoteIndex + 1, lastQuoteIndex - firstQuoteIndex - 1);
            }

            return input;
        }

        //Gửi Mail
        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            smtp = txt_smtp.Text;
            port_smtp = int.Parse(txt_portSMTP.Text);
            FormBT6_SendMail f_send = new FormBT6_SendMail(account);
            f_send.f_home = this;
            f_send.Show();
        }

        //Xem chi tiết mail
        private void listView_Info_Click(object sender, EventArgs e)
        {
            FormBT6_DetailMail detailMail = new FormBT6_DetailMail();
            detailMail.Text = listView_Info.SelectedItems[0].SubItems[1].Text;
            detailMail.Tag = listView_Info.SelectedItems[0].Tag;
            detailMail.Show();
        }

    }
}
