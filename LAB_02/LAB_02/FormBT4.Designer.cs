namespace LAB_02
{
    partial class FormBT4
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
            txt_display_File = new TextBox();
            btn_Write_Output = new Button();
            btn_Read_Output = new Button();
            label1 = new Label();
            txt_input_Name = new TextBox();
            label2 = new Label();
            txt_input_ID = new TextBox();
            label3 = new Label();
            txt_input_Phone = new TextBox();
            label4 = new Label();
            txt_input_Course1 = new TextBox();
            label5 = new Label();
            txt_input_Course2 = new TextBox();
            label6 = new Label();
            txt_input_Course3 = new TextBox();
            btn_Add_Input = new Button();
            label7 = new Label();
            txt_output_Name = new TextBox();
            label8 = new Label();
            txt_output_ID = new TextBox();
            label9 = new Label();
            txt_output_Phone = new TextBox();
            label10 = new Label();
            txt_output_Course1 = new TextBox();
            label11 = new Label();
            txt_output_Course2 = new TextBox();
            label12 = new Label();
            txt_output_Course3 = new TextBox();
            label13 = new Label();
            txt_output_AVG = new TextBox();
            btn_Back = new Button();
            btn_Next = new Button();
            SuspendLayout();
            // 
            // txt_display_File
            // 
            txt_display_File.Location = new Point(258, 12);
            txt_display_File.Multiline = true;
            txt_display_File.Name = "txt_display_File";
            txt_display_File.Size = new Size(395, 632);
            txt_display_File.TabIndex = 0;
            // 
            // btn_Write_Output
            // 
            btn_Write_Output.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Write_Output.Location = new Point(12, 12);
            btn_Write_Output.Name = "btn_Write_Output";
            btn_Write_Output.Size = new Size(240, 44);
            btn_Write_Output.TabIndex = 1;
            btn_Write_Output.Text = "Write to a file";
            btn_Write_Output.UseVisualStyleBackColor = true;
            btn_Write_Output.Click += btn_Write_Output_Click;
            // 
            // btn_Read_Output
            // 
            btn_Read_Output.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read_Output.Location = new Point(659, 12);
            btn_Read_Output.Name = "btn_Read_Output";
            btn_Read_Output.Size = new Size(242, 44);
            btn_Read_Output.TabIndex = 2;
            btn_Read_Output.Text = "Read a file";
            btn_Read_Output.UseVisualStyleBackColor = true;
            btn_Read_Output.Click += btn_Read_Output_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // txt_input_Name
            // 
            txt_input_Name.Location = new Point(12, 95);
            txt_input_Name.Name = "txt_input_Name";
            txt_input_Name.Size = new Size(240, 27);
            txt_input_Name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // txt_input_ID
            // 
            txt_input_ID.Location = new Point(12, 169);
            txt_input_ID.Name = "txt_input_ID";
            txt_input_ID.Size = new Size(240, 27);
            txt_input_ID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 218);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 7;
            label3.Text = "Phone";
            // 
            // txt_input_Phone
            // 
            txt_input_Phone.Location = new Point(12, 244);
            txt_input_Phone.Name = "txt_input_Phone";
            txt_input_Phone.Size = new Size(240, 27);
            txt_input_Phone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 294);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 9;
            label4.Text = "Course 1";
            // 
            // txt_input_Course1
            // 
            txt_input_Course1.Location = new Point(12, 320);
            txt_input_Course1.Name = "txt_input_Course1";
            txt_input_Course1.Size = new Size(240, 27);
            txt_input_Course1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 368);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 11;
            label5.Text = "Course 2";
            // 
            // txt_input_Course2
            // 
            txt_input_Course2.Location = new Point(12, 394);
            txt_input_Course2.Name = "txt_input_Course2";
            txt_input_Course2.Size = new Size(240, 27);
            txt_input_Course2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 445);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 13;
            label6.Text = "Course 3";
            // 
            // txt_input_Course3
            // 
            txt_input_Course3.Location = new Point(12, 471);
            txt_input_Course3.Name = "txt_input_Course3";
            txt_input_Course3.Size = new Size(240, 27);
            txt_input_Course3.TabIndex = 14;
            // 
            // btn_Add_Input
            // 
            btn_Add_Input.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add_Input.Location = new Point(44, 598);
            btn_Add_Input.Name = "btn_Add_Input";
            btn_Add_Input.Size = new Size(176, 46);
            btn_Add_Input.TabIndex = 15;
            btn_Add_Input.Text = "Add";
            btn_Add_Input.UseVisualStyleBackColor = true;
            btn_Add_Input.Click += btn_Add_Input_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(659, 72);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 16;
            label7.Text = "Name";
            // 
            // txt_output_Name
            // 
            txt_output_Name.BackColor = Color.White;
            txt_output_Name.Enabled = false;
            txt_output_Name.Location = new Point(661, 95);
            txt_output_Name.Name = "txt_output_Name";
            txt_output_Name.Size = new Size(240, 27);
            txt_output_Name.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(661, 143);
            label8.Name = "label8";
            label8.Size = new Size(27, 23);
            label8.TabIndex = 18;
            label8.Text = "ID";
            // 
            // txt_output_ID
            // 
            txt_output_ID.BackColor = Color.White;
            txt_output_ID.Enabled = false;
            txt_output_ID.Location = new Point(661, 169);
            txt_output_ID.Name = "txt_output_ID";
            txt_output_ID.Size = new Size(240, 27);
            txt_output_ID.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(659, 218);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 20;
            label9.Text = "Phone";
            // 
            // txt_output_Phone
            // 
            txt_output_Phone.BackColor = Color.White;
            txt_output_Phone.Enabled = false;
            txt_output_Phone.Location = new Point(659, 244);
            txt_output_Phone.Name = "txt_output_Phone";
            txt_output_Phone.Size = new Size(240, 27);
            txt_output_Phone.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(659, 294);
            label10.Name = "label10";
            label10.Size = new Size(75, 23);
            label10.TabIndex = 22;
            label10.Text = "Course 1";
            // 
            // txt_output_Course1
            // 
            txt_output_Course1.BackColor = Color.White;
            txt_output_Course1.Enabled = false;
            txt_output_Course1.Location = new Point(659, 320);
            txt_output_Course1.Name = "txt_output_Course1";
            txt_output_Course1.Size = new Size(240, 27);
            txt_output_Course1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(659, 368);
            label11.Name = "label11";
            label11.Size = new Size(77, 23);
            label11.TabIndex = 24;
            label11.Text = "Course 2";
            // 
            // txt_output_Course2
            // 
            txt_output_Course2.BackColor = Color.White;
            txt_output_Course2.Enabled = false;
            txt_output_Course2.Location = new Point(659, 394);
            txt_output_Course2.Name = "txt_output_Course2";
            txt_output_Course2.Size = new Size(240, 27);
            txt_output_Course2.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(659, 445);
            label12.Name = "label12";
            label12.Size = new Size(77, 23);
            label12.TabIndex = 26;
            label12.Text = "Course 3";
            // 
            // txt_output_Course3
            // 
            txt_output_Course3.BackColor = Color.White;
            txt_output_Course3.Enabled = false;
            txt_output_Course3.Location = new Point(659, 471);
            txt_output_Course3.Name = "txt_output_Course3";
            txt_output_Course3.Size = new Size(240, 27);
            txt_output_Course3.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(659, 523);
            label13.Name = "label13";
            label13.Size = new Size(73, 23);
            label13.TabIndex = 28;
            label13.Text = "Avarage";
            // 
            // txt_output_AVG
            // 
            txt_output_AVG.BackColor = Color.White;
            txt_output_AVG.Enabled = false;
            txt_output_AVG.Location = new Point(659, 549);
            txt_output_AVG.Name = "txt_output_AVG";
            txt_output_AVG.Size = new Size(240, 27);
            txt_output_AVG.TabIndex = 29;
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.Location = new Point(661, 598);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(108, 46);
            btn_Back.TabIndex = 30;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Next
            // 
            btn_Next.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Next.Location = new Point(793, 598);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(108, 46);
            btn_Next.TabIndex = 31;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // FormBT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 656);
            Controls.Add(btn_Next);
            Controls.Add(btn_Back);
            Controls.Add(txt_output_AVG);
            Controls.Add(label13);
            Controls.Add(txt_output_Course3);
            Controls.Add(label12);
            Controls.Add(txt_output_Course2);
            Controls.Add(label11);
            Controls.Add(txt_output_Course1);
            Controls.Add(label10);
            Controls.Add(txt_output_Phone);
            Controls.Add(label9);
            Controls.Add(txt_output_ID);
            Controls.Add(label8);
            Controls.Add(txt_output_Name);
            Controls.Add(label7);
            Controls.Add(btn_Add_Input);
            Controls.Add(txt_input_Course3);
            Controls.Add(label6);
            Controls.Add(txt_input_Course2);
            Controls.Add(label5);
            Controls.Add(txt_input_Course1);
            Controls.Add(label4);
            Controls.Add(txt_input_Phone);
            Controls.Add(label3);
            Controls.Add(txt_input_ID);
            Controls.Add(label2);
            Controls.Add(txt_input_Name);
            Controls.Add(label1);
            Controls.Add(btn_Read_Output);
            Controls.Add(btn_Write_Output);
            Controls.Add(txt_display_File);
            Name = "FormBT4";
            Text = "Bài 4 - Đọc và Ghi file sử dụng BinaryFormatter (JsonSerializer)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_display_File;
        private Button btn_Write_Output;
        private Button btn_Read_Output;
        private Label label1;
        private TextBox txt_input_Name;
        private Label label2;
        private TextBox txt_input_ID;
        private Label label3;
        private TextBox txt_input_Phone;
        private Label label4;
        private TextBox txt_input_Course1;
        private Label label5;
        private TextBox txt_input_Course2;
        private Label label6;
        private TextBox txt_input_Course3;
        private Button btn_Add_Input;
        private Label label7;
        private TextBox txt_output_Name;
        private Label label8;
        private TextBox txt_output_ID;
        private Label label9;
        private TextBox txt_output_Phone;
        private Label label10;
        private TextBox txt_output_Course1;
        private Label label11;
        private TextBox txt_output_Course2;
        private Label label12;
        private TextBox txt_output_Course3;
        private Label label13;
        private TextBox txt_output_AVG;
        private Button btn_Back;
        private Button btn_Next;
    }
}