namespace LAB_05
{
    partial class FormBT5_Food
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
            panel1 = new Panel();
            label_price = new Label();
            label_contrib = new Label();
            label_addr = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_food = new Label();
            pictureBox_food = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_food).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label_price);
            panel1.Controls.Add(label_contrib);
            panel1.Controls.Add(label_addr);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_food);
            panel1.Controls.Add(pictureBox_food);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 134);
            panel1.TabIndex = 0;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(305, 111);
            label_price.Name = "label_price";
            label_price.Size = new Size(36, 20);
            label_price.TabIndex = 16;
            label_price.Text = "Text";
            // 
            // label_contrib
            // 
            label_contrib.AutoSize = true;
            label_contrib.Location = new Point(305, 80);
            label_contrib.Name = "label_contrib";
            label_contrib.Size = new Size(36, 20);
            label_contrib.TabIndex = 15;
            label_contrib.Text = "Text";
            // 
            // label_addr
            // 
            label_addr.AutoSize = true;
            label_addr.Location = new Point(305, 48);
            label_addr.Name = "label_addr";
            label_addr.Size = new Size(36, 20);
            label_addr.TabIndex = 14;
            label_addr.Text = "Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 111);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 13;
            label3.Text = "Giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 12;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 80);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 11;
            label1.Text = "Người đóng góp:";
            // 
            // label_food
            // 
            label_food.AutoSize = true;
            label_food.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_food.Location = new Point(173, 0);
            label_food.Name = "label_food";
            label_food.Size = new Size(138, 31);
            label_food.TabIndex = 10;
            label_food.Text = "Tên món ăn";
            // 
            // pictureBox_food
            // 
            pictureBox_food.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_food.Location = new Point(0, -1);
            pictureBox_food.Name = "pictureBox_food";
            pictureBox_food.Size = new Size(167, 134);
            pictureBox_food.TabIndex = 9;
            pictureBox_food.TabStop = false;
            // 
            // FormBT5_Food
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 158);
            Controls.Add(panel1);
            Name = "FormBT5_Food";
            Text = "FormBT5_Food";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_food).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_price;
        private Label label_contrib;
        private Label label_addr;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label_food;
        private PictureBox pictureBox_food;
    }
}