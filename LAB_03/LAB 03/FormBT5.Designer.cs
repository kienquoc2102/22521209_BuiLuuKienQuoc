namespace LAB_03
{
    partial class FormBT5
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
            btn_OpenClient = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_OpenClient
            // 
            btn_OpenClient.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenClient.Location = new Point(12, 23);
            btn_OpenClient.Name = "btn_OpenClient";
            btn_OpenClient.Size = new Size(645, 48);
            btn_OpenClient.TabIndex = 0;
            btn_OpenClient.Text = "Open a new Client";
            btn_OpenClient.UseVisualStyleBackColor = true;
            btn_OpenClient.Click += btn_OpenClient_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(645, 48);
            button1.TabIndex = 1;
            button1.Text = "Open a new Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBT5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 150);
            Controls.Add(button1);
            Controls.Add(btn_OpenClient);
            Name = "FormBT5";
            Text = "Lab 03 - Bài 5";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_OpenClient;
        private Button button1;
    }
}