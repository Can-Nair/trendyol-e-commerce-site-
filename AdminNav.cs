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
    public partial class AdminNav : Form
    {
        public AdminNav()
        {
            InitializeComponent();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminPage = new AdminPage();
            adminPage.MdiParent = this;
            adminPage.Show();
        }

        private void ınspectProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productInspectionPage = new ProductInspectionPage();
            productInspectionPage.MdiParent = this;
            productInspectionPage.Show();
        }
    }
}
