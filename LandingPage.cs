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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void customerEnter_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage(this);
            loginPage.Show();
            Hide();
              
        }

        private void supplierEnter_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage(this);
            loginPage.Show();
            Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            // Emirhan'nın ekranına gidecek
            var signUp = new SignUp();
            signUp.Show();
        }

        private void cbShipperPath_CheckedChanged(object sender, EventArgs e)
        {
            var shipperSignUp = new ShipperSignUp();
            shipperSignUp.Show();
        }
    }
}
