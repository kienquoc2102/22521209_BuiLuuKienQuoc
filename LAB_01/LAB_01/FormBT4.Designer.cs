namespace LAB_01
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
            label1 = new Label();
            txt_Name = new TextBox();
            label2 = new Label();
            list_Film = new ComboBox();
            label3 = new Label();
            list_Room = new ComboBox();
            label4 = new Label();
            type_Ticket = new ComboBox();
            label5 = new Label();
            type_Seat = new ComboBox();
            btn_Enter = new Button();
            btn_Exit = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Name.Location = new Point(149, 31);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(604, 31);
            txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Phim ";
            // 
            // list_Film
            // 
            list_Film.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            list_Film.FormattingEnabled = true;
            list_Film.Location = new Point(149, 76);
            list_Film.Name = "list_Film";
            list_Film.Size = new Size(604, 33);
            list_Film.TabIndex = 3;
            list_Film.SelectedValueChanged += list_Film_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 132);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 4;
            label3.Text = "Phòng chiếu";
            // 
            // list_Room
            // 
            list_Room.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            list_Room.FormattingEnabled = true;
            list_Room.Location = new Point(149, 124);
            list_Room.Name = "list_Room";
            list_Room.Size = new Size(604, 33);
            list_Room.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 187);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 6;
            label4.Text = "Loại vé";
            // 
            // type_Ticket
            // 
            type_Ticket.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_Ticket.FormattingEnabled = true;
            type_Ticket.Location = new Point(149, 179);
            type_Ticket.Name = "type_Ticket";
            type_Ticket.Size = new Size(604, 33);
            type_Ticket.TabIndex = 7;
            type_Ticket.SelectedValueChanged += type_Ticket_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 238);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 8;
            label5.Text = "Chọn chỗ";
            // 
            // type_Seat
            // 
            type_Seat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_Seat.FormattingEnabled = true;
            type_Seat.Location = new Point(149, 230);
            type_Seat.Name = "type_Seat";
            type_Seat.Size = new Size(604, 33);
            type_Seat.TabIndex = 9;
            // 
            // btn_Enter
            // 
            btn_Enter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Enter.Location = new Point(23, 295);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(476, 71);
            btn_Enter.TabIndex = 10;
            btn_Enter.Text = "MUA VÉ";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(505, 295);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(248, 71);
            btn_Exit.TabIndex = 11;
            btn_Exit.Text = "THOÁT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 177);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            // 
            // FormBT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 458);
            Controls.Add(label6);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Enter);
            Controls.Add(type_Seat);
            Controls.Add(label5);
            Controls.Add(type_Ticket);
            Controls.Add(label4);
            Controls.Add(list_Room);
            Controls.Add(label3);
            Controls.Add(list_Film);
            Controls.Add(label2);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            Name = "FormBT4";
            Text = "Bài tập 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Name;
        private Label label2;
        private ComboBox list_Film;
        private Label label3;
        private ComboBox list_Room;
        private Label label4;
        private ComboBox type_Ticket;
        private Label label5;
        private Button btn_Enter;
        private Button btn_Exit;
        private Label label6;
        private ComboBox type_Seat;
    }
}