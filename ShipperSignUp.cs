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
    public partial class ShipperSignUp : Form
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();
        public ShipperSignUp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var shipper = new shipper();
            shipper.Phone = tbTelephoneNumber.Text.Trim();
            shipper.ShipperName = tbName.Text.Trim();
            trendyolEntities.shippers.Add(shipper);

            trendyolEntities.SaveChanges();
            MessageBox.Show("Thank you for your interest, we will be in contact with you");
            this.Close();
        }
    }
}
