namespace LAB_04
{
    partial class FormBT2
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
            txt_URL = new TextBox();
            txt_filePath = new TextBox();
            btn_Download = new Button();
            richTextBox_Display = new RichTextBox();
            SuspendLayout();
            // 
            // txt_URL
            // 
            txt_URL.BorderStyle = BorderStyle.FixedSingle;
            txt_URL.Location = new Point(12, 12);
            txt_URL.Name = "txt_URL";
            txt_URL.Size = new Size(478, 27);
            txt_URL.TabIndex = 0;
            // 
            // txt_filePath
            // 
            txt_filePath.BorderStyle = BorderStyle.FixedSingle;
            txt_filePath.Location = new Point(12, 54);
            txt_filePath.Name = "txt_filePath";
            txt_filePath.Size = new Size(478, 27);
            txt_filePath.TabIndex = 1;
            // 
            // btn_Download
            // 
            btn_Download.BackColor = Color.White;
            btn_Download.FlatStyle = FlatStyle.Flat;
            btn_Download.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Download.Location = new Point(496, 12);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(155, 39);
            btn_Download.TabIndex = 2;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = false;
            btn_Download.Click += btn_Download_Click;
            // 
            // richTextBox_Display
            // 
            richTextBox_Display.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_Display.Location = new Point(12, 97);
            richTextBox_Display.Name = "richTextBox_Display";
            richTextBox_Display.Size = new Size(639, 512);
            richTextBox_Display.TabIndex = 3;
            richTextBox_Display.Text = "";
            // 
            // FormBT2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 621);
            Controls.Add(richTextBox_Display);
            Controls.Add(btn_Download);
            Controls.Add(txt_filePath);
            Controls.Add(txt_URL);
            Name = "FormBT2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_URL;
        private TextBox txt_filePath;
        private Button btn_Download;
        private RichTextBox richTextBox_Display;
    }
}