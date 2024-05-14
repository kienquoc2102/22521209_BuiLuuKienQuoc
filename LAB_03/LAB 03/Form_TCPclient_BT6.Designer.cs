namespace LAB_03
{
    partial class Form_TCPclient_BT6
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
            lv_connected_client = new ListView();
            label1 = new Label();
            label2 = new Label();
            txt_name_client = new TextBox();
            txt_message = new TextBox();
            btn_send = new Button();
            btn_disconnect = new Button();
            btn_connect = new Button();
            lb_notice = new Label();
            btn_Accept = new Button();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(12, 53);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(718, 386);
            lv_Message.TabIndex = 0;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.List;
            // 
            // lv_connected_client
            // 
            lv_connected_client.Location = new Point(747, 50);
            lv_connected_client.Name = "lv_connected_client";
            lv_connected_client.Size = new Size(142, 511);
            lv_connected_client.TabIndex = 1;
            lv_connected_client.UseCompatibleStateImageBehavior = false;
            lv_connected_client.View = View.List;
            lv_connected_client.SelectedIndexChanged += lv_connected_client_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(747, 24);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 2;
            label1.Text = "Participants";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 3;
            label2.Text = "Your name: ";
            // 
            // txt_name_client
            // 
            txt_name_client.BackColor = Color.White;
            txt_name_client.BorderStyle = BorderStyle.FixedSingle;
            txt_name_client.Location = new Point(108, 20);
            txt_name_client.Name = "txt_name_client";
            txt_name_client.Size = new Size(125, 27);
            txt_name_client.TabIndex = 4;
            // 
            // txt_message
            // 
            txt_message.BorderStyle = BorderStyle.FixedSingle;
            txt_message.Location = new Point(12, 522);
            txt_message.Multiline = true;
            txt_message.Name = "txt_message";
            txt_message.Size = new Size(597, 39);
            txt_message.TabIndex = 5;
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.White;
            btn_send.FlatStyle = FlatStyle.Flat;
            btn_send.Location = new Point(615, 522);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(115, 39);
            btn_send.TabIndex = 6;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // btn_disconnect
            // 
            btn_disconnect.BackColor = Color.White;
            btn_disconnect.FlatStyle = FlatStyle.Flat;
            btn_disconnect.Location = new Point(615, 442);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(115, 39);
            btn_disconnect.TabIndex = 7;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = false;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.White;
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.Location = new Point(494, 442);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(115, 39);
            btn_connect.TabIndex = 8;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // lb_notice
            // 
            lb_notice.AutoSize = true;
            lb_notice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_notice.Location = new Point(12, 458);
            lb_notice.Name = "lb_notice";
            lb_notice.Size = new Size(256, 23);
            lb_notice.TabIndex = 9;
            lb_notice.Text = "Someone wants to message you";
            lb_notice.Visible = false;
            // 
            // btn_Accept
            // 
            btn_Accept.BackColor = Color.White;
            btn_Accept.FlatStyle = FlatStyle.Flat;
            btn_Accept.Location = new Point(274, 442);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(115, 39);
            btn_Accept.TabIndex = 10;
            btn_Accept.Text = "Accept";
            btn_Accept.UseVisualStyleBackColor = false;
            btn_Accept.Visible = false;
            btn_Accept.Click += btn_Accept_Click;
            // 
            // Form_TCPclient_BT6
            // 
            AcceptButton = btn_send;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 579);
            Controls.Add(btn_Accept);
            Controls.Add(lb_notice);
            Controls.Add(btn_connect);
            Controls.Add(btn_disconnect);
            Controls.Add(btn_send);
            Controls.Add(txt_message);
            Controls.Add(txt_name_client);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lv_connected_client);
            Controls.Add(lv_Message);
            Name = "Form_TCPclient_BT6";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Message;
        private ListView lv_connected_client;
        private Label label1;
        private Label label2;
        private TextBox txt_name_client;
        private TextBox txt_message;
        private Button btn_send;
        private Button btn_disconnect;
        private Button btn_connect;
        private Label lb_notice;
        private Button btn_Accept;
    }
}