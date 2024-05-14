namespace LAB_03
{
    partial class FormBT1
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
            btn_open_Server = new Button();
            btn_open_Client = new Button();
            SuspendLayout();
            // 
            // btn_open_Server
            // 
            btn_open_Server.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_open_Server.Location = new Point(12, 24);
            btn_open_Server.Name = "btn_open_Server";
            btn_open_Server.Size = new Size(283, 44);
            btn_open_Server.TabIndex = 0;
            btn_open_Server.Text = "UDP Server";
            btn_open_Server.UseVisualStyleBackColor = true;
            btn_open_Server.Click += btn_open_Server_Click;
            // 
            // btn_open_Client
            // 
            btn_open_Client.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_open_Client.Location = new Point(370, 24);
            btn_open_Client.Name = "btn_open_Client";
            btn_open_Client.Size = new Size(283, 44);
            btn_open_Client.TabIndex = 1;
            btn_open_Client.Text = "UDP Client";
            btn_open_Client.UseVisualStyleBackColor = true;
            btn_open_Client.Click += btn_open_Client_Click;
            // 
            // FormBT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 98);
            Controls.Add(btn_open_Client);
            Controls.Add(btn_open_Server);
            Name = "FormBT1";
            Text = "Lab 03 - Bài 1";
            Leave += FormBT1_Leave;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_open_Server;
        private Button btn_open_Client;
    }
}