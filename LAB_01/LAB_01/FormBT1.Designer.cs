namespace LAB_01
{
    partial class FormBT1
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
            label3 = new Label();
            txtInput_1 = new TextBox();
            txtInput_2 = new TextBox();
            bntCalc = new Button();
            label4 = new Label();
            txtOutput = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 29);
            label1.Name = "label1";
            label1.Size = new Size(572, 60);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 114);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 185);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 2";
            // 
            // txtInput_1
            // 
            txtInput_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput_1.Location = new Point(176, 108);
            txtInput_1.Name = "txtInput_1";
            txtInput_1.Size = new Size(526, 34);
            txtInput_1.TabIndex = 3;
            // 
            // txtInput_2
            // 
            txtInput_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput_2.Location = new Point(176, 179);
            txtInput_2.Name = "txtInput_2";
            txtInput_2.Size = new Size(526, 34);
            txtInput_2.TabIndex = 4;
            // 
            // bntCalc
            // 
            bntCalc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntCalc.Location = new Point(67, 252);
            bntCalc.Name = "bntCalc";
            bntCalc.Size = new Size(318, 54);
            bntCalc.TabIndex = 5;
            bntCalc.Text = "TÍNH";
            bntCalc.UseVisualStyleBackColor = true;
            bntCalc.Click += bntCalc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 343);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 6;
            label4.Text = "Kết quả";
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.White;
            txtOutput.Enabled = false;
            txtOutput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(176, 337);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(526, 34);
            txtOutput.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(391, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(311, 54);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "XÓA";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormBT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtOutput);
            Controls.Add(label4);
            Controls.Add(bntCalc);
            Controls.Add(txtInput_2);
            Controls.Add(txtInput_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT1";
            Text = "Bài tập 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtInput_1;
        private TextBox txtInput_2;
        private Button bntCalc;
        private Label label4;
        private TextBox txtOutput;
        private Button btnDelete;
    }
}