namespace LAB_04
{
    partial class FormBT1
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
            btn_get = new Button();
            richTextBox_Display = new RichTextBox();
            SuspendLayout();
            // 
            // txt_URL
            // 
            txt_URL.Location = new Point(12, 12);
            txt_URL.Multiline = true;
            txt_URL.Name = "txt_URL";
            txt_URL.Size = new Size(487, 36);
            txt_URL.TabIndex = 0;
            // 
            // btn_get
            // 
            btn_get.BackColor = Color.White;
            btn_get.FlatStyle = FlatStyle.Flat;
            btn_get.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_get.Location = new Point(505, 12);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(151, 36);
            btn_get.TabIndex = 1;
            btn_get.Text = "GET";
            btn_get.UseVisualStyleBackColor = false;
            btn_get.Click += btn_get_Click;
            // 
            // richTextBox_Display
            // 
            richTextBox_Display.Location = new Point(12, 65);
            richTextBox_Display.Name = "richTextBox_Display";
            richTextBox_Display.Size = new Size(644, 529);
            richTextBox_Display.TabIndex = 2;
            richTextBox_Display.Text = "";
            // 
            // FormBT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 621);
            Controls.Add(richTextBox_Display);
            Controls.Add(btn_get);
            Controls.Add(txt_URL);
            Name = "FormBT1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_URL;
        private Button btn_get;
        private RichTextBox richTextBox_Display;
    }
}