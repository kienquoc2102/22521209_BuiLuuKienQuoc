using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_05
{
    public partial class FormBT6_DetailMail : Form
    {
        public FormBT6_DetailMail()
        {
            InitializeComponent();
        }

        private void FormBT6_DetailMail_Load(object sender, EventArgs e)
        {
            MimeMessage message = Tag as MimeMessage;
            lb_from.Text = message.From.ToString();
            lb_to.Text = message.To.ToString();
            lb_subject.Text = message.Subject;

            WebBrowser wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            panel_content.Controls.Add(wb);
            wb.DocumentText = message.HtmlBody;

            foreach (var attach in message.Attachments)
            {
                if (attach is MimePart)
                {
                    var mimePart = (MimePart)attach;
                    lb_filename.Text = mimePart.FileName;
                    btn_download.Tag = mimePart;
                }
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btnAttachment = (Button)sender;
                var mimePart = (MimePart)btnAttachment.Tag;

                string fileName = mimePart.FileName;

                var stream = mimePart.Content.Open();

                string pathToSave = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

                using (FileStream fileStream = File.Create(pathToSave))
                {
                    stream.CopyTo(fileStream);
                }

                MessageBox.Show("Tải xuống thành công: " + pathToSave);
            }
        }
    }
}
