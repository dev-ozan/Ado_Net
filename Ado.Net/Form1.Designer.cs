namespace Ado.Net
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            txtUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            txtStockAmount = new TextBox();
            label3 = new Label();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            label2 = new Label();
            txtStockAmountUpdate = new TextBox();
            txtNameUpdate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtUnitPriceUpdate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(17, 17);
            dgwProducts.Margin = new Padding(4);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(1109, 332);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 24);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 29);
            txtName.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(159, 60);
            txtUnitPrice.Margin = new Padding(4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(141, 29);
            txtUnitPrice.TabIndex = 4;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(7, 68);
            lblUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(93, 21);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "Unit Price :";
            // 
            // txtStockAmount
            // 
            txtStockAmount.Location = new Point(159, 94);
            txtStockAmount.Margin = new Padding(4);
            txtStockAmount.Name = "txtStockAmount";
            txtStockAmount.Size = new Size(141, 29);
            txtStockAmount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 5;
            label3.Text = "Stock Amount :";
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(label1);
            gbxAdd.Controls.Add(txtStockAmount);
            gbxAdd.Controls.Add(txtName);
            gbxAdd.Controls.Add(label3);
            gbxAdd.Controls.Add(lblUnitPrice);
            gbxAdd.Controls.Add(txtUnitPrice);
            gbxAdd.Location = new Point(17, 370);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(314, 193);
            gbxAdd.TabIndex = 7;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(7, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(293, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(label2);
            gbxUpdate.Controls.Add(txtStockAmountUpdate);
            gbxUpdate.Controls.Add(txtNameUpdate);
            gbxUpdate.Controls.Add(label4);
            gbxUpdate.Controls.Add(label5);
            gbxUpdate.Controls.Add(txtUnitPriceUpdate);
            gbxUpdate.Location = new Point(437, 370);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(314, 193);
            gbxUpdate.TabIndex = 9;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(7, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(293, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // txtStockAmountUpdate
            // 
            txtStockAmountUpdate.Location = new Point(159, 94);
            txtStockAmountUpdate.Margin = new Padding(4);
            txtStockAmountUpdate.Name = "txtStockAmountUpdate";
            txtStockAmountUpdate.Size = new Size(141, 29);
            txtStockAmountUpdate.TabIndex = 6;
            // 
            // txtNameUpdate
            // 
            txtNameUpdate.Location = new Point(159, 24);
            txtNameUpdate.Margin = new Padding(4);
            txtNameUpdate.Name = "txtNameUpdate";
            txtNameUpdate.Size = new Size(141, 29);
            txtNameUpdate.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 5;
            label4.Text = "Stock Amount :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 68);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 3;
            label5.Text = "Unit Price :";
            // 
            // txtUnitPriceUpdate
            // 
            txtUnitPriceUpdate.Location = new Point(159, 60);
            txtUnitPriceUpdate.Margin = new Padding(4);
            txtUnitPriceUpdate.Name = "txtUnitPriceUpdate";
            txtUnitPriceUpdate.Size = new Size(141, 29);
            txtUnitPriceUpdate.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 630);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private Label label1;
        private TextBox txtName;
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtStockAmount;
        private Label label3;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private Label label2;
        private TextBox txtStockAmountUpdate;
        private TextBox txtNameUpdate;
        private Label label4;
        private Label label5;
        private TextBox txtUnitPriceUpdate;
    }
}