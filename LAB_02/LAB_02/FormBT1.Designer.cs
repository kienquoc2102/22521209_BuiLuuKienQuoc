namespace LAB_02
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
            buttonRead = new Button();
            buttonWrite = new Button();
            textOutput = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonRead
            // 
            buttonRead.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRead.Location = new Point(33, 43);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(261, 57);
            buttonRead.TabIndex = 0;
            buttonRead.Text = "Đọc File";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonWrite
            // 
            buttonWrite.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWrite.Location = new Point(33, 134);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(261, 57);
            buttonWrite.TabIndex = 1;
            buttonWrite.Text = "Ghi File";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // textOutput
            // 
            textOutput.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textOutput.Location = new Point(333, 43);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(439, 373);
            textOutput.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(33, 352);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(261, 64);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormBT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(textOutput);
            Controls.Add(buttonWrite);
            Controls.Add(buttonRead);
            Name = "FormBT1";
            Text = "Bài 01 - Ghi và đọc File";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRead;
        private Button buttonWrite;
        private TextBox textOutput;
        private Button buttonExit;
    }
}