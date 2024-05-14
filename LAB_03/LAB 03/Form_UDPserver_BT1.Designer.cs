namespace LAB_03
{
    partial class Form_UDPserver_BT1
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
            txt_Port = new TextBox();
            btn_Listen = new Button();
            label2 = new Label();
            lv_Messages = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(41, 23);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // txt_Port
            // 
            txt_Port.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Port.Location = new Point(59, 22);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(263, 30);
            txt_Port.TabIndex = 1;
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.White;
            btn_Listen.FlatStyle = FlatStyle.Flat;
            btn_Listen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(406, 22);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(187, 44);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 3;
            label2.Text = "Received messages";
            // 
            // lv_Messages
            // 
            lv_Messages.Location = new Point(12, 119);
            lv_Messages.Name = "lv_Messages";
            lv_Messages.Size = new Size(581, 295);
            lv_Messages.TabIndex = 4;
            lv_Messages.UseCompatibleStateImageBehavior = false;
            lv_Messages.View = View.List;
            // 
            // Form_UDPserver_BT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(lv_Messages);
            Controls.Add(label2);
            Controls.Add(btn_Listen);
            Controls.Add(txt_Port);
            Controls.Add(label1);
            Name = "Form_UDPserver_BT1";
            Text = "UDP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Port;
        private Button btn_Listen;
        private Label label2;
        private ListView lv_Messages;
    }
}