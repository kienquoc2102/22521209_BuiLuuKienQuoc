namespace LAB_04
{
    partial class FormBT7_AddFood
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
            label5 = new Label();
            label6 = new Label();
            txt_food = new TextBox();
            txt_price = new TextBox();
            txt_addr = new TextBox();
            txt_img = new TextBox();
            txt_desc = new TextBox();
            btn_clear = new Button();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 1;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 3;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 5;
            label5.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 6;
            label6.Text = "Mô tả";
            // 
            // txt_food
            // 
            txt_food.Location = new Point(104, 80);
            txt_food.Name = "txt_food";
            txt_food.Size = new Size(537, 27);
            txt_food.TabIndex = 7;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(104, 121);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(537, 27);
            txt_price.TabIndex = 8;
            // 
            // txt_addr
            // 
            txt_addr.Location = new Point(104, 162);
            txt_addr.Name = "txt_addr";
            txt_addr.Size = new Size(537, 27);
            txt_addr.TabIndex = 9;
            // 
            // txt_img
            // 
            txt_img.Location = new Point(104, 208);
            txt_img.Name = "txt_img";
            txt_img.Size = new Size(537, 27);
            txt_img.TabIndex = 10;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(104, 253);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(537, 165);
            txt_desc.TabIndex = 11;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.Location = new Point(298, 434);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(160, 36);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.White;
            btn_submit.FlatStyle = FlatStyle.Flat;
            btn_submit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_submit.Location = new Point(481, 434);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(160, 36);
            btn_submit.TabIndex = 12;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // FormBT7_AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 494);
            Controls.Add(btn_clear);
            Controls.Add(btn_submit);
            Controls.Add(txt_desc);
            Controls.Add(txt_img);
            Controls.Add(txt_addr);
            Controls.Add(txt_price);
            Controls.Add(txt_food);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT7_AddFood";
            Text = "Thêm món ăn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_food;
        private TextBox txt_price;
        private TextBox txt_addr;
        private TextBox txt_img;
        private TextBox txt_desc;
        private Button btn_clear;
        private Button btn_submit;
    }
}