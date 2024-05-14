namespace LAB_03
{
    partial class Form_TCPclient_BT4
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cb_listFilm = new ComboBox();
            cb_room = new ComboBox();
            cb_typeTicket = new ComboBox();
            cb_Seat = new ComboBox();
            btn_Buy = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(129, 53);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(570, 27);
            txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 2;
            label2.Text = "Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 3;
            label3.Text = "Phòng Chiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 4;
            label4.Text = "Loại vé";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 5;
            label5.Text = "Ghế ngồi";
            // 
            // cb_listFilm
            // 
            cb_listFilm.FormattingEnabled = true;
            cb_listFilm.Location = new Point(129, 102);
            cb_listFilm.Name = "cb_listFilm";
            cb_listFilm.Size = new Size(570, 28);
            cb_listFilm.TabIndex = 6;
            // 
            // cb_room
            // 
            cb_room.FormattingEnabled = true;
            cb_room.Location = new Point(129, 150);
            cb_room.Name = "cb_room";
            cb_room.Size = new Size(570, 28);
            cb_room.TabIndex = 7;
            // 
            // cb_typeTicket
            // 
            cb_typeTicket.FormattingEnabled = true;
            cb_typeTicket.Location = new Point(129, 198);
            cb_typeTicket.Name = "cb_typeTicket";
            cb_typeTicket.Size = new Size(570, 28);
            cb_typeTicket.TabIndex = 8;
            // 
            // cb_Seat
            // 
            cb_Seat.FormattingEnabled = true;
            cb_Seat.Location = new Point(129, 248);
            cb_Seat.Name = "cb_Seat";
            cb_Seat.Size = new Size(570, 28);
            cb_Seat.TabIndex = 9;
            // 
            // btn_Buy
            // 
            btn_Buy.BackColor = Color.White;
            btn_Buy.FlatStyle = FlatStyle.Flat;
            btn_Buy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Buy.Location = new Point(12, 306);
            btn_Buy.Name = "btn_Buy";
            btn_Buy.Size = new Size(315, 50);
            btn_Buy.TabIndex = 10;
            btn_Buy.Text = "Mua vé";
            btn_Buy.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.White;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(492, 306);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(207, 50);
            btn_Exit.TabIndex = 11;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = false;
            // 
            // Form_TCPclient_BT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 415);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Buy);
            Controls.Add(cb_Seat);
            Controls.Add(cb_typeTicket);
            Controls.Add(cb_room);
            Controls.Add(cb_listFilm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            Name = "Form_TCPclient_BT4";
            Text = "Form_TCPclient_BT4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cb_listFilm;
        private ComboBox cb_room;
        private ComboBox cb_typeTicket;
        private ComboBox cb_Seat;
        private Button btn_Buy;
        private Button btn_Exit;
    }
}