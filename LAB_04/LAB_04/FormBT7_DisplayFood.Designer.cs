namespace LAB_04
{
    partial class FormBT7_DisplayFood
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
            pn_display = new Panel();
            lb_price = new Label();
            lb_addr = new Label();
            lb_contributor = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lb_food = new Label();
            pictureBox_food = new PictureBox();
            pn_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_food).BeginInit();
            SuspendLayout();
            // 
            // pn_display
            // 
            pn_display.Controls.Add(lb_price);
            pn_display.Controls.Add(lb_addr);
            pn_display.Controls.Add(lb_contributor);
            pn_display.Controls.Add(label4);
            pn_display.Controls.Add(label3);
            pn_display.Controls.Add(label2);
            pn_display.Controls.Add(lb_food);
            pn_display.Controls.Add(pictureBox_food);
            pn_display.ForeColor = Color.Black;
            pn_display.Location = new Point(12, 12);
            pn_display.Name = "pn_display";
            pn_display.Size = new Size(734, 154);
            pn_display.TabIndex = 0;
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new Point(287, 51);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(50, 20);
            lb_price.TabIndex = 7;
            lb_price.Text = "label7";
            // 
            // lb_addr
            // 
            lb_addr.AutoSize = true;
            lb_addr.Location = new Point(287, 82);
            lb_addr.Name = "lb_addr";
            lb_addr.Size = new Size(50, 20);
            lb_addr.TabIndex = 6;
            lb_addr.Text = "label6";
            // 
            // lb_contributor
            // 
            lb_contributor.AutoSize = true;
            lb_contributor.Location = new Point(287, 114);
            lb_contributor.Name = "lb_contributor";
            lb_contributor.Size = new Size(50, 20);
            lb_contributor.TabIndex = 5;
            lb_contributor.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 114);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Đóng góp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 82);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 51);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "Giá:";
            // 
            // lb_food
            // 
            lb_food.AutoSize = true;
            lb_food.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_food.ForeColor = Color.LimeGreen;
            lb_food.Location = new Point(201, 9);
            lb_food.Name = "lb_food";
            lb_food.Size = new Size(79, 31);
            lb_food.TabIndex = 1;
            lb_food.Text = "label1";
            // 
            // pictureBox_food
            // 
            pictureBox_food.Location = new Point(0, 0);
            pictureBox_food.Name = "pictureBox_food";
            pictureBox_food.Size = new Size(195, 154);
            pictureBox_food.TabIndex = 0;
            pictureBox_food.TabStop = false;
            // 
            // FormBT7_DisplayFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 178);
            Controls.Add(pn_display);
            Name = "FormBT7_DisplayFood";
            Text = "FormBT7_RandFood";
            pn_display.ResumeLayout(false);
            pn_display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_food).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_display;
        private Label lb_price;
        private Label lb_addr;
        private Label lb_contributor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lb_food;
        private PictureBox pictureBox_food;
    }
}