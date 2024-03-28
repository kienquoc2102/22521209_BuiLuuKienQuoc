namespace LAB_02
{
    partial class FormBT5
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
            text_Name = new TextBox();
            cb_ListFilm = new ComboBox();
            cb_ListRoom = new ComboBox();
            cb_List_TypeTicket = new ComboBox();
            cb_ListSeat = new ComboBox();
            buttonBuy = new Button();
            buttonStatis = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 1;
            label2.Text = "Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Phòng Chiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 3;
            label4.Text = "Loại vé";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 4;
            label5.Text = "Ghế ngồi";
            // 
            // text_Name
            // 
            text_Name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_Name.Location = new Point(135, 30);
            text_Name.Name = "text_Name";
            text_Name.Size = new Size(653, 30);
            text_Name.TabIndex = 5;
            // 
            // cb_ListFilm
            // 
            cb_ListFilm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_ListFilm.FormattingEnabled = true;
            cb_ListFilm.Location = new Point(135, 78);
            cb_ListFilm.Name = "cb_ListFilm";
            cb_ListFilm.Size = new Size(653, 31);
            cb_ListFilm.TabIndex = 6;
            cb_ListFilm.SelectedIndexChanged += cb_ListFilm_SelectedIndexChanged;
            // 
            // cb_ListRoom
            // 
            cb_ListRoom.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_ListRoom.FormattingEnabled = true;
            cb_ListRoom.Location = new Point(135, 127);
            cb_ListRoom.Name = "cb_ListRoom";
            cb_ListRoom.Size = new Size(653, 31);
            cb_ListRoom.TabIndex = 7;
            // 
            // cb_List_TypeTicket
            // 
            cb_List_TypeTicket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_List_TypeTicket.FormattingEnabled = true;
            cb_List_TypeTicket.Location = new Point(135, 182);
            cb_List_TypeTicket.Name = "cb_List_TypeTicket";
            cb_List_TypeTicket.Size = new Size(653, 31);
            cb_List_TypeTicket.TabIndex = 8;
            cb_List_TypeTicket.SelectedIndexChanged += cb_List_TypeTicket_SelectedIndexChanged;
            // 
            // cb_ListSeat
            // 
            cb_ListSeat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_ListSeat.FormattingEnabled = true;
            cb_ListSeat.Location = new Point(135, 239);
            cb_ListSeat.Name = "cb_ListSeat";
            cb_ListSeat.Size = new Size(653, 31);
            cb_ListSeat.TabIndex = 9;
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(12, 312);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(384, 54);
            buttonBuy.TabIndex = 10;
            buttonBuy.Text = "Mua vé";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonStatis
            // 
            buttonStatis.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStatis.Location = new Point(402, 312);
            buttonStatis.Name = "buttonStatis";
            buttonStatis.Size = new Size(213, 54);
            buttonStatis.TabIndex = 11;
            buttonStatis.Text = "Thống kê";
            buttonStatis.UseVisualStyleBackColor = true;
            buttonStatis.Click += buttonStatis_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(621, 312);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(167, 54);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormBT5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonStatis);
            Controls.Add(buttonBuy);
            Controls.Add(cb_ListSeat);
            Controls.Add(cb_List_TypeTicket);
            Controls.Add(cb_ListRoom);
            Controls.Add(cb_ListFilm);
            Controls.Add(text_Name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT5";
            Text = "Bài 05 – Quản lý phòng vé (phiên bản số 2)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox text_Name;
        private ComboBox cb_ListFilm;
        private ComboBox cb_ListRoom;
        private ComboBox cb_List_TypeTicket;
        private ComboBox cb_ListSeat;
        private Button buttonBuy;
        private Button buttonStatis;
        private Button buttonExit;
    }
}