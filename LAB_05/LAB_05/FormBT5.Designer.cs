namespace LAB_05
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
            btn_Exit = new Button();
            btn_RandomFind = new Button();
            label1 = new Label();
            panel_Menu = new Panel();
            btn_Reload = new Button();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.White;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(555, 690);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(161, 44);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_RandomFind
            // 
            btn_RandomFind.BackColor = Color.White;
            btn_RandomFind.FlatStyle = FlatStyle.Flat;
            btn_RandomFind.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RandomFind.Location = new Point(388, 690);
            btn_RandomFind.Name = "btn_RandomFind";
            btn_RandomFind.Size = new Size(161, 44);
            btn_RandomFind.TabIndex = 1;
            btn_RandomFind.Text = "Tìm ngẫu nhiên";
            btn_RandomFind.UseVisualStyleBackColor = false;
            btn_RandomFind.Click += btn_RandomFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 2;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // panel_Menu
            // 
            panel_Menu.AutoScroll = true;
            panel_Menu.BackColor = Color.White;
            panel_Menu.BorderStyle = BorderStyle.FixedSingle;
            panel_Menu.Location = new Point(12, 67);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(704, 617);
            panel_Menu.TabIndex = 3;
            // 
            // btn_Reload
            // 
            btn_Reload.BackColor = Color.White;
            btn_Reload.FlatStyle = FlatStyle.Flat;
            btn_Reload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Reload.Location = new Point(12, 690);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(104, 44);
            btn_Reload.TabIndex = 4;
            btn_Reload.Text = "Refresh";
            btn_Reload.UseVisualStyleBackColor = false;
            btn_Reload.Click += btn_Reload_Click;
            // 
            // FormBT5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 746);
            Controls.Add(btn_Reload);
            Controls.Add(panel_Menu);
            Controls.Add(label1);
            Controls.Add(btn_RandomFind);
            Controls.Add(btn_Exit);
            Name = "FormBT5";
            Text = "Hôm nay ăn gì?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Exit;
        private Button btn_RandomFind;
        private Label label1;
        private Panel panel_Menu;
        private Button btn_Reload;
    }
}