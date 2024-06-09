namespace LAB_05
{
    partial class FormBT6
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
            panel1 = new Panel();
            btn_Logout = new Button();
            btn_Refresh = new Button();
            btn_SendMail = new Button();
            btn_Login = new Button();
            txt_password = new TextBox();
            label3 = new Label();
            txt_account = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txt_portSMTP = new TextBox();
            txt_portIMAP = new TextBox();
            label8 = new Label();
            txt_smtp = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txt_imap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            listView_Info = new ListView();
            progressBar = new ProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_Logout);
            panel1.Controls.Add(btn_Refresh);
            panel1.Controls.Add(btn_SendMail);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_account);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 136);
            panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.LightGray;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Location = new Point(224, 85);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(127, 33);
            btn_Logout.TabIndex = 7;
            btn_Logout.Text = "Đăng xuất";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Visible = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = Color.LightGray;
            btn_Refresh.FlatStyle = FlatStyle.Flat;
            btn_Refresh.Location = new Point(100, 85);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(91, 33);
            btn_Refresh.TabIndex = 6;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Visible = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // btn_SendMail
            // 
            btn_SendMail.BackColor = Color.LightGray;
            btn_SendMail.FlatStyle = FlatStyle.Flat;
            btn_SendMail.Location = new Point(3, 85);
            btn_SendMail.Name = "btn_SendMail";
            btn_SendMail.Size = new Size(91, 33);
            btn_SendMail.TabIndex = 5;
            btn_SendMail.Text = "Gửi mail";
            btn_SendMail.UseVisualStyleBackColor = false;
            btn_SendMail.Visible = false;
            btn_SendMail.Click += btn_SendMail_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.LightGray;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Location = new Point(224, 85);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(127, 33);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.White;
            txt_password.ForeColor = Color.Black;
            txt_password.Location = new Point(80, 52);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(271, 27);
            txt_password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 59);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txt_account
            // 
            txt_account.BackColor = Color.White;
            txt_account.ForeColor = Color.Black;
            txt_account.Location = new Point(80, 15);
            txt_account.Name = "txt_account";
            txt_account.Size = new Size(271, 27);
            txt_account.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_portSMTP);
            panel2.Controls.Add(txt_portIMAP);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_smtp);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_imap);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(396, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 136);
            panel2.TabIndex = 2;
            // 
            // txt_portSMTP
            // 
            txt_portSMTP.BackColor = Color.White;
            txt_portSMTP.ForeColor = Color.Black;
            txt_portSMTP.Location = new Point(421, 48);
            txt_portSMTP.Name = "txt_portSMTP";
            txt_portSMTP.Size = new Size(277, 27);
            txt_portSMTP.TabIndex = 13;
            // 
            // txt_portIMAP
            // 
            txt_portIMAP.BackColor = Color.White;
            txt_portIMAP.ForeColor = Color.Black;
            txt_portIMAP.Location = new Point(53, 48);
            txt_portIMAP.Name = "txt_portIMAP";
            txt_portIMAP.Size = new Size(277, 27);
            txt_portIMAP.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 55);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 11;
            label8.Text = "Port";
            // 
            // txt_smtp
            // 
            txt_smtp.BackColor = Color.White;
            txt_smtp.ForeColor = Color.Black;
            txt_smtp.Location = new Point(421, 15);
            txt_smtp.Name = "txt_smtp";
            txt_smtp.Size = new Size(277, 27);
            txt_smtp.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 22);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 9;
            label7.Text = "SMTP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 55);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 6;
            label6.Text = "Port";
            // 
            // txt_imap
            // 
            txt_imap.BackColor = Color.White;
            txt_imap.ForeColor = Color.Black;
            txt_imap.Location = new Point(53, 15);
            txt_imap.Name = "txt_imap";
            txt_imap.Size = new Size(277, 27);
            txt_imap.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 22);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 1;
            label5.Text = "IMAP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 17);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Cài đặt";
            // 
            // listView_Info
            // 
            listView_Info.Location = new Point(12, 192);
            listView_Info.Name = "listView_Info";
            listView_Info.Size = new Size(1094, 533);
            listView_Info.TabIndex = 4;
            listView_Info.UseCompatibleStateImageBehavior = false;
            listView_Info.Click += listView_Info_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 731);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(125, 22);
            progressBar.TabIndex = 5;
            // 
            // FormBT6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 773);
            Controls.Add(progressBar);
            Controls.Add(listView_Info);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormBT6";
            Text = "FormBT6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btn_Login;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_account;
        private Panel panel2;
        private Label label4;
        private Label label8;
        private TextBox txt_smtp;
        private Label label7;
        private Label label6;
        private TextBox txt_imap;
        private Label label5;
        private ListView listView_Info;
        private Button btn_Refresh;
        private Button btn_SendMail;
        private Button btn_Logout;
        private TextBox txt_portSMTP;
        private TextBox txt_portIMAP;
        private ProgressBar progressBar;
    }
}