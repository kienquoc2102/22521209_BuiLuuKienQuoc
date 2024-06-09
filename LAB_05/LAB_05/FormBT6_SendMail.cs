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

namespace LAB_05
{
    public partial class FormBT6_SendMail : Form
    {
        public FormBT6_SendMail(string account)
        {
            InitializeComponent();
            txt_fromMail.Text = account;
        }

        //Khai báo
        public FormBT6 f_home = new FormBT6();
        private string filepath;

        //Send
        private void SendMail(string type)
        {
            var client = new SmtpClient();
            client.Connect(f_home.smtp, f_home.port_smtp, true);
            client.Authenticate(f_home.account, f_home.password);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(txt_name.Text, f_home.account));
            message.To.Add(new MailboxAddress("", txt_toMail.Text));
            message.Subject = txt_subject.Text;
            var body = new TextPart(type)
            {
                Text = txt_body.Text,
            };

            //Đính kèm tệp
            var multipart = new Multipart("mixed");
            multipart.Add(body);

            if (!string.IsNullOrEmpty(filepath))
            {
                var attach = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(filepath), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(filepath)
                };

                multipart.Add(attach);
            }
            else
            {
                MessageBox.Show("no");
            }

            message.Body = multipart;
            client.Send(message);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem là gửi html hay text
            if (checkBox_html.Checked)
            {
                SendMail("html");
            }
            else
            {
                SendMail("plain");
            }
        }

        //Lấy đường dẫn của tệp đính kèm
        private void btn_browser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = "c:\\";
                dialog.Filter = "All file (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = dialog.FileName;
                    txt_urlAttach.Text = dialog.FileName;
                }    
            }
        }
    }
}
