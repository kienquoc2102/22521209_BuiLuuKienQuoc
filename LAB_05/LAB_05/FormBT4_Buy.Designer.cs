namespace LAB_05
{
    partial class FormBT4_Buy
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
            pictureBox_film = new PictureBox();
            label_name = new Label();
            label2 = new Label();
            comboBox_Rooms = new ComboBox();
            panel_Seats = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_nameclient = new TextBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            button1 = new Button();
            btn_Buy = new Button();
            label_room = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_film).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_film
            // 
            pictureBox_film.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_film.Location = new Point(12, 12);
            pictureBox_film.Name = "pictureBox_film";
            pictureBox_film.Size = new Size(226, 154);
            pictureBox_film.TabIndex = 0;
            pictureBox_film.TabStop = false;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.Location = new Point(244, 12);
            label_name.Name = "label_name";
            label_name.Size = new Size(128, 50);
            label_name.TabIndex = 1;
            label_name.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 2;
            label2.Text = "Phòng chiếu phim";
            // 
            // comboBox_Rooms
            // 
            comboBox_Rooms.FormattingEnabled = true;
            comboBox_Rooms.Location = new Point(146, 189);
            comboBox_Rooms.Name = "comboBox_Rooms";
            comboBox_Rooms.Size = new Size(892, 28);
            comboBox_Rooms.TabIndex = 3;
            comboBox_Rooms.SelectedIndexChanged += comboBox_Rooms_SelectedIndexChanged;
            // 
            // panel_Seats
            // 
            panel_Seats.BorderStyle = BorderStyle.FixedSingle;
            panel_Seats.Location = new Point(12, 256);
            panel_Seats.Name = "panel_Seats";
            panel_Seats.Size = new Size(1026, 363);
            panel_Seats.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "Ghế ngồi: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 633);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 6;
            label4.Text = "Thông tin liên hệ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 670);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 7;
            label5.Text = "Họ và tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 705);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 8;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 737);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 9;
            label7.Text = "Số điện thoại";
            // 
            // txt_nameclient
            // 
            txt_nameclient.Location = new Point(115, 663);
            txt_nameclient.Name = "txt_nameclient";
            txt_nameclient.Size = new Size(921, 27);
            txt_nameclient.TabIndex = 10;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(115, 698);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(921, 27);
            txt_email.TabIndex = 11;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(115, 730);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(921, 27);
            txt_phone.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(891, 776);
            button1.Name = "button1";
            button1.Size = new Size(145, 41);
            button1.TabIndex = 13;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Buy
            // 
            btn_Buy.BackColor = Color.White;
            btn_Buy.FlatStyle = FlatStyle.Flat;
            btn_Buy.Location = new Point(740, 776);
            btn_Buy.Name = "btn_Buy";
            btn_Buy.Size = new Size(145, 41);
            btn_Buy.TabIndex = 14;
            btn_Buy.Text = "Mua vé";
            btn_Buy.UseVisualStyleBackColor = false;
            btn_Buy.Click += btn_Buy_Click;
            // 
            // label_room
            // 
            label_room.AutoSize = true;
            label_room.Location = new Point(87, 233);
            label_room.Name = "label_room";
            label_room.Size = new Size(50, 20);
            label_room.TabIndex = 15;
            label_room.Text = "label1";
            // 
            // FormBT4_Buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 836);
            Controls.Add(label_room);
            Controls.Add(btn_Buy);
            Controls.Add(button1);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_nameclient);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel_Seats);
            Controls.Add(comboBox_Rooms);
            Controls.Add(label2);
            Controls.Add(label_name);
            Controls.Add(pictureBox_film);
            Name = "FormBT4_Buy";
            Text = "FormBT4_Buy";
            ((System.ComponentModel.ISupportInitialize)pictureBox_film).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_film;
        private Label label_name;
        private Label label2;
        private ComboBox comboBox_Rooms;
        private Panel panel_Seats;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_nameclient;
        private TextBox txt_email;
        private TextBox txt_phone;
        private Button button1;
        private Button btn_Buy;
        private Label label_room;
    }
}