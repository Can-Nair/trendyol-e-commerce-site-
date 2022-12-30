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

                // Search for a customer with the same properties
                var customer = _db.customers.FirstOrDefault(q => q.Username1 == username && q.customerPassword == hashed_password);
                var supplier = _db.suppliers.FirstOrDefault(q => q.Username1 == username && q.supplierPassword == hashed_password);

                if (customer == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }

                else
                {
                    Close();
                }

                if (supplier == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }

                else
                {
                    Close();
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Something went wrong! Please try again!");

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
    }
}
