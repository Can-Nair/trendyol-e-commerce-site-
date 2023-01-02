using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trendyol
{
    public partial class AdminPage : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            cbUsers.Items.Add("Customers");
            cbUsers.Items.Add("Suppliers");
            PopulateGrid();
        }

         

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var tempPassword = "pass";
                // get Id of selected row
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                if (cbUsers.SelectedItem == "Customers")
                {
                    //query database for record
                    var user = trendyolEntities.customers.FirstOrDefault(q => q.CustomerID == id);


                    DialogResult dr = MessageBox.Show("You are about to reset the password of this user with the generic password",
                        "Reset?", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        //delete vehicle from table
                        user.customerPassword = hashPassword(tempPassword);
                        trendyolEntities.SaveChanges();
                    }
                    PopulateGrid();
                }

                else
                {

                    //query database for record
                    var user = trendyolEntities.suppliers.FirstOrDefault(q => q.SupplierID== id);


                    DialogResult dr = MessageBox.Show("You are about to reset the password of this user with the generic password",
                        "Reset?", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        //delete vehicle from table
                        user.supplierPassword = hashPassword(tempPassword);
                        trendyolEntities.SaveChanges();
                    }
                    PopulateGrid();

                } 

            }

            catch
            {
                MessageBox.Show("There has beeen a problem!");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                if (cbUsers.SelectedItem == "Customers")
                {
                    //query database for record
                    var user = trendyolEntities.customers.FirstOrDefault(q => q.CustomerID == id);


                    DialogResult dr = MessageBox.Show("You are about to deactivate / reactivate this user",
                        "Proceed?", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        if (user.isActive)
                            user.isActive = false;

                        else
                            user.isActive = true;

                        trendyolEntities.SaveChanges();
                    }
                    PopulateGrid();
                }

                else
                {

                    //query database for record
                    var user = trendyolEntities.suppliers.FirstOrDefault(q => q.SupplierID == id);


                    DialogResult dr = MessageBox.Show("You are about to deactivate / reactivate this user",
                         "Proceed?", MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        if(user.isActive)
                        user.isActive = false;

                        else
                            user.isActive = true;

                        trendyolEntities.SaveChanges();
                    }
                    PopulateGrid();

                }

            }

            catch
            {
                MessageBox.Show("There has beeen a problem!");
            }
        }

        private void btnRevokePriviledge_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                if (cbUsers.SelectedItem == "Customers")
                {
                    //query database for record
                    var user = trendyolEntities.customers.FirstOrDefault(q => q.CustomerID == id);


                    DialogResult dr = MessageBox.Show("You are about to revoke the priviledge of this user",
                        "Proceed?", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        if (user.isAdmin)
                            user.isAdmin = false;

                        else
                            user.isAdmin = true;

                        trendyolEntities.SaveChanges();
                    }
                    PopulateGrid();
                }

                else
                {

                    //query database for record
                    var user = trendyolEntities.suppliers.FirstOrDefault(q => q.SupplierID == id);


                    DialogResult dr = MessageBox.Show("You are about to revoke the priviledge of this user",
                         "Proceed?", MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        if (user.isAdmin)
                            user.isAdmin = false;

                        else
                            user.isAdmin = true;

                        trendyolEntities.SaveChanges();
                    }
                    PopulateGrid();

                }

            }

            catch
            {
                MessageBox.Show("There has beeen a problem!");
            }
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateGrid()
        {
            if(cbUsers.SelectedItem == "Customers")
            {
                var customers = trendyolEntities.customers
                    .Select(q => new
                    {
                        id = q.CustomerID,
                        isAdmin = q.isAdmin,
                        isActive = q.isActive,
                        customerPassword = q.customerPassword,
                        customerName = q.CustomerName,
                        address = q.Address,
                        city = q.City,
                        postalCode = q.PostalCode,
                        country = q.Country,
                        username = q.Username1
                        
                    }).ToList();
                gvRecordList.DataSource = customers;

            }

            else if (cbUsers.SelectedItem == "Suppliers")
            {
                var supplier = trendyolEntities.suppliers
                    .Select(q => new
                    {
                        id = q.SupplierID,
                        isAdmin = q.isAdmin,
                        isActive = q.isActive,
                        supplierPassword = q.supplierPassword,
                        supplierName = q.SupplierName,
                        address = q.Address,
                        city = q.City,
                        postalCode = q.PostalCode,
                        country = q.Country,
                        StrikeCount = q.StrikeCount,
                        username = q.Username1
                        
                    }).ToList();
                gvRecordList.DataSource = supplier;

            }

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            PopulateGrid();
        }

        public string hashPassword(string pass)
        {
            SHA256 sha = SHA256.Create();


            // Retrieve the inputs
           
            var password = pass;

            // Encrypting the password
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            var hashed_password = sBuilder.ToString();
            return hashed_password;
        }
    }
    }

