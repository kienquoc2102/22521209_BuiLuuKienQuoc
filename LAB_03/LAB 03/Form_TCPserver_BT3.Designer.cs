namespace LAB_03
{
    partial class Form_TCPserver_BT3
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
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(12, 74);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(633, 420);
            lv_Message.TabIndex = 0;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.List;
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.White;
            btn_Listen.FlatStyle = FlatStyle.Flat;
            btn_Listen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(388, 24);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(257, 37);
            btn_Listen.TabIndex = 1;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Form_TCPserver_BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 506);
            Controls.Add(btn_Listen);
            Controls.Add(lv_Message);
            Name = "Form_TCPserver_BT3";
            Text = "TCP Server";
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_Message;
        private Button btn_Listen;
    }
}