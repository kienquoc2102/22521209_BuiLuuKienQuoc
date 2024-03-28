namespace LAB_02
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
            label1 = new Label();
            txt_Food = new TextBox();
            btn_Add = new Button();
            label2 = new Label();
            txt_Name = new TextBox();
            dataGridView_DisplayFood = new DataGridView();
            btn_Random = new Button();
            btn_Exit = new Button();
            text_DisplayFood = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DisplayFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 0;
            label1.Text = "Món ăn";
            // 
            // txt_Food
            // 
            txt_Food.Location = new Point(97, 26);
            txt_Food.Name = "txt_Food";
            txt_Food.Size = new Size(264, 27);
            txt_Food.TabIndex = 1;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(153, 117);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(208, 37);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên quán";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(97, 70);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(264, 27);
            txt_Name.TabIndex = 4;
            // 
            // dataGridView_DisplayFood
            // 
            dataGridView_DisplayFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DisplayFood.Location = new Point(378, 26);
            dataGridView_DisplayFood.Name = "dataGridView_DisplayFood";
            dataGridView_DisplayFood.RowHeadersWidth = 51;
            dataGridView_DisplayFood.Size = new Size(410, 299);
            dataGridView_DisplayFood.TabIndex = 5;
            // 
            // btn_Random
            // 
            btn_Random.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Random.Location = new Point(12, 349);
            btn_Random.Name = "btn_Random";
            btn_Random.Size = new Size(349, 44);
            btn_Random.TabIndex = 6;
            btn_Random.Text = "Tìm món ăn";
            btn_Random.UseVisualStyleBackColor = true;
            btn_Random.Click += btn_Random_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(378, 349);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(410, 44);
            btn_Exit.TabIndex = 8;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // text_DisplayFood
            // 
            text_DisplayFood.BackColor = Color.White;
            text_DisplayFood.Enabled = false;
            text_DisplayFood.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_DisplayFood.Location = new Point(214, 465);
            text_DisplayFood.Multiline = true;
            text_DisplayFood.Name = "text_DisplayFood";
            text_DisplayFood.Size = new Size(364, 102);
            text_DisplayFood.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(315, 439);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 10;
            label3.Text = "Món ăn hôm nay là ";
            // 
            // FormBT6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(label3);
            Controls.Add(text_DisplayFood);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Random);
            Controls.Add(dataGridView_DisplayFood);
            Controls.Add(txt_Name);
            Controls.Add(label2);
            Controls.Add(btn_Add);
            Controls.Add(txt_Food);
            Controls.Add(label1);
            Name = "FormBT6";
            Text = "Bài 06 – Hôm nay ăn gì?";
            ((System.ComponentModel.ISupportInitialize)dataGridView_DisplayFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Food;
        private Button btn_Add;
        private Label label2;
        private TextBox txt_Name;
        private DataGridView dataGridView_DisplayFood;
        private Button btn_Random;
        private Button btn_Exit;
        private TextBox text_DisplayFood;
        private Label label3;
    }
}