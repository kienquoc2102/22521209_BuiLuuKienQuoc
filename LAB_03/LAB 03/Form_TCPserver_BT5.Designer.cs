namespace LAB_03
{
    partial class Form_TCPserver_BT5
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
            dG_DisplayFood = new DataGridView();
            btn_Listen = new Button();
            ((System.ComponentModel.ISupportInitialize)dG_DisplayFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // dG_DisplayFood
            // 
            dG_DisplayFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG_DisplayFood.Location = new Point(12, 66);
            dG_DisplayFood.Name = "dG_DisplayFood";
            dG_DisplayFood.RowHeadersWidth = 51;
            dG_DisplayFood.Size = new Size(611, 454);
            dG_DisplayFood.TabIndex = 1;
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.White;
            btn_Listen.FlatStyle = FlatStyle.Flat;
            btn_Listen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(438, 526);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(185, 46);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Form_TCPserver_BT5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 597);
            Controls.Add(btn_Listen);
            Controls.Add(dG_DisplayFood);
            Controls.Add(label1);
            Name = "Form_TCPserver_BT5";
            Text = "Form_TCPserver_BT5";
            ((System.ComponentModel.ISupportInitialize)dG_DisplayFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dG_DisplayFood;
        private Button btn_Listen;
    }
}