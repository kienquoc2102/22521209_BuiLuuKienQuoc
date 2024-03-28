namespace LAB_01
{
    partial class FormBT7
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
            txt_Input = new TextBox();
            btn_Enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 18);
            label1.Name = "label1";
            label1.Size = new Size(428, 50);
            label1.TabIndex = 0;
            label1.Text = "NHẬP ĐIỂM SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 1;
            label2.Text = "Nhập điểm sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 113);
            label3.Name = "label3";
            label3.Size = new Size(263, 23);
            label3.TabIndex = 2;
            label3.Text = "Ví dụ: Nguyen Thi A, 7.5, 8, 8, 10 ";
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Input.Location = new Point(33, 151);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(721, 31);
            txt_Input.TabIndex = 3;
            // 
            // btn_Enter
            // 
            btn_Enter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Enter.Location = new Point(205, 214);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(428, 56);
            btn_Enter.TabIndex = 4;
            btn_Enter.Text = "Xuất điểm";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // FormBT7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 331);
            Controls.Add(btn_Enter);
            Controls.Add(txt_Input);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT7";
            Text = "Bài 7 - Xử lý mảng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Input;
        private Button btn_Enter;
    }
}