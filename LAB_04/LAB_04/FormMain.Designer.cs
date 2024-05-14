namespace LAB_04
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
            btn_OpenBT1 = new Button();
            btn_OpenBT5 = new Button();
            btn_OpenBT2 = new Button();
            btn_OpenBT3 = new Button();
            btn_OpenBT7 = new Button();
            btn_OpenBT4 = new Button();
            SuspendLayout();
            // 
            // btn_OpenBT1
            // 
            btn_OpenBT1.BackColor = Color.White;
            btn_OpenBT1.FlatStyle = FlatStyle.Flat;
            btn_OpenBT1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenBT1.Location = new Point(12, 23);
            btn_OpenBT1.Name = "btn_OpenBT1";
            btn_OpenBT1.Size = new Size(325, 51);
            btn_OpenBT1.TabIndex = 0;
            btn_OpenBT1.Text = "Bài 1";
            btn_OpenBT1.UseVisualStyleBackColor = false;
            btn_OpenBT1.Click += btn_OpenBT1_Click;
            // 
            // btn_OpenBT5
            // 
            btn_OpenBT5.BackColor = Color.White;
            btn_OpenBT5.FlatStyle = FlatStyle.Flat;
            btn_OpenBT5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenBT5.Location = new Point(362, 89);
            btn_OpenBT5.Name = "btn_OpenBT5";
            btn_OpenBT5.Size = new Size(325, 51);
            btn_OpenBT5.TabIndex = 1;
            btn_OpenBT5.Text = "Bài 5 & 6";
            btn_OpenBT5.UseVisualStyleBackColor = false;
            btn_OpenBT5.Click += btn_OpenBT5_Click;
            // 
            // btn_OpenBT2
            // 
            btn_OpenBT2.BackColor = Color.White;
            btn_OpenBT2.FlatStyle = FlatStyle.Flat;
            btn_OpenBT2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenBT2.Location = new Point(12, 89);
            btn_OpenBT2.Name = "btn_OpenBT2";
            btn_OpenBT2.Size = new Size(325, 51);
            btn_OpenBT2.TabIndex = 2;
            btn_OpenBT2.Text = "Bài 2";
            btn_OpenBT2.UseVisualStyleBackColor = false;
            btn_OpenBT2.Click += btn_OpenBT2_Click;
            // 
            // btn_OpenBT3
            // 
            btn_OpenBT3.BackColor = Color.White;
            btn_OpenBT3.FlatStyle = FlatStyle.Flat;
            btn_OpenBT3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenBT3.Location = new Point(12, 155);
            btn_OpenBT3.Name = "btn_OpenBT3";
            btn_OpenBT3.Size = new Size(325, 51);
            btn_OpenBT3.TabIndex = 4;
            btn_OpenBT3.Text = "Bài 3";
            btn_OpenBT3.UseVisualStyleBackColor = false;
            btn_OpenBT3.Click += btn_OpenBT3_Click;
            // 
            // btn_OpenBT7
            // 
            btn_OpenBT7.BackColor = Color.White;
            btn_OpenBT7.FlatStyle = FlatStyle.Flat;
            btn_OpenBT7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenBT7.Location = new Point(362, 155);
            btn_OpenBT7.Name = "btn_OpenBT7";
            btn_OpenBT7.Size = new Size(325, 51);
            btn_OpenBT7.TabIndex = 5;
            btn_OpenBT7.Text = "Bài 7";
            btn_OpenBT7.UseVisualStyleBackColor = false;
            btn_OpenBT7.Click += btn_OpenBT7_Click;
            // 
            // btn_OpenBT4
            // 
            btn_OpenBT4.BackColor = Color.White;
            btn_OpenBT4.FlatStyle = FlatStyle.Flat;
            btn_OpenBT4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenBT4.Location = new Point(362, 23);
            btn_OpenBT4.Name = "btn_OpenBT4";
            btn_OpenBT4.Size = new Size(325, 51);
            btn_OpenBT4.TabIndex = 6;
            btn_OpenBT4.Text = "Bài 4";
            btn_OpenBT4.UseVisualStyleBackColor = false;
            btn_OpenBT4.Click += btn_OpenBT4_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 311);
            Controls.Add(btn_OpenBT4);
            Controls.Add(btn_OpenBT7);
            Controls.Add(btn_OpenBT3);
            Controls.Add(btn_OpenBT2);
            Controls.Add(btn_OpenBT5);
            Controls.Add(btn_OpenBT1);
            Name = "FormMain";
            Text = "LAB 04";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_OpenBT1;
        private Button btn_OpenBT5;
        private Button btn_OpenBT2;
        private Button btn_OpenBT3;
        private Button btn_OpenBT7;
        private Button btn_OpenBT4;
    }
}
