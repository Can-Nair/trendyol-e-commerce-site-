
namespace CustomerPanel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.cbCategoryType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gvProductList = new System.Windows.Forms.DataGridView();
            this.gvShoppingCart = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxpprice = new System.Windows.Forms.TextBox();
            this.textBoxpname = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.textBoxqname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxcash = new System.Windows.Forms.TextBox();
            this.textBoxpid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(397, 311);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(97, 44);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Order";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(566, 311);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(97, 44);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // cbCategoryType
            // 
            this.cbCategoryType.FormattingEnabled = true;
            this.cbCategoryType.Location = new System.Drawing.Point(384, 48);
            this.cbCategoryType.Name = "cbCategoryType";
            this.cbCategoryType.Size = new System.Drawing.Size(121, 24);
            this.cbCategoryType.TabIndex = 2;
            this.cbCategoryType.Text = "Select Category";
            this.cbCategoryType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(471, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gvProductList
            // 
            this.gvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductList.Location = new System.Drawing.Point(208, 78);
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.RowHeadersWidth = 51;
            this.gvProductList.RowTemplate.Height = 24;
            this.gvProductList.Size = new System.Drawing.Size(635, 214);
            this.gvProductList.TabIndex = 6;
            this.gvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductList_CellContentClick);
            // 
            // gvShoppingCart
            // 
            this.gvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.Total});
            this.gvShoppingCart.Location = new System.Drawing.Point(257, 389);
            this.gvShoppingCart.Name = "gvShoppingCart";
            this.gvShoppingCart.RowHeadersWidth = 51;
            this.gvShoppingCart.RowTemplate.Height = 24;
            this.gvShoppingCart.Size = new System.Drawing.Size(556, 146);
            this.gvShoppingCart.TabIndex = 7;
            this.gvShoppingCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 125;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "ProductQuantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxpprice
            // 
            this.textBoxpprice.Location = new System.Drawing.Point(967, 190);
            this.textBoxpprice.Name = "textBoxpprice";
            this.textBoxpprice.Size = new System.Drawing.Size(100, 22);
            this.textBoxpprice.TabIndex = 9;
            // 
            // textBoxpname
            // 
            this.textBoxpname.Location = new System.Drawing.Point(965, 142);
            this.textBoxpname.Name = "textBoxpname";
            this.textBoxpname.Size = new System.Drawing.Size(100, 22);
            this.textBoxpname.TabIndex = 10;
            this.textBoxpname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(979, 280);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // textBoxqname
            // 
            this.textBoxqname.Location = new System.Drawing.Point(967, 241);
            this.textBoxqname.Name = "textBoxqname";
            this.textBoxqname.Size = new System.Drawing.Size(100, 22);
            this.textBoxqname.TabIndex = 12;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(849, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(871, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(871, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cash";
            // 
            // textBoxcash
            // 
            this.textBoxcash.Location = new System.Drawing.Point(62, 36);
            this.textBoxcash.Name = "textBoxcash";
            this.textBoxcash.Size = new System.Drawing.Size(100, 22);
            this.textBoxcash.TabIndex = 18;
            this.textBoxcash.TextChanged += new System.EventHandler(this.textBoxcash_TextChanged);
            // 
            // textBoxpid
            // 
            this.textBoxpid.Location = new System.Drawing.Point(967, 99);
            this.textBoxpid.Name = "textBoxpid";
            this.textBoxpid.Size = new System.Drawing.Size(100, 22);
            this.textBoxpid.TabIndex = 19;
            this.textBoxpid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(849, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(62, 99);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(127, 22);
            this.textBoxDate.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 179);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "CustomerID";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(102, 179);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(74, 22);
            this.textBoxCustomerID.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 561);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxpid);
            this.Controls.Add(this.textBoxcash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxqname);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.textBoxpname);
            this.Controls.Add(this.textBoxpprice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gvShoppingCart);
            this.Controls.Add(this.gvProductList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoryType);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ComboBox cbCategoryType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvProductList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gvShoppingCart;
        private System.Windows.Forms.TextBox textBoxpprice;
        private System.Windows.Forms.TextBox textBoxpname;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox textBoxqname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxcash;
        private System.Windows.Forms.TextBox textBoxpid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCustomerID;
    }
}

