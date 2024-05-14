namespace LAB_03
{
    partial class Form_PrivateChat_Server
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
            lb_message = new ListBox();
            txt_Message = new TextBox();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // lb_message
            // 
            lb_message.BorderStyle = BorderStyle.FixedSingle;
            lb_message.FormattingEnabled = true;
            lb_message.Location = new Point(12, 28);
            lb_message.Name = "lb_message";
            lb_message.Size = new Size(595, 362);
            lb_message.TabIndex = 0;
            // 
            // txt_Message
            // 
            txt_Message.Location = new Point(12, 398);
            txt_Message.Multiline = true;
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(468, 47);
            txt_Message.TabIndex = 1;
            // 
            // btn_Send
            // 
            btn_Send.FlatStyle = FlatStyle.Flat;
            btn_Send.Location = new Point(486, 398);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(121, 47);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // Form_PrivateChat_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 489);
            Controls.Add(btn_Send);
            Controls.Add(txt_Message);
            Controls.Add(lb_message);
            Name = "Form_PrivateChat_Server";
            Text = "Form_PrivateChat_Server";
            Load += Form_PrivateChat_Server_Load;
            Leave += Form_PrivateChat_Server_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_message;
        private TextBox txt_Message;
        private Button btn_Send;
    }
}