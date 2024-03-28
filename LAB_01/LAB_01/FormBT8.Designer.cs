namespace LAB_01
{
    partial class FormBT8
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
            txt_Display = new TextBox();
            btn_Add = new Button();
            btn_Rand = new Button();
            btn_Exit = new Button();
            btn_Delete = new Button();
            label2 = new Label();
            txt_Output = new TextBox();
            btn_ref = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 50);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn";
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Input.Location = new Point(144, 44);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(231, 31);
            txt_Input.TabIndex = 1;
            // 
            // txt_Display
            // 
            txt_Display.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Display.Location = new Point(391, 41);
            txt_Display.Multiline = true;
            txt_Display.Name = "txt_Display";
            txt_Display.Size = new Size(386, 234);
            txt_Display.TabIndex = 2;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(201, 103);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(174, 51);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Rand
            // 
            btn_Rand.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Rand.Location = new Point(22, 295);
            btn_Rand.Name = "btn_Rand";
            btn_Rand.Size = new Size(353, 51);
            btn_Rand.TabIndex = 4;
            btn_Rand.Text = "Tìm món ăn";
            btn_Rand.UseVisualStyleBackColor = true;
            btn_Rand.Click += btn_Rand_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(590, 295);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(187, 51);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.Location = new Point(391, 295);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(185, 51);
            btn_Delete.TabIndex = 6;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 386);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 7;
            label2.Text = "Món ăn hôm nay là";
            // 
            // txt_Output
            // 
            txt_Output.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Output.Location = new Point(201, 414);
            txt_Output.Name = "txt_Output";
            txt_Output.Size = new Size(375, 31);
            txt_Output.TabIndex = 8;
            // 
            // btn_ref
            // 
            btn_ref.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ref.Location = new Point(590, 414);
            btn_ref.Name = "btn_ref";
            btn_ref.Size = new Size(94, 31);
            btn_ref.TabIndex = 9;
            btn_ref.Text = "Refresh";
            btn_ref.UseVisualStyleBackColor = true;
            btn_ref.Click += btn_ref_Click;
            // 
            // FormBT8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(btn_ref);
            Controls.Add(txt_Output);
            Controls.Add(label2);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Rand);
            Controls.Add(btn_Add);
            Controls.Add(txt_Display);
            Controls.Add(txt_Input);
            Controls.Add(label1);
            Name = "FormBT8";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Input;
        private TextBox txt_Display;
        private Button btn_Add;
        private Button btn_Rand;
        private Button btn_Exit;
        private Button btn_Delete;
        private Label label2;
        private TextBox txt_Output;
        private Button btn_ref;
    }
}