namespace LAB_03
{
    partial class Form_UDPclient_BT1
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
            txt_IP = new TextBox();
            label2 = new Label();
            txt_Port = new TextBox();
            label3 = new Label();
            txt_Message = new TextBox();
            btn_Send = new Button();
            lv_Message = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "IP Remote host";
            // 
            // txt_IP
            // 
            txt_IP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_IP.Location = new Point(12, 35);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(391, 30);
            txt_IP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 23);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // txt_Port
            // 
            txt_Port.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Port.Location = new Point(450, 35);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(270, 30);
            txt_Port.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 4;
            label3.Text = "Message";
            // 
            // txt_Message
            // 
            txt_Message.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Message.Location = new Point(12, 357);
            txt_Message.Multiline = true;
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(479, 44);
            txt_Message.TabIndex = 5;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.White;
            btn_Send.FlatStyle = FlatStyle.Flat;
            btn_Send.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(504, 357);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(216, 44);
            btn_Send.TabIndex = 6;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(12, 133);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(708, 209);
            lv_Message.TabIndex = 7;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.List;
            // 
            // Form_UDPclient_BT1
            // 
            AcceptButton = btn_Send;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 413);
            Controls.Add(lv_Message);
            Controls.Add(btn_Send);
            Controls.Add(txt_Message);
            Controls.Add(label3);
            Controls.Add(txt_Port);
            Controls.Add(label2);
            Controls.Add(txt_IP);
            Controls.Add(label1);
            Name = "Form_UDPclient_BT1";
            Text = "UDP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_IP;
        private Label label2;
        private TextBox txt_Port;
        private Label label3;
        private TextBox txt_Message;
        private Button btn_Send;
        private ListView lv_Message;
    }
}