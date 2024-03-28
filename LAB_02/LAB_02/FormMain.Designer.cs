namespace LAB_02
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
            buttonBT1 = new Button();
            buttonBT3 = new Button();
            buttonBT2 = new Button();
            buttonBT4 = new Button();
            buttonBT5 = new Button();
            buttonBT6 = new Button();
            buttonBT7 = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonBT1
            // 
            buttonBT1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT1.Location = new Point(37, 52);
            buttonBT1.Name = "buttonBT1";
            buttonBT1.Size = new Size(229, 55);
            buttonBT1.TabIndex = 1;
            buttonBT1.Text = "Bài 1";
            buttonBT1.UseVisualStyleBackColor = true;
            buttonBT1.Click += buttonBT1_Click;
            // 
            // buttonBT3
            // 
            buttonBT3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT3.Location = new Point(545, 52);
            buttonBT3.Name = "buttonBT3";
            buttonBT3.Size = new Size(229, 55);
            buttonBT3.TabIndex = 2;
            buttonBT3.Text = "Bài 3";
            buttonBT3.UseVisualStyleBackColor = true;
            buttonBT3.Click += buttonBT3_Click;
            // 
            // buttonBT2
            // 
            buttonBT2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT2.Location = new Point(298, 52);
            buttonBT2.Name = "buttonBT2";
            buttonBT2.Size = new Size(229, 55);
            buttonBT2.TabIndex = 2;
            buttonBT2.Text = "Bài 2";
            buttonBT2.UseVisualStyleBackColor = true;
            buttonBT2.Click += buttonBT2_Click;
            // 
            // buttonBT4
            // 
            buttonBT4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT4.Location = new Point(37, 135);
            buttonBT4.Name = "buttonBT4";
            buttonBT4.Size = new Size(229, 55);
            buttonBT4.TabIndex = 3;
            buttonBT4.Text = "Bài 4";
            buttonBT4.UseVisualStyleBackColor = true;
            buttonBT4.Click += buttonBT4_Click;
            // 
            // buttonBT5
            // 
            buttonBT5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT5.Location = new Point(298, 135);
            buttonBT5.Name = "buttonBT5";
            buttonBT5.Size = new Size(229, 55);
            buttonBT5.TabIndex = 4;
            buttonBT5.Text = "Bài 5";
            buttonBT5.UseVisualStyleBackColor = true;
            buttonBT5.Click += buttonBT5_Click;
            // 
            // buttonBT6
            // 
            buttonBT6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT6.Location = new Point(545, 135);
            buttonBT6.Name = "buttonBT6";
            buttonBT6.Size = new Size(229, 55);
            buttonBT6.TabIndex = 5;
            buttonBT6.Text = "Bài 6";
            buttonBT6.UseVisualStyleBackColor = true;
            buttonBT6.Click += buttonBT6_Click;
            // 
            // buttonBT7
            // 
            buttonBT7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBT7.Location = new Point(298, 223);
            buttonBT7.Name = "buttonBT7";
            buttonBT7.Size = new Size(229, 55);
            buttonBT7.TabIndex = 6;
            buttonBT7.Text = "Bài 7";
            buttonBT7.UseVisualStyleBackColor = true;
            buttonBT7.Click += buttonBT7_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(298, 322);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(229, 67);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonBT7);
            Controls.Add(buttonBT6);
            Controls.Add(buttonBT5);
            Controls.Add(buttonBT4);
            Controls.Add(buttonBT2);
            Controls.Add(buttonBT3);
            Controls.Add(buttonBT1);
            Name = "FormMain";
            Text = "LAB02";
            Leave += FormMain_Leave;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBT1;
        private Button buttonBT3;
        private Button buttonBT2;
        private Button buttonBT4;
        private Button buttonBT5;
        private Button buttonBT6;
        private Button buttonBT7;
        private Button buttonExit;
    }
}
