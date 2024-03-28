namespace LAB_02
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
            buttonRead = new Button();
            textDisplay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonExit = new Button();
            textName = new TextBox();
            textSize = new TextBox();
            textURL = new TextBox();
            textLineCount = new TextBox();
            textWordsCount = new TextBox();
            textCharCount = new TextBox();
            SuspendLayout();
            // 
            // buttonRead
            // 
            buttonRead.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRead.Location = new Point(12, 23);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(413, 51);
            buttonRead.TabIndex = 0;
            buttonRead.Text = "Read from File";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textDisplay
            // 
            textDisplay.BackColor = Color.White;
            textDisplay.Enabled = false;
            textDisplay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.ForeColor = Color.Black;
            textDisplay.Location = new Point(441, 23);
            textDisplay.Multiline = true;
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(416, 402);
            textDisplay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 237);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 6;
            label5.Text = "Words count ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 318);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 7;
            label6.Text = "Character count ";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(12, 374);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(413, 51);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Enabled = false;
            textName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textName.ForeColor = Color.Black;
            textName.Location = new Point(135, 98);
            textName.Name = "textName";
            textName.Size = new Size(290, 30);
            textName.TabIndex = 9;
            // 
            // textSize
            // 
            textSize.BackColor = Color.White;
            textSize.Enabled = false;
            textSize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSize.ForeColor = Color.Black;
            textSize.Location = new Point(135, 141);
            textSize.Name = "textSize";
            textSize.Size = new Size(290, 30);
            textSize.TabIndex = 10;
            // 
            // textURL
            // 
            textURL.BackColor = Color.White;
            textURL.Enabled = false;
            textURL.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textURL.ForeColor = Color.Black;
            textURL.Location = new Point(135, 184);
            textURL.Name = "textURL";
            textURL.Size = new Size(290, 30);
            textURL.TabIndex = 11;
            // 
            // textLineCount
            // 
            textLineCount.BackColor = Color.White;
            textLineCount.Enabled = false;
            textLineCount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textLineCount.ForeColor = Color.Black;
            textLineCount.Location = new Point(135, 230);
            textLineCount.Name = "textLineCount";
            textLineCount.Size = new Size(290, 30);
            textLineCount.TabIndex = 12;
            // 
            // textWordsCount
            // 
            textWordsCount.BackColor = Color.White;
            textWordsCount.Enabled = false;
            textWordsCount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textWordsCount.ForeColor = Color.Black;
            textWordsCount.Location = new Point(135, 271);
            textWordsCount.Name = "textWordsCount";
            textWordsCount.Size = new Size(290, 30);
            textWordsCount.TabIndex = 13;
            // 
            // textCharCount
            // 
            textCharCount.BackColor = Color.White;
            textCharCount.Enabled = false;
            textCharCount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textCharCount.ForeColor = Color.Black;
            textCharCount.Location = new Point(135, 311);
            textCharCount.Name = "textCharCount";
            textCharCount.Size = new Size(290, 30);
            textCharCount.TabIndex = 14;
            // 
            // FormBT2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 450);
            Controls.Add(textCharCount);
            Controls.Add(textWordsCount);
            Controls.Add(textLineCount);
            Controls.Add(textURL);
            Controls.Add(textSize);
            Controls.Add(textName);
            Controls.Add(buttonExit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textDisplay);
            Controls.Add(buttonRead);
            Name = "FormBT2";
            Text = "Bài 02 – Đọc thông tin một file .txt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRead;
        private TextBox textDisplay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonExit;
        private TextBox textName;
        private TextBox textSize;
        private TextBox textURL;
        private TextBox textLineCount;
        private TextBox textWordsCount;
        private TextBox textCharCount;
    }
}