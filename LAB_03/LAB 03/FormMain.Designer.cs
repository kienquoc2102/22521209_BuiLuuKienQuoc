namespace LAB_03
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Form1 = new Button();
            btn_Form4 = new Button();
            btn_Form2 = new Button();
            btn_Form5 = new Button();
            btn_Form3 = new Button();
            btn_Form6 = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_Form1
            // 
            btn_Form1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Form1.Location = new Point(29, 33);
            btn_Form1.Name = "btn_Form1";
            btn_Form1.Size = new Size(334, 45);
            btn_Form1.TabIndex = 0;
            btn_Form1.Text = "Bài 1";
            btn_Form1.UseVisualStyleBackColor = true;
            btn_Form1.Click += btn_Form1_Click;
            // 
            // btn_Form4
            // 
            btn_Form4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Form4.Location = new Point(385, 33);
            btn_Form4.Name = "btn_Form4";
            btn_Form4.Size = new Size(334, 45);
            btn_Form4.TabIndex = 1;
            btn_Form4.Text = "Bài 4";
            btn_Form4.UseVisualStyleBackColor = true;
            btn_Form4.Click += btn_Form4_Click;
            // 
            // btn_Form2
            // 
            btn_Form2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Form2.Location = new Point(29, 107);
            btn_Form2.Name = "btn_Form2";
            btn_Form2.Size = new Size(334, 45);
            btn_Form2.TabIndex = 2;
            btn_Form2.Text = "Bài 2";
            btn_Form2.UseVisualStyleBackColor = true;
            btn_Form2.Click += btn_Form2_Click;
            // 
            // btn_Form5
            // 
            btn_Form5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Form5.Location = new Point(385, 107);
            btn_Form5.Name = "btn_Form5";
            btn_Form5.Size = new Size(334, 45);
            btn_Form5.TabIndex = 3;
            btn_Form5.Text = "Bài 5";
            btn_Form5.UseVisualStyleBackColor = true;
            btn_Form5.Click += btn_Form5_Click;
            // 
            // btn_Form3
            // 
            btn_Form3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Form3.Location = new Point(29, 184);
            btn_Form3.Name = "btn_Form3";
            btn_Form3.Size = new Size(334, 45);
            btn_Form3.TabIndex = 4;
            btn_Form3.Text = "Bài 3";
            btn_Form3.UseVisualStyleBackColor = true;
            btn_Form3.Click += btn_Form3_Click;
            // 
            // btn_Form6
            // 
            btn_Form6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Form6.Location = new Point(385, 184);
            btn_Form6.Name = "btn_Form6";
            btn_Form6.Size = new Size(334, 45);
            btn_Form6.TabIndex = 5;
            btn_Form6.Text = "Bài 6";
            btn_Form6.UseVisualStyleBackColor = true;
            btn_Form6.Click += btn_Form6_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(220, 262);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(309, 52);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 346);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Form6);
            Controls.Add(btn_Form3);
            Controls.Add(btn_Form5);
            Controls.Add(btn_Form2);
            Controls.Add(btn_Form4);
            Controls.Add(btn_Form1);
            Name = "FormMain";
            Text = "LAB 03";
            Leave += FormMain_Leave;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Form1;
        private Button btn_Form4;
        private Button btn_Form2;
        private Button btn_Form5;
        private Button btn_Form3;
        private Button btn_Form6;
        private Button btn_Exit;
    }
}
