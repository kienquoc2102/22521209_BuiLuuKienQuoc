namespace LAB_03
{
    partial class Form_TCPserver_BT4
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
            lb_InfoCine = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lb_InfoCine
            // 
            lb_InfoCine.FormattingEnabled = true;
            lb_InfoCine.Location = new Point(12, 43);
            lb_InfoCine.Name = "lb_InfoCine";
            lb_InfoCine.Size = new Size(603, 404);
            lb_InfoCine.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 1;
            label1.Text = "Danh sách vé và số lượng vé";
            // 
            // Form_TCPserver_BT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 485);
            Controls.Add(label1);
            Controls.Add(lb_InfoCine);
            Name = "Form_TCPserver_BT4";
            Text = "Form_TCPserver_BT4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_InfoCine;
        private Label label1;
    }
}