namespace LAB_01
{
    partial class FormBT3_1
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
            txt_Output = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            btnDelete = new Button();
            btnEnter = new Button();
            txt_Input = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_Output
            // 
            txt_Output.BackColor = Color.White;
            txt_Output.Enabled = false;
            txt_Output.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Output.Location = new Point(141, 239);
            txt_Output.Multiline = true;
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(319, 62);
            txt_Output.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 273);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 12;
            label2.Text = "Kết quả";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(493, 249);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 55);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(493, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 55);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(493, 59);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(144, 55);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Đọc ";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Input.Location = new Point(208, 59);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(252, 34);
            txt_Input.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 65);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 7;
            label1.Text = "Nhập số nguyên";
            // 
            // FormBT3_1
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
            Name = "FormBT3_1";
            Text = "Bài tập 3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Output;
        private Label label2;
        private Button btnExit;
        private Button btnDelete;
        private Button btnEnter;
        private TextBox txt_Input;
        private Label label1;
    }
}