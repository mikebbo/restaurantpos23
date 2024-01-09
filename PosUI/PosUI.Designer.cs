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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
            BtnCancel = new Button();
            BtnSave = new Button();
            btnPrint = new Button();
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            btnPizza = new Button();
            btnHotdog = new Button();
            btnPizzaSlice = new Button();
            btnPoutine = new Button();
            button3 = new Button();
            btnFrenchFries = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            BtnCancel.Click += BtnCancel_Click_1;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Quantity, Amount });
            dataGridView1.Location = new Point(23, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(386, 473);
            dataGridView1.TabIndex = 3;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(692, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(422, 473);
            dataGridView2.TabIndex = 3;
            // 
            // btnPizza
            // 
            btnPizza.BackColor = SystemColors.Highlight;
            btnPizza.ForeColor = Color.White;
            btnPizza.Image = (Image)resources.GetObject("btnPizza.Image");
            btnPizza.Location = new Point(718, 76);
            btnPizza.Name = "btnPizza";
            btnPizza.Size = new Size(151, 122);
            btnPizza.TabIndex = 4;
            btnPizza.Text = "Pizza";
            btnPizza.UseVisualStyleBackColor = false;
            // 
            // btnHotdog
            // 
            btnHotdog.BackColor = SystemColors.Highlight;
            btnHotdog.ForeColor = Color.White;
            btnHotdog.Image = Properties.Resources.hotdog;
            btnHotdog.Location = new Point(913, 76);
            btnHotdog.Name = "btnHotdog";
            btnHotdog.Size = new Size(151, 122);
            btnHotdog.TabIndex = 5;
            btnHotdog.Text = "Hotdog";
            btnHotdog.UseVisualStyleBackColor = false;
            // 
            // btnPizzaSlice
            // 
            btnPizzaSlice.BackColor = SystemColors.Highlight;
            btnPizzaSlice.ForeColor = Color.White;
            btnPizzaSlice.Location = new Point(913, 228);
            btnPizzaSlice.Name = "btnPizzaSlice";
            btnPizzaSlice.Size = new Size(151, 122);
            btnPizzaSlice.TabIndex = 7;
            btnPizzaSlice.Text = "Pizza slice";
            btnPizzaSlice.UseVisualStyleBackColor = false;
            // 
            // btnPoutine
            // 
            btnPoutine.BackColor = SystemColors.Highlight;
            btnPoutine.ForeColor = Color.White;
            btnPoutine.Location = new Point(718, 228);
            btnPoutine.Name = "btnPoutine";
            btnPoutine.Size = new Size(151, 122);
            btnPoutine.TabIndex = 6;
            btnPoutine.Text = "Poutine";
            btnPoutine.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.ForeColor = Color.White;
            button3.Location = new Point(913, 381);
            button3.Name = "button3";
            button3.Size = new Size(151, 122);
            button3.TabIndex = 9;
            button3.Text = "Hotdog";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnFrenchFries
            // 
            btnFrenchFries.BackColor = SystemColors.Highlight;
            btnFrenchFries.ForeColor = Color.White;
            btnFrenchFries.Image = Properties.Resources.poutine;
            btnFrenchFries.Location = new Point(718, 381);
            btnFrenchFries.Name = "btnFrenchFries";
            btnFrenchFries.Size = new Size(151, 122);
            btnFrenchFries.TabIndex = 8;
            btnFrenchFries.Text = "FrenchFrize";
            btnFrenchFries.UseVisualStyleBackColor = false;
            // 
            // NewItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 708);
            Controls.Add(button3);
            Controls.Add(btnFrenchFries);
            Controls.Add(btnPizzaSlice);
            Controls.Add(btnPoutine);
            Controls.Add(btnHotdog);
            Controls.Add(btnPizza);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(BtnCancel);
            Controls.Add(btnPrint);
            Controls.Add(BtnSave);
            Name = "NewItem";
            Text = "New Item";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancel;
        private Button BtnSave;
        private Button btnPrint;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private Button btnPizza;
        private Button btnHotdog;
        private Button btnPizzaSlice;
        private Button btnPoutine;
        private Button button3;
        private Button btnFrenchFries;
    }
}