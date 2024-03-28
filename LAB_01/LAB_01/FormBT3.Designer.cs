namespace LAB_01
{
    partial class FormBT3
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
            txt_Input = new TextBox();
            btnEnter = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label2 = new Label();
            txt_Output = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(301, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Input.Location = new Point(341, 44);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(114, 34);
            txt_Input.TabIndex = 1;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(488, 44);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(144, 55);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Đọc ";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(488, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 55);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(488, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 55);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 258);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 5;
            label2.Text = "Kết quả";
            // 
            // txt_Output
            // 
            txt_Output.BackColor = Color.White;
            txt_Output.Enabled = false;
            txt_Output.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Output.Location = new Point(136, 252);
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(319, 34);
            txt_Output.TabIndex = 6;
            // 
            // FormBT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 363);
            Controls.Add(txt_Output);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEnter);
            Controls.Add(txt_Input);
            Controls.Add(label1);
            Name = "FormBT3";
            Text = "Bài tập 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Input;
        private Button btnEnter;
        private Button btnDelete;
        private Button btnExit;
        private Label label2;
        private TextBox txt_Output;
    }
}