namespace LAB_05
{
    partial class FormBT6_DetailMail
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
            panel_content = new Panel();
            label1 = new Label();
            label2 = new Label();
            lb_subject = new Label();
            panel_attach = new Panel();
            btn_download = new Button();
            lb_filename = new Label();
            lb_from = new Label();
            lb_to = new Label();
            label3 = new Label();
            panel_attach.SuspendLayout();
            SuspendLayout();
            // 
            // panel_content
            // 
            panel_content.BorderStyle = BorderStyle.FixedSingle;
            panel_content.Location = new Point(12, 102);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(682, 369);
            panel_content.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // lb_subject
            // 
            lb_subject.AutoSize = true;
            lb_subject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_subject.Location = new Point(12, 70);
            lb_subject.Name = "lb_subject";
            lb_subject.Size = new Size(70, 28);
            lb_subject.TabIndex = 3;
            lb_subject.Text = "label3";
            // 
            // panel_attach
            // 
            panel_attach.BorderStyle = BorderStyle.FixedSingle;
            panel_attach.Controls.Add(btn_download);
            panel_attach.Controls.Add(lb_filename);
            panel_attach.Location = new Point(12, 518);
            panel_attach.Name = "panel_attach";
            panel_attach.Size = new Size(199, 77);
            panel_attach.TabIndex = 4;
            // 
            // btn_download
            // 
            btn_download.Location = new Point(13, 35);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(105, 30);
            btn_download.TabIndex = 2;
            btn_download.Text = "DownLoad";
            btn_download.UseVisualStyleBackColor = true;
            btn_download.Click += btn_download_Click;
            // 
            // lb_filename
            // 
            lb_filename.AutoSize = true;
            lb_filename.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_filename.Location = new Point(13, 9);
            lb_filename.Name = "lb_filename";
            lb_filename.Size = new Size(56, 23);
            lb_filename.TabIndex = 1;
            lb_filename.Text = "label4";
            // 
            // lb_from
            // 
            lb_from.AutoSize = true;
            lb_from.Location = new Point(64, 9);
            lb_from.Name = "lb_from";
            lb_from.Size = new Size(50, 20);
            lb_from.TabIndex = 5;
            lb_from.Text = "label4";
            // 
            // lb_to
            // 
            lb_to.AutoSize = true;
            lb_to.Location = new Point(64, 39);
            lb_to.Name = "lb_to";
            lb_to.Size = new Size(50, 20);
            lb_to.TabIndex = 6;
            lb_to.Text = "label5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 495);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 7;
            label3.Text = "Attachment";
            // 
            // FormBT6_DetailMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 617);
            Controls.Add(label3);
            Controls.Add(lb_to);
            Controls.Add(lb_from);
            Controls.Add(panel_attach);
            Controls.Add(lb_subject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel_content);
            Name = "FormBT6_DetailMail";
            Text = "FormBT6_DetailMail";
            Load += FormBT6_DetailMail_Load;
            panel_attach.ResumeLayout(false);
            panel_attach.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_content;
        private Label label1;
        private Label label2;
        private Label lb_subject;
        private Panel panel_attach;
        private Button btn_download;
        private Label lb_filename;
        private Label lb_from;
        private Label lb_to;
        private Label label3;
    }
}