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
    public partial class ProductInspectionPage : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public ProductInspectionPage()
        {
            InitializeComponent();
        }

        private void btnFlagInappropriate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvProductList.SelectedRows[0].Cells["ProductID"].Value;

                //query database for record
                var product = trendyolEntities.products.FirstOrDefault(q => q.ProductID == id);


                DialogResult dr = MessageBox.Show("You are about to mark this item as inappropriate to minors",
                    "Proceed?", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    if (product.isInappropriate == true)
                        product.isInappropriate = false;

                    else
                        product.isInappropriate = true;

                    trendyolEntities.SaveChanges();
                }
                PopulateGrid();

            }
            catch
            {
                MessageBox.Show("An unexpected error has occured!");
            }

            }

        private void btnIssueStrike_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvProductList.SelectedRows[0].Cells["SupplierID"].Value;
                var supplier = trendyolEntities.suppliers.FirstOrDefault(q => q.SupplierID == id);
                if (supplier.StrikeCount == null)
                    supplier.StrikeCount = 0;
                supplier.StrikeCount = supplier.StrikeCount + 1;
                trendyolEntities.SaveChanges();
            }

            catch
            {
                MessageBox.Show("An unexpected error has occured!");
            }
        }

        private void btnHideProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvProductList.SelectedRows[0].Cells["ProductID"].Value;

                //query database for record
                var product = trendyolEntities.products.FirstOrDefault(q => q.ProductID == id);


                DialogResult dr = MessageBox.Show("You are about to mark hide this item from purchace",
                    "Proceed?", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    if (product.isHidden == true)
                        product.isHidden = false;

                    else
                        product.isHidden = true;

                    trendyolEntities.SaveChanges();
                }
                PopulateGrid();

            }
            catch
            {
                MessageBox.Show("An unexpected error has occured!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductInspectionPage_Load(object sender, EventArgs e)
        {
            cbProductCategories.Items.Add("Meat");
            cbProductCategories.Items.Add("Dairy");
            cbProductCategories.Items.Add("Seafood");
            cbProductCategories.Items.Add("Alcoholic Beverages");
            PopulateGrid();
        }



        private void PopulateGrid()
        {
            if (cbProductCategories.SelectedItem == "Meat")
            {
                var selected_rows = (from p in trendyolEntities.products
                                     join c in trendyolEntities.categories on p.CategoryID equals c.CategoryID
                                     where c.CategoryName == "Meat"
                                     select new { ProductID = p.ProductID, SupplierID = p.SupplierID, ProductName = p.ProductName,
                                         CategoryID = c.CategoryID, CategoryName = c.CategoryName, Price = p.Price,
                                     Stock = p.stock, isInappropriate = p.isInappropriate, isHidden = p.isHidden}).ToList();
                gvProductList.DataSource = selected_rows;
                //foreach (var item in selected_rows)
                //{
                //    .order_details.Remove(item.od_order_id);
                //    trendyolDemoDBEntities.orders.Remove(item.order_id);
                //}

                //var qs = (from product in trendyolEntities.products
                //          join category in trendyolEntities.categories
                //          on product.CategoryID equals category.CategoryID
                //          select new
                //          {
                //              productID = product.ProductID,
                //              categoryName = category.CategoryName,
                //              productName = product.ProductName,
                //              supplierID = product.SupplierID,
                //              price = product.Price,
                //              stock = product.stock,
                //              isInappropriate = product.isInappropriate,
                //              isHidden = product.isHidden,
                //              strikeCount = product.StrikeCount

                //          }
                //          ).ToString();
                //gvRecordList.DataSource = qs;

                //var products = trendyolentities.products
                //    .select(q => new
                //    {
                //        id = q.customerıd,
                //        isadmin = q.isadmin,
                //        isactive = q.isactive,
                //        customerpassword = q.customerpassword,
                //        customername = q.customername,
                //        address = q.address,
                //        city = q.city,
                //        postalcode = q.postalcode,
                //        country = q.country,
                //        username = q.username1

                //    }).tolist();
                //gvrecordlist.datasource = customers;

            }

            else if (cbProductCategories.SelectedItem == "Dairy")
            {

                var selected_rows = (from p in trendyolEntities.products
                                     join c in trendyolEntities.categories on p.CategoryID equals c.CategoryID
                                     where c.CategoryName == "Dairy"
                                     select new {
                                         ProductID = p.ProductID,
                                         SupplierID = p.SupplierID,
                                         ProductName = p.ProductName,
                                         CategoryID = c.CategoryID,
                                         CategoryName = c.CategoryName,
                                         Price = p.Price,
                                         Stock = p.stock,
                                         isInappropriate = p.isInappropriate,
                                         isHidden = p.isHidden
                                     }).ToList();
                gvProductList.DataSource = selected_rows;

                //var qs = (from product in trendyolEntities.products
                //          join category in trendyolEntities.categories
                //          on product.CategoryID equals category.CategoryID
                //          select new
                //          {
                //              productID = product.ProductID,
                //              categoryName = category.CategoryName,
                //              productName = product.ProductName,
                //              supplierID = product.SupplierID,
                //              price = product.Price,
                //              stock = product.stock,
                //              isInappropriate = product.isInappropriate,
                //              isHidden = product.isHidden,
                //              strikeCount = product.StrikeCount

                //          }
                //         ).ToString();
                //gvProductList.DataSource = qs;
            }

            else if (cbProductCategories.SelectedItem == "Seafood")
            {
                var selected_rows = (from p in trendyolEntities.products
                                     join c in trendyolEntities.categories on p.CategoryID equals c.CategoryID
                                     where c.CategoryName == "Seafood"
                                     select new {
                                         ProductID = p.ProductID,
                                         SupplierID = p.SupplierID,
                                         ProductName = p.ProductName,
                                         CategoryID = c.CategoryID,
                                         CategoryName = c.CategoryName,
                                         Price = p.Price,
                                         Stock = p.stock,
                                         isInappropriate = p.isInappropriate,
                                         isHidden = p.isHidden
                                     }).ToList();
                gvProductList.DataSource = selected_rows;
                //var qs = (from product in trendyolEntities.products
                //          join category in trendyolEntities.categories
                //          on product.CategoryID equals category.CategoryID
                //          select new
                //          {
                //              productID = product.ProductID,
                //              categoryID = category.CategoryID,
                //              productName = product.ProductName,
                //              supplierID = product.SupplierID,
                //              price = product.Price,
                //              stock = product.stock,
                //              isInappropriate = product.isInappropriate,
                //              isHidden = product.isHidden,
                //              strikeCount = product.StrikeCount

                //          }
                //         ).ToString();
                //gvProductList.DataSource = qs;
            }

            else if (cbProductCategories.SelectedItem == "Alcoholic Beverages")
            {
                var selected_rows = (from p in trendyolEntities.products
                                     join c in trendyolEntities.categories on p.CategoryID equals c.CategoryID
                                     where c.CategoryName == "Alcoholic Beverages"
                                     select new {
                                         ProductID = p.ProductID,
                                         SupplierID = p.SupplierID,
                                         ProductName = p.ProductName,
                                         CategoryID = c.CategoryID,
                                         CategoryName = c.CategoryName,
                                         Price = p.Price,
                                         Stock = p.stock,
                                         isInappropriate = p.isInappropriate,
                                         isHidden = p.isHidden
                                     }).ToList();
                gvProductList.DataSource = selected_rows;


                //    var qs = (from product in trendyolEntities.products
                //              join category in trendyolEntities.categories
                //              on product.CategoryID equals category.CategoryID
                //              select new
                //              {
                //                  productID = product.ProductID,
                //                  categoryID = category.CategoryID,
                //                  productName = product.ProductName,
                //                  supplierID = product.SupplierID,
                //                  price = product.Price,
                //                  stock = product.stock,
                //                  isInappropriate = product.isInappropriate,
                //                  isHidden = product.isHidden,
                //                  strikeCount = product.StrikeCount

                //              }
                //             ).ToString();
                //    gvProductList.DataSource = qs;
                //}

                //else if (cbUsers.SelectedItem == "Suppliers")
                //{
                //    var supplier = trendyolEntities.suppliers
                //        .Select(q => new
                //        {
                //            id = q.SupplierID,
                //            isAdmin = q.isAdmin,
                //            isActive = q.isActive,
                //            supplierPassword = q.supplierPassword,
                //            supplierName = q.SupplierName,
                //            address = q.Address,
                //            city = q.City,
                //            postalCode = q.PostalCode,
                //            country = q.Country,
                //            username = q.Username1

                //        }).ToList();
                //    gvRecordList.DataSource = supplier;

                //}

            }
        }
    }
}
    
