namespace LAB_03
{
    partial class Form_TCPclient_BT5
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
            txt_Food = new TextBox();
            txt_Name = new TextBox();
            btn_Add = new Button();
            btn_Random = new Button();
            btn_Exit = new Button();
            txt_DisplayFood = new TextBox();
            label3 = new Label();
            lb_DisplayFood = new ListBox();
            btn_Connect = new Button();
            label4 = new Label();
            txt_userName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 0;
            label1.Text = "Món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên quán";
            // 
            // txt_Food
            // 
            txt_Food.Location = new Point(98, 71);
            txt_Food.Name = "txt_Food";
            txt_Food.Size = new Size(251, 27);
            txt_Food.TabIndex = 2;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(98, 104);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(251, 27);
            txt_Name.TabIndex = 3;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.Location = new Point(179, 156);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(170, 45);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Random
            // 
            btn_Random.BackColor = Color.White;
            btn_Random.FlatStyle = FlatStyle.Flat;
            btn_Random.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Random.Location = new Point(12, 373);
            btn_Random.Name = "btn_Random";
            btn_Random.Size = new Size(355, 52);
            btn_Random.TabIndex = 6;
            btn_Random.Text = "Tìm món ăn";
            btn_Random.UseVisualStyleBackColor = false;
            btn_Random.Click += btn_Random_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.White;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(608, 373);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(180, 52);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // txt_DisplayFood
            // 
            txt_DisplayFood.BackColor = Color.White;
            txt_DisplayFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DisplayFood.Location = new Point(231, 486);
            txt_DisplayFood.Multiline = true;
            txt_DisplayFood.Name = "txt_DisplayFood";
            txt_DisplayFood.Size = new Size(333, 50);
            txt_DisplayFood.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 460);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 9;
            label3.Text = "Món ăn hôm nay";
            // 
            // lb_DisplayFood
            // 
            lb_DisplayFood.FormattingEnabled = true;
            lb_DisplayFood.Location = new Point(367, 23);
            lb_DisplayFood.Name = "lb_DisplayFood";
            lb_DisplayFood.Size = new Size(421, 324);
            lb_DisplayFood.TabIndex = 10;
            // 
            // btn_Connect
            // 
            btn_Connect.BackColor = Color.White;
            btn_Connect.FlatStyle = FlatStyle.Flat;
            btn_Connect.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Connect.Location = new Point(422, 373);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(180, 52);
            btn_Connect.TabIndex = 11;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 39);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 12;
            label4.Text = "User";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(98, 35);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(251, 27);
            txt_userName.TabIndex = 13;
            // 
            // Form_TCPclient_BT5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(txt_userName);
            Controls.Add(label4);
            Controls.Add(btn_Connect);
            Controls.Add(lb_DisplayFood);
            Controls.Add(label3);
            Controls.Add(txt_DisplayFood);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Random);
            Controls.Add(btn_Add);
            Controls.Add(txt_Name);
            Controls.Add(txt_Food);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_TCPclient_BT5";
            Text = "Form_TCPclient_BT5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Food;
        private TextBox txt_Name;
        private Button btn_Add;
        private Button btn_Random;
        private Button btn_Exit;
        private TextBox txt_DisplayFood;
        private Label label3;
        private ListBox lb_DisplayFood;
        private Button btn_Connect;
        private Label label4;
        private TextBox txt_userName;
    }
}