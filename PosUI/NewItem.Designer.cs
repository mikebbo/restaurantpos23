namespace RestaurantPOS.PosUI
{
    partial class NewItem
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
            BtnCancel.Click += BtnCancel_Click;
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
            // NewItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 708);
            Controls.Add(BtnCancel);
            Controls.Add(btnPrint);
            Controls.Add(BtnSave);
            Name = "NewItem";
            Text = "New Item";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancel;
        private Button BtnSave;
        private Button btnPrint;
    }
}