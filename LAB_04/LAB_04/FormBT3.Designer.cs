namespace LAB_04
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
            btn_Load = new Button();
            txt_url = new TextBox();
            btn_Reload = new Button();
            btn_dResources = new Button();
            btn_dFiles = new Button();
            pn_website = new Panel();
            SuspendLayout();
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.White;
            btn_Load.FlatStyle = FlatStyle.Flat;
            btn_Load.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Load.Location = new Point(14, 12);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(132, 40);
            btn_Load.TabIndex = 0;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // txt_url
            // 
            txt_url.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_url.BorderStyle = BorderStyle.FixedSingle;
            txt_url.Location = new Point(152, 12);
            txt_url.Multiline = true;
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(668, 40);
            txt_url.TabIndex = 1;
            // 
            // btn_Reload
            // 
            btn_Reload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Reload.BackColor = Color.White;
            btn_Reload.FlatStyle = FlatStyle.Flat;
            btn_Reload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Reload.Location = new Point(826, 12);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(132, 40);
            btn_Reload.TabIndex = 2;
            btn_Reload.Text = "Reload";
            btn_Reload.UseVisualStyleBackColor = false;
            // 
            // btn_dResources
            // 
            btn_dResources.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_dResources.BackColor = Color.White;
            btn_dResources.FlatStyle = FlatStyle.Flat;
            btn_dResources.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dResources.Location = new Point(763, 58);
            btn_dResources.Name = "btn_dResources";
            btn_dResources.Size = new Size(195, 40);
            btn_dResources.TabIndex = 3;
            btn_dResources.Text = "Down Resources";
            btn_dResources.UseVisualStyleBackColor = false;
            btn_dResources.Click += btn_dResources_Click;
            // 
            // btn_dFiles
            // 
            btn_dFiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_dFiles.BackColor = Color.White;
            btn_dFiles.FlatStyle = FlatStyle.Flat;
            btn_dFiles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dFiles.Location = new Point(562, 58);
            btn_dFiles.Name = "btn_dFiles";
            btn_dFiles.Size = new Size(195, 40);
            btn_dFiles.TabIndex = 4;
            btn_dFiles.Text = "Down Files";
            btn_dFiles.UseVisualStyleBackColor = false;
            btn_dFiles.Click += btn_dFiles_Click;
            // 
            // pn_website
            // 
            pn_website.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn_website.Location = new Point(12, 104);
            pn_website.Name = "pn_website";
            pn_website.Size = new Size(946, 598);
            pn_website.TabIndex = 5;
            // 
            // FormBT3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 714);
            Controls.Add(pn_website);
            Controls.Add(btn_dFiles);
            Controls.Add(btn_dResources);
            Controls.Add(btn_Reload);
            Controls.Add(txt_url);
            Controls.Add(btn_Load);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormBT3";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Load;
        private TextBox txt_url;
        private Button btn_Reload;
        private Button btn_dResources;
        private Button btn_dFiles;
        private Panel pn_website;
    }
}