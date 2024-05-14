namespace LAB_03
{
    partial class Form_TCPclient_BT3
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
            lv_Message = new ListView();
            txt_Message = new TextBox();
            btn_Connect = new Button();
            btn_Disconnect = new Button();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.BorderStyle = BorderStyle.FixedSingle;
            lv_Message.Location = new Point(12, 12);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(630, 363);
            lv_Message.TabIndex = 0;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.List;
            // 
            // txt_Message
            // 
            txt_Message.Location = new Point(12, 391);
            txt_Message.Multiline = true;
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(630, 41);
            txt_Message.TabIndex = 1;
            // 
            // btn_Connect
            // 
            btn_Connect.BackColor = Color.White;
            btn_Connect.FlatStyle = FlatStyle.Flat;
            btn_Connect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Connect.Location = new Point(648, 12);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(140, 44);
            btn_Connect.TabIndex = 2;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.BackColor = Color.White;
            btn_Disconnect.FlatStyle = FlatStyle.Flat;
            btn_Disconnect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Disconnect.Location = new Point(648, 71);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(140, 44);
            btn_Disconnect.TabIndex = 3;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = false;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.White;
            btn_Send.FlatStyle = FlatStyle.Flat;
            btn_Send.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(648, 391);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(140, 41);
            btn_Send.TabIndex = 4;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // Form_TCPclient_BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Send);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Connect);
            Controls.Add(txt_Message);
            Controls.Add(lv_Message);
            Name = "Form_TCPclient_BT3";
            Text = "TCP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Message;
        private TextBox txt_Message;
        private Button btn_Connect;
        private Button btn_Disconnect;
        private Button btn_Send;
    }
}