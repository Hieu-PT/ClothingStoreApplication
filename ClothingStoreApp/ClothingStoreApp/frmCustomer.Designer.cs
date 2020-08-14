namespace ClothingStoreApp
{
    partial class frmCustomer
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
            this.lbUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAddToCart = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lbSignOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbItemPrice = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbItemID = new System.Windows.Forms.Label();
            this.btClearCart = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(27, 27);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(80, 18);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Welcome, ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(44, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(7, 19);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(499, 198);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAddToCart);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.lbPrice);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.lbID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(601, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 223);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pending to Cart";
            // 
            // btAddToCart
            // 
            this.btAddToCart.Location = new System.Drawing.Point(68, 139);
            this.btAddToCart.Name = "btAddToCart";
            this.btAddToCart.Size = new System.Drawing.Size(130, 40);
            this.btAddToCart.TabIndex = 8;
            this.btAddToCart.Text = "Add To Cart";
            this.btAddToCart.UseVisualStyleBackColor = true;
            this.btAddToCart.Click += new System.EventHandler(this.btAddToCart_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(199, 73);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 20);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(126, 75);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(28, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "XXX";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(56, 75);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "XXXX";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.Color.Red;
            this.lbID.Location = new System.Drawing.Point(21, 76);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(14, 13);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCart);
            this.groupBox3.Location = new System.Drawing.Point(44, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 213);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Shopping Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(6, 20);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(499, 187);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // lbSignOut
            // 
            this.lbSignOut.AutoSize = true;
            this.lbSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignOut.ForeColor = System.Drawing.Color.Red;
            this.lbSignOut.Location = new System.Drawing.Point(828, 32);
            this.lbSignOut.Name = "lbSignOut";
            this.lbSignOut.Size = new System.Drawing.Size(48, 13);
            this.lbSignOut.TabIndex = 6;
            this.lbSignOut.Text = "Sign Out";
            this.lbSignOut.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(155, 596);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btRemove);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtItemQuantity);
            this.groupBox4.Controls.Add(this.lbItemPrice);
            this.groupBox4.Controls.Add(this.lbItemName);
            this.groupBox4.Controls.Add(this.lbItemID);
            this.groupBox4.Location = new System.Drawing.Point(601, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 207);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Item";
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(153, 163);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(46, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Quantity:";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(126, 115);
            this.txtItemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(58, 20);
            this.txtItemQuantity.TabIndex = 3;
            this.txtItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbItemPrice
            // 
            this.lbItemPrice.AutoSize = true;
            this.lbItemPrice.Location = new System.Drawing.Point(150, 39);
            this.lbItemPrice.Name = "lbItemPrice";
            this.lbItemPrice.Size = new System.Drawing.Size(34, 13);
            this.lbItemPrice.TabIndex = 2;
            this.lbItemPrice.Text = "Price:";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Location = new System.Drawing.Point(43, 78);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(38, 13);
            this.lbItemName.TabIndex = 1;
            this.lbItemName.Text = "Name:";
            // 
            // lbItemID
            // 
            this.lbItemID.AutoSize = true;
            this.lbItemID.ForeColor = System.Drawing.Color.Red;
            this.lbItemID.Location = new System.Drawing.Point(65, 39);
            this.lbItemID.Name = "lbItemID";
            this.lbItemID.Size = new System.Drawing.Size(21, 13);
            this.lbItemID.TabIndex = 0;
            this.lbItemID.Text = "XX";
            // 
            // btClearCart
            // 
            this.btClearCart.Location = new System.Drawing.Point(296, 592);
            this.btClearCart.Name = "btClearCart";
            this.btClearCart.Size = new System.Drawing.Size(75, 38);
            this.btClearCart.TabIndex = 10;
            this.btClearCart.Text = "Clear Cart";
            this.btClearCart.UseVisualStyleBackColor = true;
            this.btClearCart.Click += new System.EventHandler(this.btClearCart_Click);
            // 
            // btCheckOut
            // 
            this.btCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.Location = new System.Drawing.Point(403, 592);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(473, 38);
            this.btCheckOut.TabIndex = 11;
            this.btCheckOut.Text = "Check Out";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(155, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 662);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.btClearCart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSignOut);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbUser);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomer_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddToCart;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbSignOut;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtItemQuantity;
        private System.Windows.Forms.Label lbItemPrice;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbItemID;
        private System.Windows.Forms.Button btClearCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
    }
}