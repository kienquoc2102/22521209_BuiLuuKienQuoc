namespace LAB_02
{
    partial class FormBT3
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
            buttonRead = new Button();
            txt_displayInput = new TextBox();
            txt_displayOutput = new TextBox();
            buttonWrite = new Button();
            label2 = new Label();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 105);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Input3.txt";
            // 
            // buttonRead
            // 
            buttonRead.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRead.Location = new Point(11, 35);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(320, 48);
            buttonRead.TabIndex = 1;
            buttonRead.Text = "Read File";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // txt_displayInput
            // 
            txt_displayInput.Location = new Point(14, 140);
            txt_displayInput.Multiline = true;
            txt_displayInput.Name = "txt_displayInput";
            txt_displayInput.Size = new Size(317, 285);
            txt_displayInput.TabIndex = 2;
            // 
            // txt_displayOutput
            // 
            txt_displayOutput.Location = new Point(355, 140);
            txt_displayOutput.Multiline = true;
            txt_displayOutput.Name = "txt_displayOutput";
            txt_displayOutput.Size = new Size(317, 285);
            txt_displayOutput.TabIndex = 3;
            // 
            // buttonWrite
            // 
            buttonWrite.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWrite.Location = new Point(352, 35);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(320, 48);
            buttonWrite.TabIndex = 4;
            buttonWrite.Text = "Calc and Write";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 105);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "Output3.txt";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(184, 444);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(302, 51);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormBT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 518);
            Controls.Add(buttonExit);
            Controls.Add(label2);
            Controls.Add(buttonWrite);
            Controls.Add(txt_displayOutput);
            Controls.Add(txt_displayInput);
            Controls.Add(buttonRead);
            Controls.Add(label1);
            Name = "FormBT3";
            Text = "Bài 03 - Đọc và Ghi file và tính toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonRead;
        private TextBox txt_displayInput;
        private TextBox txt_displayOutput;
        private Button buttonWrite;
        private Label label2;
        private Button buttonExit;
    }
}