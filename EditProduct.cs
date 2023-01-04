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
    public partial class EditProduct : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public EditProduct()
        {
            InitializeComponent();
        }

        public int ProductID { get; set; }
        public int supplierID { get; set; }

        private void btnMakeChanges_Click(object sender, EventArgs e)
        {
            var product = trendyolEntities.products.FirstOrDefault(q => q.ProductID == ProductID);
            product.ProductName = tbProductName.Text.Trim();
            product.SupplierID = supplierID;

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
            product.isInappropriate = cbChangeAppropriate.Checked;
            trendyolEntities.SaveChanges();
            MessageBox.Show("Product Successfully changed");
            this.Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            var product = trendyolEntities.products.FirstOrDefault(q => q.ProductID == ProductID);
            tbProductName.Text = product.ProductName;
            tbPrice.Text = Convert.ToString(product.Price);
            tbStock.Text = Convert.ToString(product.stock);
            if (product.CategoryID == 1)
                cbCategories.Text = "Meat";
            else if (product.CategoryID == 2)
                cbCategories.Text = "Dairy";
            else if (product.CategoryID == 3)
                cbCategories.Text = "Seafood";
            else if (product.CategoryID == 4)
                cbCategories.Text = "Alcholoic Beverages";

            if ((bool)product.isInappropriate)
                cbChangeAppropriate.Checked = true;
            else
                cbChangeAppropriate.Checked = false;

            cbCategories.Items.Add("Meat");
            cbCategories.Items.Add("Dairy");
            cbCategories.Items.Add("Seafood");
            cbCategories.Items.Add("Alcholic Beverages");
        }
    }
}
