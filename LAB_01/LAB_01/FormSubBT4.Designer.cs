namespace LAB_01
{
    partial class FormSubBT4
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
            display_name = new TextBox();
            label3 = new Label();
            display_film = new TextBox();
            display_room = new TextBox();
            label4 = new Label();
            label5 = new Label();
            display_ticket = new TextBox();
            label6 = new Label();
            display_seat = new TextBox();
            label7 = new Label();
            display_total = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 24);
            label1.Name = "label1";
            label1.Size = new Size(207, 50);
            label1.TabIndex = 0;
            label1.Text = "U_CINEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // display_name
            // 
            display_name.BackColor = Color.White;
            display_name.Enabled = false;
            display_name.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_name.Location = new Point(141, 83);
            display_name.Name = "display_name";
            display_name.Size = new Size(359, 31);
            display_name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 143);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Phim ";
            // 
            // display_film
            // 
            display_film.BackColor = Color.White;
            display_film.Enabled = false;
            display_film.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_film.Location = new Point(141, 137);
            display_film.Name = "display_film";
            display_film.Size = new Size(359, 31);
            display_film.TabIndex = 4;
            // 
            // display_room
            // 
            display_room.BackColor = Color.White;
            display_room.Enabled = false;
            display_room.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_room.Location = new Point(141, 195);
            display_room.Name = "display_room";
            display_room.Size = new Size(359, 31);
            display_room.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 201);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 6;
            label4.Text = "Phòng chiếu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 258);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 7;
            label5.Text = "Loại vé";
            // 
            // display_ticket
            // 
            display_ticket.BackColor = Color.White;
            display_ticket.Enabled = false;
            display_ticket.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_ticket.Location = new Point(141, 252);
            display_ticket.Name = "display_ticket";
            display_ticket.Size = new Size(359, 31);
            display_ticket.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 311);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 9;
            label6.Text = "Chỗ ngồi";
            // 
            // display_seat
            // 
            display_seat.BackColor = Color.White;
            display_seat.Enabled = false;
            display_seat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_seat.Location = new Point(141, 305);
            display_seat.Name = "display_seat";
            display_seat.Size = new Size(359, 31);
            display_seat.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 367);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 11;
            label7.Text = "Tổng tiền";
            // 
            // display_total
            // 
            display_total.BackColor = Color.White;
            display_total.Enabled = false;
            display_total.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_total.Location = new Point(141, 361);
            display_total.Name = "display_total";
            display_total.Size = new Size(359, 31);
            display_total.TabIndex = 12;
            // 
            // FormSubBT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 444);
            Controls.Add(display_total);
            Controls.Add(label7);
            Controls.Add(display_seat);
            Controls.Add(label6);
            Controls.Add(display_ticket);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(display_room);
            Controls.Add(display_film);
            Controls.Add(label3);
            Controls.Add(display_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSubBT4";
            Text = "Vé xem phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox display_name;
        private Label label3;
        private TextBox display_film;
        private TextBox display_room;
        private Label label4;
        private Label label5;
        private TextBox display_ticket;
        private Label label6;
        private TextBox display_seat;
        private Label label7;
        private TextBox display_total;
    }
}