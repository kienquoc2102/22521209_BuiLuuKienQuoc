namespace LAB_05
{
    partial class FormBT2_BT3
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
            txt_email = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            label3 = new Label();
            cb_protocols = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            lb_recent = new Label();
            lb_total = new Label();
            listView_Info = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(88, 17);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(499, 27);
            txt_email.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(88, 53);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(499, 27);
            txt_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(593, 17);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(158, 63);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 5;
            label3.Text = "Giao thức nhận mail";
            // 
            // cb_protocols
            // 
            cb_protocols.FormattingEnabled = true;
            cb_protocols.Location = new Point(160, 91);
            cb_protocols.Name = "cb_protocols";
            cb_protocols.Size = new Size(427, 28);
            cb_protocols.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Total:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lb_recent);
            panel1.Controls.Add(lb_total);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 41);
            panel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 9);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 10;
            label7.Text = "Recent:";
            // 
            // lb_recent
            // 
            lb_recent.AutoSize = true;
            lb_recent.Location = new Point(497, 9);
            lb_recent.Name = "lb_recent";
            lb_recent.Size = new Size(50, 20);
            lb_recent.TabIndex = 9;
            lb_recent.Text = "label6";
            lb_recent.Visible = false;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(54, 9);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(50, 20);
            lb_total.TabIndex = 8;
            lb_total.Text = "label5";
            lb_total.Visible = false;
            // 
            // listView_Info
            // 
            listView_Info.Location = new Point(12, 200);
            listView_Info.Name = "listView_Info";
            listView_Info.Size = new Size(739, 463);
            listView_Info.TabIndex = 9;
            listView_Info.UseCompatibleStateImageBehavior = false;
            // 
            // FormBT2_BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 675);
            Controls.Add(listView_Info);
            Controls.Add(panel1);
            Controls.Add(cb_protocols);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT2_BT3";
            Text = "FormBT2_BT3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Button btn_login;
        private Label label3;
        private ComboBox cb_protocols;
        private Label label4;
        private Panel panel1;
        private Label lb_recent;
        private Label lb_total;
        private Label label7;
        private ListView listView_Info;
    }
}