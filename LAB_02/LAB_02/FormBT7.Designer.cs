namespace LAB_02
{
    partial class FormBT7
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
            treeView = new TreeView();
            label1 = new Label();
            pictureBox = new PictureBox();
            textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(321, 507);
            treeView.TabIndex = 0;
            treeView.BeforeExpand += treeView_BeforeExpand;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 2;
            label1.Text = "File Content";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(339, 45);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(491, 474);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Visible = false;
            // 
            // textBox
            // 
            textBox.Location = new Point(339, 45);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(491, 474);
            textBox.TabIndex = 4;
            textBox.Visible = false;
            // 
            // FormBT7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 531);
            Controls.Add(textBox);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            Controls.Add(treeView);
            Name = "FormBT7";
            Text = "FormBT7";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView;
        private Label label1;
        private PictureBox pictureBox;
        private TextBox textBox;
    }
}