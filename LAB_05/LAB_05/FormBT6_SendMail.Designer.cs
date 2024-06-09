namespace LAB_05
{
    partial class FormBT6_SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_fromMail = new TextBox();
            txt_name = new TextBox();
            txt_toMail = new TextBox();
            txt_subject = new TextBox();
            checkBox_html = new CheckBox();
            txt_urlAttach = new TextBox();
            btn_browser = new Button();
            btn_send = new Button();
            txt_body = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 2;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 4;
            label5.Text = "Body";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 576);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 5;
            label6.Text = "Attachment";
            // 
            // txt_fromMail
            // 
            txt_fromMail.BackColor = Color.White;
            txt_fromMail.Enabled = false;
            txt_fromMail.ForeColor = Color.Black;
            txt_fromMail.Location = new Point(104, 27);
            txt_fromMail.Name = "txt_fromMail";
            txt_fromMail.Size = new Size(664, 27);
            txt_fromMail.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.White;
            txt_name.Location = new Point(104, 72);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(664, 27);
            txt_name.TabIndex = 7;
            // 
            // txt_toMail
            // 
            txt_toMail.BackColor = Color.White;
            txt_toMail.Location = new Point(104, 117);
            txt_toMail.Name = "txt_toMail";
            txt_toMail.Size = new Size(664, 27);
            txt_toMail.TabIndex = 8;
            // 
            // txt_subject
            // 
            txt_subject.BackColor = Color.White;
            txt_subject.Location = new Point(104, 160);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(664, 27);
            txt_subject.TabIndex = 9;
            // 
            // checkBox_html
            // 
            checkBox_html.AutoSize = true;
            checkBox_html.Location = new Point(104, 210);
            checkBox_html.Name = "checkBox_html";
            checkBox_html.Size = new Size(70, 24);
            checkBox_html.TabIndex = 10;
            checkBox_html.Text = "HTML";
            checkBox_html.UseVisualStyleBackColor = true;
            // 
            // txt_urlAttach
            // 
            txt_urlAttach.BackColor = Color.White;
            txt_urlAttach.Enabled = false;
            txt_urlAttach.Location = new Point(104, 569);
            txt_urlAttach.Name = "txt_urlAttach";
            txt_urlAttach.Size = new Size(550, 27);
            txt_urlAttach.TabIndex = 12;
            // 
            // btn_browser
            // 
            btn_browser.Location = new Point(660, 567);
            btn_browser.Name = "btn_browser";
            btn_browser.Size = new Size(108, 29);
            btn_browser.TabIndex = 13;
            btn_browser.Text = "Browser...";
            btn_browser.UseVisualStyleBackColor = true;
            btn_browser.Click += btn_browser_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(660, 612);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(108, 38);
            btn_send.TabIndex = 14;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // txt_body
            // 
            txt_body.BorderStyle = BorderStyle.FixedSingle;
            txt_body.Location = new Point(104, 240);
            txt_body.Multiline = true;
            txt_body.Name = "txt_body";
            txt_body.Size = new Size(664, 321);
            txt_body.TabIndex = 15;
            // 
            // FormBT6_SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 662);
            Controls.Add(txt_body);
            Controls.Add(btn_send);
            Controls.Add(btn_browser);
            Controls.Add(txt_urlAttach);
            Controls.Add(checkBox_html);
            Controls.Add(txt_subject);
            Controls.Add(txt_toMail);
            Controls.Add(txt_name);
            Controls.Add(txt_fromMail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT6_SendMail";
            Text = "Send Mail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_fromMail;
        private TextBox txt_name;
        private TextBox txt_toMail;
        private TextBox txt_subject;
        private CheckBox checkBox_html;
        private TextBox txt_urlAttach;
        private Button btn_browser;
        private Button btn_send;
        private TextBox txt_body;
    }
}