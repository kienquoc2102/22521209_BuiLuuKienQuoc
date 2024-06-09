namespace LAB_05
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
            label1 = new Label();
            label2 = new Label();
            txt_from = new TextBox();
            txt_to = new TextBox();
            btn_send = new Button();
            label3 = new Label();
            label4 = new Label();
            txt_subject = new TextBox();
            txt_body = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 59);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // txt_from
            // 
            txt_from.Location = new Point(168, 15);
            txt_from.Name = "txt_from";
            txt_from.Size = new Size(436, 27);
            txt_from.TabIndex = 2;
            // 
            // txt_to
            // 
            txt_to.Location = new Point(168, 52);
            txt_to.Name = "txt_to";
            txt_to.Size = new Size(436, 27);
            txt_to.TabIndex = 3;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(12, 22);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(98, 57);
            btn_send.TabIndex = 4;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Body:";
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(168, 102);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(620, 27);
            txt_subject.TabIndex = 7;
            // 
            // txt_body
            // 
            txt_body.Location = new Point(168, 143);
            txt_body.Multiline = true;
            txt_body.Name = "txt_body";
            txt_body.Size = new Size(620, 339);
            txt_body.TabIndex = 8;
            // 
            // FormBT1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(txt_body);
            Controls.Add(txt_subject);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_send);
            Controls.Add(txt_to);
            Controls.Add(txt_from);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBT1";
            Text = "FormBT1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_from;
        private TextBox txt_to;
        private Button btn_send;
        private Label label3;
        private Label label4;
        private TextBox txt_subject;
        private TextBox txt_body;
    }
}