namespace LAB_05
{
    partial class FormBT4
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
            panel_listfilm = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel_listfilm
            // 
            panel_listfilm.AutoScroll = true;
            panel_listfilm.BorderStyle = BorderStyle.FixedSingle;
            panel_listfilm.Location = new Point(12, 64);
            panel_listfilm.Name = "panel_listfilm";
            panel_listfilm.Size = new Size(658, 572);
            panel_listfilm.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(329, 46);
            label1.TabIndex = 2;
            label1.Text = "PHIM ĐANG CHIẾU";
            // 
            // FormBT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 646);
            Controls.Add(panel_listfilm);
            Controls.Add(label1);
            Name = "FormBT4";
            Text = "FormBT4";
            Load += FormBT4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_listfilm;
        private Label label1;
    }
}