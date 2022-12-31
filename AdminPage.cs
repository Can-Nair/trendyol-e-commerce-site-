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
            cbUsers.Items.Add("Both");
            PopulateGrid(cbUsers.SelectedIndex);
        }

        

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {

        }

        private void btnRevokePriviledge_Click(object sender, EventArgs e)
        {

        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateGrid(int currentIndex)
        {
            if(currentIndex == 1)
            {
                var customers = trendyolEntities.customers
                    .Select(q => new
                    {
                        isAdmin = q.isAdmin,
                        isActive = q.isActive,
                        customerPassword = q.customerPassword,
                        customerName = q.CustomerName,
                        address = q.Address,
                        city = q.City,
                        postalCode = q.PostalCode,
                        country = q.Country,
                        username = q.Username1,
                        q.CustomerID
                    }).ToList();
                gvRecordList.DataSource = customers;
            }

            else if (currentIndex == 2)
            {

            }

            else
            {

            }
        }

       
    }
    }

