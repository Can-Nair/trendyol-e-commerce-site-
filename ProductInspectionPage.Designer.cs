namespace trendyol
{
    partial class ProductInspectionPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductCategories = new System.Windows.Forms.ComboBox();
            this.gvProductList = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHideProduct = new System.Windows.Forms.Button();
            this.btnIssueStrike = new System.Windows.Forms.Button();
            this.btnFlagInappropriate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(751, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Categories:";
            // 
            // cbProductCategories
            // 
            this.cbProductCategories.FormattingEnabled = true;
            this.cbProductCategories.Location = new System.Drawing.Point(833, 126);
            this.cbProductCategories.Name = "cbProductCategories";
            this.cbProductCategories.Size = new System.Drawing.Size(121, 24);
            this.cbProductCategories.TabIndex = 27;
            this.cbProductCategories.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // gvProductList
            // 
            this.gvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductList.Location = new System.Drawing.Point(12, 156);
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.RowHeadersWidth = 51;
            this.gvProductList.RowTemplate.Height = 24;
            this.gvProductList.Size = new System.Drawing.Size(942, 260);
            this.gvProductList.TabIndex = 26;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 127);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHideProduct
            // 
            this.btnHideProduct.Location = new System.Drawing.Point(695, 449);
            this.btnHideProduct.Name = "btnHideProduct";
            this.btnHideProduct.Size = new System.Drawing.Size(150, 54);
            this.btnHideProduct.TabIndex = 24;
            this.btnHideProduct.Text = "Hide Product";
            this.btnHideProduct.UseVisualStyleBackColor = true;
            this.btnHideProduct.Click += new System.EventHandler(this.btnHideProduct_Click);
            // 
            // btnIssueStrike
            // 
            this.btnIssueStrike.Location = new System.Drawing.Point(382, 449);
            this.btnIssueStrike.Name = "btnIssueStrike";
            this.btnIssueStrike.Size = new System.Drawing.Size(150, 54);
            this.btnIssueStrike.TabIndex = 23;
            this.btnIssueStrike.Text = "Issue Strike!";
            this.btnIssueStrike.UseVisualStyleBackColor = true;
            this.btnIssueStrike.Click += new System.EventHandler(this.btnIssueStrike_Click);
            // 
            // btnFlagInappropriate
            // 
            this.btnFlagInappropriate.Location = new System.Drawing.Point(61, 449);
            this.btnFlagInappropriate.Name = "btnFlagInappropriate";
            this.btnFlagInappropriate.Size = new System.Drawing.Size(150, 54);
            this.btnFlagInappropriate.TabIndex = 22;
            this.btnFlagInappropriate.Text = "Flag as inappropriate";
            this.btnFlagInappropriate.UseVisualStyleBackColor = true;
            this.btnFlagInappropriate.Click += new System.EventHandler(this.btnFlagInappropriate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 74);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Inspection";
            // 
            // ProductInspectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductCategories);
            this.Controls.Add(this.gvProductList);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHideProduct);
            this.Controls.Add(this.btnIssueStrike);
            this.Controls.Add(this.btnFlagInappropriate);
            this.Controls.Add(this.label2);
            this.Name = "ProductInspectionPage";
            this.Text = "Product Inspection";
            this.Load += new System.EventHandler(this.ProductInspectionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductCategories;
        private System.Windows.Forms.DataGridView gvProductList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHideProduct;
        private System.Windows.Forms.Button btnIssueStrike;
        private System.Windows.Forms.Button btnFlagInappropriate;
        private System.Windows.Forms.Label label2;
    }
}