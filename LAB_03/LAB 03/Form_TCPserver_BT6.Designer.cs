namespace LAB_03
{
    partial class Form_TCPserver_BT6
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
            lv_message = new ListView();
            btn_listen = new Button();
            SuspendLayout();
            // 
            // lv_message
            // 
            lv_message.Location = new Point(12, 62);
            lv_message.Name = "lv_message";
            lv_message.Size = new Size(754, 403);
            lv_message.TabIndex = 0;
            lv_message.UseCompatibleStateImageBehavior = false;
            lv_message.View = View.List;
            // 
            // btn_listen
            // 
            btn_listen.BackColor = Color.White;
            btn_listen.FlatAppearance.BorderSize = 2;
            btn_listen.FlatStyle = FlatStyle.Flat;
            btn_listen.Location = new Point(564, 12);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(202, 44);
            btn_listen.TabIndex = 1;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = false;
            btn_listen.Click += btn_listen_Click;
            // 
            // Form_TCPserver_BT6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 477);
            Controls.Add(btn_listen);
            Controls.Add(lv_message);
            Name = "Form_TCPserver_BT6";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_message;
        private Button btn_listen;
    }
}