namespace LAB_04
{
    partial class FormBT7_Login
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            label4 = new Label();
            link_open_fSignup = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(93, 81);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(431, 27);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(93, 117);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(431, 27);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.White;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(530, 81);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(163, 63);
            btn_login.TabIndex = 5;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 161);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 6;
            label4.Text = "Don't have account yet?";
            // 
            // link_open_fSignup
            // 
            link_open_fSignup.AutoSize = true;
            link_open_fSignup.Location = new Point(266, 161);
            link_open_fSignup.Name = "link_open_fSignup";
            link_open_fSignup.Size = new Size(59, 20);
            link_open_fSignup.TabIndex = 7;
            link_open_fSignup.TabStop = true;
            link_open_fSignup.Text = "Sign up";
            link_open_fSignup.LinkClicked += link_open_fSignup_LinkClicked;
            // 
            // FormBT7_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 236);
            Controls.Add(link_open_fSignup);
            Controls.Add(label4);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT7_Login";
            Text = "Hôm nay ăn gì? Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Label label4;
        private LinkLabel link_open_fSignup;
    }
}