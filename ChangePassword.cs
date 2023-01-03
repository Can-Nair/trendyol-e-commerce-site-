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
    public partial class ChangePassword : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUsername.Text.Trim();


                if (supplierCheckBox2.Checked)
                {
                    var suppliers = trendyolEntities.suppliers.FirstOrDefault(q => q.Username1 == username);
                    suppliers.supplierPassword = hashPassword(tbNewPassword.Text.Trim());
                    trendyolEntities.SaveChanges();
                    MessageBox.Show("You have successfully reset your password");
                }
                else
                {
                    var customers = trendyolEntities.customers.FirstOrDefault(q => q.Username1 == username);
                    customers.customerPassword = hashPassword(tbNewPassword.Text.Trim());
                    trendyolEntities.SaveChanges();
                    MessageBox.Show("You have successfully reset your password");
                }
            }

            catch
            {
                MessageBox.Show("Please check your inputs!");
            }
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

        private void supplierCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
