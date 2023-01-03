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
    public partial class SignUp : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public SignUp()
        {
            InitializeComponent();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            string name = tbName.Text.Trim();
            string address = tbAddress.Text.Trim();
            string postCode = tbPostcode.Text.Trim();
            string city = tbCity.Text.Trim();
            string country = tbCountry.Text.Trim();
            string telno = tbTelephoneNumber.Text.Trim();
            double cash = Convert.ToDouble(tbCash.Text.Trim());
            

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(tbCash.Text))
            {
                MessageBox.Show("please enter all the required information");
            }
            else
            {
                if (cbisSupplier.Checked)
                {
                    var supplier = trendyolEntities.suppliers.FirstOrDefault();
                }
                else
                {


                }
            }
        

        }
    }
}
