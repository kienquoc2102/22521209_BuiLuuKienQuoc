namespace LAB_02
{
    partial class FormSubBT5_1
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
            txt_display_rank = new TextBox();
            label2 = new Label();
            txt_detail_film = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(592, 46);
            label1.TabIndex = 0;
            label1.Text = "XẾP HẠNG DOANH THU PHÒNG VÉ";
            // 
            // txt_display_rank
            // 
            txt_display_rank.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_display_rank.Location = new Point(118, 71);
            txt_display_rank.Multiline = true;
            txt_display_rank.Name = "txt_display_rank";
            txt_display_rank.Size = new Size(449, 193);
            txt_display_rank.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 282);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 2;
            label2.Text = "Chi tiết doanh thu";
            // 
            // txt_detail_film
            // 
            txt_detail_film.Location = new Point(118, 318);
            txt_detail_film.Multiline = true;
            txt_detail_film.Name = "txt_detail_film";
            txt_detail_film.Size = new Size(449, 192);
            txt_detail_film.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(201, 537);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(288, 48);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormSubBT5_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 597);
            Controls.Add(buttonExit);
            Controls.Add(txt_detail_film);
            Controls.Add(label2);
            Controls.Add(txt_display_rank);
            Controls.Add(label1);
            Name = "FormSubBT5_1";
            Text = "FormSubBT5_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_display_rank;
        private Label label2;
        private TextBox txt_detail_film;
        private Button buttonExit;
    }
}