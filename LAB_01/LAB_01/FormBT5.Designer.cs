namespace LAB_01
{
    partial class FormBT5
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
            txt_InputA = new TextBox();
            label2 = new Label();
            txt_InputB = new TextBox();
            cb_calc = new ComboBox();
            btn_Enter = new Button();
            btn_Delete = new Button();
            btn_Exit = new Button();
            txt_Output = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 51);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // txt_InputA
            // 
            txt_InputA.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_InputA.Location = new Point(103, 45);
            txt_InputA.Name = "txt_InputA";
            txt_InputA.Size = new Size(157, 31);
            txt_InputA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Nhập B";
            // 
            // txt_InputB
            // 
            txt_InputB.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_InputB.Location = new Point(454, 48);
            txt_InputB.Name = "txt_InputB";
            txt_InputB.Size = new Size(157, 31);
            txt_InputB.TabIndex = 3;
            // 
            // cb_calc
            // 
            cb_calc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_calc.FormattingEnabled = true;
            cb_calc.Location = new Point(176, 100);
            cb_calc.Name = "cb_calc";
            cb_calc.Size = new Size(272, 33);
            cb_calc.TabIndex = 4;
            // 
            // btn_Enter
            // 
            btn_Enter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Enter.Location = new Point(24, 167);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(195, 46);
            btn_Enter.TabIndex = 5;
            btn_Enter.Text = "Tính";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.Location = new Point(225, 167);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(190, 46);
            btn_Delete.TabIndex = 6;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(421, 167);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(190, 46);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // txt_Output
            // 
            txt_Output.BackColor = Color.White;
            txt_Output.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Output.Location = new Point(24, 259);
            txt_Output.Multiline = true;
            txt_Output.Name = "txt_Output";
            txt_Output.ScrollBars = ScrollBars.Vertical;
            txt_Output.Size = new Size(587, 321);
            txt_Output.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 231);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 9;
            label3.Text = "Kết quả";
            // 
            // FormBT5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 592);
            Controls.Add(label3);
            Controls.Add(txt_Output);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Enter);
            Controls.Add(cb_calc);
            Controls.Add(txt_InputB);
            Controls.Add(label2);
            Controls.Add(txt_InputA);
            Controls.Add(label1);
            Name = "FormBT5";
            Text = "Tính giá trị";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_InputA;
        private Label label2;
        private TextBox txt_InputB;
        private ComboBox cb_calc;
        private Button btn_Enter;
        private Button btn_Delete;
        private Button btn_Exit;
        private TextBox txt_Output;
        private Label label3;
    }
}