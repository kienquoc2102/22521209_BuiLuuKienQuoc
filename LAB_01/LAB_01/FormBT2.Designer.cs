namespace LAB_01
{
    partial class FormBT2
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
            label4 = new Label();
            txtInput_1 = new TextBox();
            txtInput_2 = new TextBox();
            txtInput_3 = new TextBox();
            btnEnter = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label5 = new Label();
            label6 = new Label();
            txtOutput_Max = new TextBox();
            txtOutput_Min = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 124);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 225);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 32);
            label4.Name = "label4";
            label4.Size = new Size(285, 54);
            label4.TabIndex = 3;
            label4.Text = "TÌM MAX MIN";
            // 
            // txtInput_1
            // 
            txtInput_1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInput_1.Location = new Point(242, 118);
            txtInput_1.Name = "txtInput_1";
            txtInput_1.Size = new Size(405, 34);
            txtInput_1.TabIndex = 4;
            // 
            // txtInput_2
            // 
            txtInput_2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInput_2.Location = new Point(242, 170);
            txtInput_2.Name = "txtInput_2";
            txtInput_2.Size = new Size(405, 34);
            txtInput_2.TabIndex = 5;
            // 
            // txtInput_3
            // 
            txtInput_3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInput_3.Location = new Point(242, 219);
            txtInput_3.Name = "txtInput_3";
            txtInput_3.Size = new Size(405, 34);
            txtInput_3.TabIndex = 6;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(147, 270);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(155, 60);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "TÌM";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(319, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 60);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "XÓA ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(492, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 60);
            btnExit.TabIndex = 9;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(146, 354);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 10;
            label5.Text = "Số lớn nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(146, 396);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 11;
            label6.Text = "Số nhỏ nhất";
            // 
            // txtOutput_Max
            // 
            txtOutput_Max.BackColor = Color.White;
            txtOutput_Max.Enabled = false;
            txtOutput_Max.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutput_Max.Location = new Point(282, 348);
            txtOutput_Max.Name = "txtOutput_Max";
            txtOutput_Max.Size = new Size(365, 34);
            txtOutput_Max.TabIndex = 12;
            // 
            // txtOutput_Min
            // 
            txtOutput_Min.BackColor = Color.White;
            txtOutput_Min.Enabled = false;
            txtOutput_Min.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutput_Min.Location = new Point(282, 390);
            txtOutput_Min.Name = "txtOutput_Min";
            txtOutput_Min.Size = new Size(365, 34);
            txtOutput_Min.TabIndex = 13;
            // 
            // FormBT2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(txtOutput_Min);
            Controls.Add(txtOutput_Max);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEnter);
            Controls.Add(txtInput_3);
            Controls.Add(txtInput_2);
            Controls.Add(txtInput_1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT2";
            Text = "Bài tập 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtInput_1;
        private TextBox txtInput_2;
        private TextBox txtInput_3;
        private Button btnEnter;
        private Button btnDelete;
        private Button btnExit;
        private Label label5;
        private Label label6;
        private TextBox txtOutput_Max;
        private TextBox txtOutput_Min;
    }
}