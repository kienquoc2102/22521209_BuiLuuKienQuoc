﻿namespace LAB_03
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
            btn_OpenClient = new Button();
            btn_OpenServer = new Button();
            SuspendLayout();
            // 
            // btn_OpenClient
            // 
            btn_OpenClient.BackColor = Color.White;
            btn_OpenClient.FlatStyle = FlatStyle.Flat;
            btn_OpenClient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenClient.Location = new Point(12, 21);
            btn_OpenClient.Name = "btn_OpenClient";
            btn_OpenClient.Size = new Size(576, 40);
            btn_OpenClient.TabIndex = 0;
            btn_OpenClient.Text = "Open new TCP client";
            btn_OpenClient.UseVisualStyleBackColor = false;
            btn_OpenClient.Click += btn_OpenClient_Click;
            // 
            // btn_OpenServer
            // 
            btn_OpenServer.BackColor = Color.White;
            btn_OpenServer.FlatStyle = FlatStyle.Flat;
            btn_OpenServer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_OpenServer.Location = new Point(12, 79);
            btn_OpenServer.Name = "btn_OpenServer";
            btn_OpenServer.Size = new Size(576, 40);
            btn_OpenServer.TabIndex = 1;
            btn_OpenServer.Text = "Open new TCP server";
            btn_OpenServer.UseVisualStyleBackColor = false;
            btn_OpenServer.Click += btn_OpenServer_Click;
            // 
            // FormBT3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 167);
            Controls.Add(btn_OpenServer);
            Controls.Add(btn_OpenClient);
            Name = "FormBT3";
            Text = "Lab 03 - Bài 3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_OpenClient;
        private Button btn_OpenServer;
    }
}