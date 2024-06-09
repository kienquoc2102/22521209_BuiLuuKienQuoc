using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LAB_05
{
    public partial class FormBT1 : Form
    {
        public FormBT1()
        {
            InitializeComponent();
            LoadFromMail();
        }

        private string account;

        private void LoadFromMail()
        {
            account = "rapphimdomdom@gmail.com";
            txt_from.Text = account;
        }

        private void SendMail()
        {
            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
            client.Authenticate(account, "osmw jcan gwag wxwc"); // gmail account, app password
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", account));
            message.To.Add(new MailboxAddress("", txt_to.Text));
            message.Subject = txt_subject.Text;
            message.Body = new TextPart("plain")
            {
                Text = txt_body.Text
            };
            client.Send(message);

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendMail();
        }
    }
}
