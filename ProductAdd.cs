using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trendyol
{
    public partial class ProductAdd : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public ProductAdd()
        {
            InitializeComponent();
        }

        public int supplierId { get; set; }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new product();
            product.ProductName = tbProductName.Text.Trim();
            product.SupplierID = supplierId;

            if (cbCategories.SelectedItem == "Meat")
                product.CategoryID = 1;
            else if (cbCategories.SelectedItem == "Dairy")
                product.CategoryID = 2;
            else if (cbCategories.SelectedItem == "Seafood")
                product.CategoryID = 3;
            else if (cbCategories.SelectedItem == "Alcholic Beverages")
                product.CategoryID = 4;

            product.Price = Convert.ToDouble(tbPrice.Text.Trim());
            product.stock = Convert.ToInt32(tbStock.Text.Trim());
            product.isInappropriate = cbIsInappropriate.Checked;

            trendyolEntities.products.Add(product);
            trendyolEntities.SaveChanges();
            MessageBox.Show("Item Sucessfully Added");
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            cbCategories.Items.Add("Meat");
            cbCategories.Items.Add("Dairy");
            cbCategories.Items.Add("Seafood");
            cbCategories.Items.Add("Alcholic Beverages");

        }
    }
}
