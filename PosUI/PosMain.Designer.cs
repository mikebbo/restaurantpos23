﻿namespace RestaurantPOS.PosUI
{
    partial class PosMain
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
            BtnCancel = new Button();
            BtnSave = new Button();
            btnPrint = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = SystemColors.Highlight;
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Location = new Point(994, 621);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(151, 53);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += this.BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = SystemColors.Highlight;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(837, 621);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(151, 53);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.Highlight;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(680, 621);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(151, 53);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.Highlight;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(507, 621);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(151, 53);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // PosMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 708);
            Controls.Add(BtnCancel);
            Controls.Add(btnAdmin);
            Controls.Add(btnPrint);
            Controls.Add(BtnSave);
            Name = "PosMain";
            Text = "PosMain";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancel;
        private Button BtnSave;
        private Button btnPrint;
        private Button btnAdmin;
    }
}