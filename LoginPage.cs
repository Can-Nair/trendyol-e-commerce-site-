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
    
    public partial class LoginPage: Form
    {
        private readonly trendyolEntities _db;
        // in order to manipulate the landing page thru the login page.
        private LandingPage _landingPage;
        public LoginPage()
        {
            InitializeComponent();
            _db = new trendyolEntities();
        }

        public LoginPage(LandingPage landingPage)
        {
            InitializeComponent();
            _db = new trendyolEntities();
            _landingPage = landingPage;
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
       

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();


                // Retrieve the inputs
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text.Trim();
                
                // Encrypting the password
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();

                for(int i=0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();

                // Search for a customer or a supplier with the same properties

                if (supplierCheckBox.Checked)
                {
                    var supplier = _db.suppliers.FirstOrDefault(q => q.Username1 == username && q.supplierPassword == hashed_password);

                   
                    if (supplier == null || supplier.isActive == false)
                    {
                        MessageBox.Show("Please provide valid credentials or your account has been deactivated");
                    }

                    else if (supplier.StrikeCount >= 3)
                     MessageBox.Show("This acount has been permanently suspended because of its repeated offences!");


                    else if (supplier.isAdmin == true)
                    {
                        MessageBox.Show("Welcome back administrator");
                        // admin page 
                        var adminNav = new AdminNav();
                        adminNav.Show();
                    }

                    else
                    {
                        var productAddingPanel = new ProductAddingPanel();
                        productAddingPanel.supplierID = supplier.SupplierID;
                        productAddingPanel.Show();
                        // Emirin ekranına gidecek 
                       // Close(); // Emir de hide edip close edilebilir
                    }
                }

                else
                {
                    var customer = _db.customers.FirstOrDefault(q => q.Username1 == username && q.customerPassword == hashed_password);


                    if (customer == null || customer.isActive == false)
                    {
                        MessageBox.Show("Please provide valid credentials or your account has been deactivated");
                    }


                    else if (customer.isAdmin == true)
                    {
                        MessageBox.Show("Welcome back administrator");
                        // admin page 
                        var adminNav = new AdminNav();
                        adminNav.Show();
                        
                    }

                    else
                    {
                        MessageBox.Show($"Welcome back {customer.CustomerName}");
                        
                        var shoppingPage = new ShoppingPage();
                        shoppingPage.customerID = customer.CustomerID;
                        shoppingPage.Show();
                        // Batunun ekranına gidecek 
                        //Close(); // Batu da hide edip close edilebilir
                    }

                }

                
            }
            catch (Exception ex)

            {
                MessageBox.Show("Something went wrong! Please try again!");
                MessageBox.Show(Convert.ToString(ex));
            }
        }



        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _landingPage.Close();   
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            var changePassword = new ChangePassword();
            changePassword.Show();
        }
    }
}
