namespace LAB_01
{
    partial class FormBT6
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btn_Enter = new Button();
            txt_Output = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(45, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(527, 30);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 46);
            label1.TabIndex = 1;
            label1.Text = "CUNG HOÀNG ĐẠO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(267, 23);
            label2.TabIndex = 2;
            label2.Text = "Ngày / Tháng /Năm sinh của bạn";
            // 
            // btn_Enter
            // 
            btn_Enter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Enter.Location = new Point(177, 176);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(229, 49);
            btn_Enter.TabIndex = 3;
            btn_Enter.Text = "Kết quả";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // txt_Output
            // 
            txt_Output.BackColor = Color.White;
            txt_Output.Enabled = false;
            txt_Output.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Output.Location = new Point(177, 241);
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(229, 30);
            txt_Output.TabIndex = 4;
            // 
            // FormBT6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 334);
            Controls.Add(txt_Output);
            Controls.Add(btn_Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "FormBT6";
            Text = "FormBT6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Button btn_Enter;
        private TextBox txt_Output;
    }
}