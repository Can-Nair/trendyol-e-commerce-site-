using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trendyol
{
    public partial class ProductAddingPanel : Form
    {

        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public ProductAddingPanel()
        {
            InitializeComponent();
        }

        public int supplierID { get; set; }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            if(cbOptions.SelectedItem == "My Products")
            {
                var myItems = (from s in trendyolEntities.suppliers
                               join p in trendyolEntities.products on s.SupplierID equals p.SupplierID
                               where s.SupplierID == supplierID
                               select new
                               {
                                   ProductID = p.ProductID,
                                   SupplierID = p.SupplierID,
                                   ProductName = p.ProductName,
                                   Price = p.Price,
                                   Stock = p.stock,
                                   isInappropriate = p.isInappropriate,
                                   isHidden = p.isHidden
                               }).ToList();
                //BindingSource bindingSource = new BindingSource();
                //bindingSource.DataSource = myItems;

                gvProductViewingList.DataSource = myItems;
            }
            else if (cbOptions.SelectedItem == "Top Sellers")
            {
                /*the follow,ing is the linq equivalent of 
                 SELECT product.ProductID, product.ProductName, SUM(order_details.Quantity * product.Price) AS TotalGross
                 FROM products AS product
                 JOIN order_details AS order_details ON order_details.ProductID = product.ProductID
                 GROUP BY product.ProductID, product.ProductName
                 ORDER BY TotalGross DESC
                 LIMIT 5;*/
                var topFiveGrossingProducts =
    (from product in trendyolEntities.products
     join orderDetail in trendyolEntities.order_details on product.ProductID equals orderDetail.ProductID
     group new { product, orderDetail } by new { product.ProductID, product.ProductName } into g
     select new
     {
         g.Key.ProductID,
         g.Key.ProductName,
         TotalGross = g.Sum(x => x.orderDetail.Quantity * x.product.Price)
     })
    .OrderByDescending(x => x.TotalGross)
    .Take(5).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = topFiveGrossingProducts;

                gvProductViewingList.DataSource = bindingSource;


                

            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            var productAdd = new ProductAdd();
            productAdd.supplierId = supplierID;
            productAdd.Show();

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var id = (int)gvProductViewingList.SelectedRows[0].Cells["ProductID"].Value;
            var editProduct = new EditProduct();
            editProduct.supplierID = supplierID;
            editProduct.ProductID = id;
            editProduct.Show();
        }

        private void ProductAddingPanel_Load(object sender, EventArgs e)
        {
            cbOptions.Items.Add("My Products");
            cbOptions.Items.Add("Top Sellers");
            PopulateGrid();
        }
    }
}
