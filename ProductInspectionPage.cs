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

        }

        private void btnIssueStrike_Click(object sender, EventArgs e)
        {

        }

        private void btnHideProduct_Click(object sender, EventArgs e)
        {

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

                var qs = (from product in trendyolEntities.products
                          join category in trendyolEntities.categories
                          on product.CategoryID equals category.CategoryID
                          select new
                          {
                              productID = product.ProductID,
                              categoryID = category.CategoryID,
                              productName = product.ProductName,
                              supplierID = product.SupplierID,
                              price = product.Price,
                              stock = product.stock,
                              isInappropriate = product.isInappropriate,
                              isHidden = product.isHidden,
                              strikeCount = product.StrikeCount

                          }
                          ).ToString();
                gvRecordList.DataSource = qs;

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
                var qs = (from product in trendyolEntities.products
                          join category in trendyolEntities.categories
                          on product.CategoryID equals category.CategoryID
                          select new
                          {
                              productID = product.ProductID,
                              categoryID = category.CategoryID,
                              productName = product.ProductName,
                              supplierID = product.SupplierID,
                              price = product.Price,
                              stock = product.stock,
                              isInappropriate = product.isInappropriate,
                              isHidden = product.isHidden,
                              strikeCount = product.StrikeCount

                          }
                         ).ToString();
                gvRecordList.DataSource = qs;
            }

            else if (cbProductCategories.SelectedItem == "Seafood")
            {
                var qs = (from product in trendyolEntities.products
                          join category in trendyolEntities.categories
                          on product.CategoryID equals category.CategoryID
                          select new
                          {
                              productID = product.ProductID,
                              categoryID = category.CategoryID,
                              productName = product.ProductName,
                              supplierID = product.SupplierID,
                              price = product.Price,
                              stock = product.stock,
                              isInappropriate = product.isInappropriate,
                              isHidden = product.isHidden,
                              strikeCount = product.StrikeCount

                          }
                         ).ToString();
                gvRecordList.DataSource = qs;
            }

            else if (cbProductCategories.SelectedItem == "Alcoholic Beverages")
            {
                var qs = (from product in trendyolEntities.products
                          join category in trendyolEntities.categories
                          on product.CategoryID equals category.CategoryID
                          select new
                          {
                              productID = product.ProductID,
                              categoryID = category.CategoryID,
                              productName = product.ProductName,
                              supplierID = product.SupplierID,
                              price = product.Price,
                              stock = product.stock,
                              isInappropriate = product.isInappropriate,
                              isHidden = product.isHidden,
                              strikeCount = product.StrikeCount

                          }
                         ).ToString();
                gvRecordList.DataSource = qs;
            }

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
    
