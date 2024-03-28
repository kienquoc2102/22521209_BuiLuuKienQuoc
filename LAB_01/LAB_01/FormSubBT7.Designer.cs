namespace LAB_01
{
    partial class FormSubBT7
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
            label2 = new Label();
            txt_Name = new TextBox();
            label3 = new Label();
            txt_Score = new TextBox();
            label4 = new Label();
            txt_AvgScore = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_Max = new TextBox();
            txt_Min = new TextBox();
            btn_Exit = new Button();
            label7 = new Label();
            txt_Type = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 50);
            label1.TabIndex = 0;
            label1.Text = "BẢNG ĐIỂM ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 85);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Name.Location = new Point(122, 78);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(415, 30);
            txt_Name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 128);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 3;
            label3.Text = "Điểm";
            // 
            // txt_Score
            // 
            txt_Score.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Score.Location = new Point(30, 154);
            txt_Score.Multiline = true;
            txt_Score.Name = "txt_Score";
            txt_Score.Size = new Size(507, 198);
            txt_Score.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 365);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 5;
            label4.Text = "Điểm trung bình";
            // 
            // txt_AvgScore
            // 
            txt_AvgScore.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_AvgScore.Location = new Point(172, 358);
            txt_AvgScore.Name = "txt_AvgScore";
            txt_AvgScore.Size = new Size(365, 30);
            txt_AvgScore.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 402);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 7;
            label5.Text = "Môn cao nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 444);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 8;
            label6.Text = "Môn thấp nhất";
            // 
            // txt_Max
            // 
            txt_Max.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Max.Location = new Point(172, 395);
            txt_Max.Name = "txt_Max";
            txt_Max.Size = new Size(365, 30);
            txt_Max.TabIndex = 9;
            // 
            // txt_Min
            // 
            txt_Min.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Min.Location = new Point(172, 437);
            txt_Min.Name = "txt_Min";
            txt_Min.Size = new Size(365, 30);
            txt_Min.TabIndex = 10;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(172, 539);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(240, 46);
            btn_Exit.TabIndex = 11;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 487);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 12;
            label7.Text = "Xếp loại";
            // 
            // txt_Type
            // 
            txt_Type.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Type.Location = new Point(172, 480);
            txt_Type.Name = "txt_Type";
            txt_Type.Size = new Size(365, 30);
            txt_Type.TabIndex = 13;
            // 
            // FormSubBT7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 597);
            Controls.Add(txt_Type);
            Controls.Add(label7);
            Controls.Add(btn_Exit);
            Controls.Add(txt_Min);
            Controls.Add(txt_Max);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_AvgScore);
            Controls.Add(label4);
            Controls.Add(txt_Score);
            Controls.Add(label3);
            Controls.Add(txt_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSubBT7";
            Text = "FormSubBT7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Name;
        private Label label3;
        private TextBox txt_Score;
        private Label label4;
        private TextBox txt_AvgScore;
        private Label label5;
        private Label label6;
        private TextBox txt_Max;
        private TextBox txt_Min;
        private Button btn_Exit;
        private Label label7;
        private TextBox txt_Type;
    }
}