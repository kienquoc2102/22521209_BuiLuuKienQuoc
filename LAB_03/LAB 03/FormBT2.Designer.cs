namespace LAB_03
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
            btn_Listen = new Button();
            lv_Cmd = new ListView();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.White;
            btn_Listen.FlatStyle = FlatStyle.Flat;
            btn_Listen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(448, 12);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(168, 45);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // lv_Cmd
            // 
            lv_Cmd.Location = new Point(12, 74);
            lv_Cmd.Name = "lv_Cmd";
            lv_Cmd.Size = new Size(604, 425);
            lv_Cmd.TabIndex = 1;
            lv_Cmd.UseCompatibleStateImageBehavior = false;
            lv_Cmd.View = View.List;
            // 
            // FormBT2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 511);
            Controls.Add(lv_Cmd);
            Controls.Add(btn_Listen);
            Name = "FormBT2";
            Text = "Lab 03 - Bài 2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Listen;
        private ListView lv_Cmd;
    }
}