namespace LAB_04
{
    partial class FormBT5_BT6
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
            txt_URL = new TextBox();
            txt_Name = new TextBox();
            txt_Pass = new TextBox();
            btn_Login = new Button();
            richTextBox_Info = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_URL
            // 
            txt_URL.Location = new Point(93, 34);
            txt_URL.Name = "txt_URL";
            txt_URL.Size = new Size(695, 27);
            txt_URL.TabIndex = 3;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(93, 74);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(499, 27);
            txt_Name.TabIndex = 4;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(93, 116);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(499, 27);
            txt_Pass.TabIndex = 5;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.White;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(598, 74);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(190, 69);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // richTextBox_Info
            // 
            richTextBox_Info.Location = new Point(12, 162);
            richTextBox_Info.Name = "richTextBox_Info";
            richTextBox_Info.Size = new Size(776, 187);
            richTextBox_Info.TabIndex = 7;
            richTextBox_Info.Text = "";
            // 
            // FormBT5_BT6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(richTextBox_Info);
            Controls.Add(btn_Login);
            Controls.Add(txt_Pass);
            Controls.Add(txt_Name);
            Controls.Add(txt_URL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT5_BT6";
            Text = "Bài 5 & 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_URL;
        private TextBox txt_Name;
        private TextBox txt_Pass;
        private Button btn_Login;
        private RichTextBox richTextBox_Info;
    }
}