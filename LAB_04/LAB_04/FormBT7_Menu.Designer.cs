namespace LAB_04
{
    partial class FormBT7_Menu
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
            button_AddFood = new Button();
            button_FindRand = new Button();
            panel2 = new Panel();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            lb_welcome = new Label();
            label4 = new Label();
            cb_crPage = new ComboBox();
            label5 = new Label();
            cb_pageSize = new ComboBox();
            tabControl_Menu = new TabControl();
            tabPage1 = new TabPage();
            flowLayoutPanel_All = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowLayoutPanel_MyAdd = new FlowLayoutPanel();
            btn_Search = new Button();
            panel2.SuspendLayout();
            tabControl_Menu.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 2;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // button_AddFood
            // 
            button_AddFood.BackColor = Color.White;
            button_AddFood.FlatStyle = FlatStyle.Flat;
            button_AddFood.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddFood.Location = new Point(593, 63);
            button_AddFood.Name = "button_AddFood";
            button_AddFood.Size = new Size(195, 42);
            button_AddFood.TabIndex = 3;
            button_AddFood.Text = "Thêm món ăn";
            button_AddFood.UseVisualStyleBackColor = false;
            button_AddFood.Click += button_AddFood_Click;
            // 
            // button_FindRand
            // 
            button_FindRand.BackColor = Color.White;
            button_FindRand.FlatStyle = FlatStyle.Flat;
            button_FindRand.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_FindRand.Location = new Point(381, 63);
            button_FindRand.Name = "button_FindRand";
            button_FindRand.Size = new Size(195, 42);
            button_FindRand.TabIndex = 4;
            button_FindRand.Text = "Ăn gì giờ?";
            button_FindRand.UseVisualStyleBackColor = false;
            button_FindRand.Click += button_FindRand_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(lb_welcome);
            panel2.Location = new Point(0, 763);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 43);
            panel2.TabIndex = 7;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(246, 11);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(138, 19);
            progressBar1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 8);
            label3.Name = "label3";
            label3.Size = new Size(16, 23);
            label3.TabIndex = 2;
            label3.Text = "|";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(158, 10);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log out";
            // 
            // lb_welcome
            // 
            lb_welcome.AutoSize = true;
            lb_welcome.Location = new Point(12, 11);
            lb_welcome.Name = "lb_welcome";
            lb_welcome.Size = new Size(107, 20);
            lb_welcome.TabIndex = 0;
            lb_welcome.Text = "Welcome, User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 727);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "Page";
            // 
            // cb_crPage
            // 
            cb_crPage.FormattingEnabled = true;
            cb_crPage.Location = new Point(511, 719);
            cb_crPage.Name = "cb_crPage";
            cb_crPage.Size = new Size(46, 28);
            cb_crPage.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(563, 727);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Page Size";
            // 
            // cb_pageSize
            // 
            cb_pageSize.FormattingEnabled = true;
            cb_pageSize.Location = new Point(641, 719);
            cb_pageSize.Name = "cb_pageSize";
            cb_pageSize.Size = new Size(46, 28);
            cb_pageSize.TabIndex = 11;
            // 
            // tabControl_Menu
            // 
            tabControl_Menu.Controls.Add(tabPage1);
            tabControl_Menu.Controls.Add(tabPage2);
            tabControl_Menu.Location = new Point(12, 111);
            tabControl_Menu.Name = "tabControl_Menu";
            tabControl_Menu.SelectedIndex = 0;
            tabControl_Menu.Size = new Size(776, 602);
            tabControl_Menu.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowLayoutPanel_All);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 569);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_All
            // 
            flowLayoutPanel_All.AutoScroll = true;
            flowLayoutPanel_All.Dock = DockStyle.Fill;
            flowLayoutPanel_All.Location = new Point(3, 3);
            flowLayoutPanel_All.Name = "flowLayoutPanel_All";
            flowLayoutPanel_All.Size = new Size(762, 563);
            flowLayoutPanel_All.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel_MyAdd);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 569);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tôi đóng góp";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_MyAdd
            // 
            flowLayoutPanel_MyAdd.AutoScroll = true;
            flowLayoutPanel_MyAdd.Dock = DockStyle.Fill;
            flowLayoutPanel_MyAdd.Location = new Point(3, 3);
            flowLayoutPanel_MyAdd.Name = "flowLayoutPanel_MyAdd";
            flowLayoutPanel_MyAdd.Size = new Size(762, 563);
            flowLayoutPanel_MyAdd.TabIndex = 0;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.White;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(709, 719);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(72, 28);
            btn_Search.TabIndex = 13;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // FormBT7_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 806);
            Controls.Add(btn_Search);
            Controls.Add(tabControl_Menu);
            Controls.Add(cb_pageSize);
            Controls.Add(label5);
            Controls.Add(cb_crPage);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(button_FindRand);
            Controls.Add(button_AddFood);
            Controls.Add(label1);
            Name = "FormBT7_Menu";
            Text = "Hôm nay ăn gì?";
            Load += FormBT7_Menu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl_Menu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_AddFood;
        private Button button_FindRand;
        private Panel panel2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label lb_welcome;
        private ProgressBar progressBar1;
        private Label label4;
        private ComboBox cb_crPage;
        private Label label5;
        private ComboBox cb_pageSize;
        private TabControl tabControl_Menu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel_All;
        private FlowLayoutPanel flowLayoutPanel_MyAdd;
        private Button btn_Search;
    }
}