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
    public partial class ShoppingPage : Form 
    {
        private readonly trendyolEntities trendyolEntities = new trendyolEntities();

        public int customerID { get; set; }
        public string customerName { get; set; }

        public ShoppingPage()
        {
            InitializeComponent();
            // Bunları load'a taşıdım 
            //textBoxDate.Text = DateTime.Now.ToLongDateString();
            //textBoxCustomerID.Text = Convert.ToString(4);
            //var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            //textBoxcash.Text = Convert.ToString((from q in trendyolEntities.customers where q.CustomerID == cust_id select q.Cash).Single());

           
        }

        void loadData()
        {

            var st = from s in trendyolEntities.products select s;
            gvShoppingCart.DataSource = st;

        }

        int grandTotal = 0, n = 0;
        //int total_amount = 0;
        Decimal Account = 0;

        private void cbCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxCustomerID.Text = Convert.ToString(customerID);
            var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            textBoxcash.Text = Convert.ToString((from q in trendyolEntities.customers where q.CustomerID == cust_id select q.Cash).Single());
            var categories = trendyolEntities.categories.ToList();
            cbCategoryType.DisplayMember = "CategoryName";
            cbCategoryType.ValueMember = "CategoryID";
            cbCategoryType.DataSource = categories;
            trendyolEntities.SaveChanges();
            

            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var category_name = cbCategoryType.Text;
            //if (category_name.Text == "")
            //var is_appropriate = Convert.ToInt32((from q in trendyolEntities.categories where q.CategoryName == category_name join p in trendyolEntities.products on q.CategoryID equals p.CategoryID select p.isInappropriate).Single());
            //if (is_appropriate == 1)
            //{
            //    MessageBox.Show("+18 Staff", "Window Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            Console.WriteLine(category_name);
            var catID = trendyolEntities.categories.Where(x => x.CategoryName == category_name).Select(x => x.CategoryID).ToList();
            int i = catID[0];
            Console.WriteLine(i);
            var prd = trendyolEntities.products.Where(q => q.CategoryID == i).Select(q => new { q.ProductID, q.ProductName, q.SupplierID, q.CategoryID, q.stock, q.Price }).ToList();
            var is_appropriate = Convert.ToInt32((from q in trendyolEntities.categories where q.CategoryName == category_name join p in trendyolEntities.products on q.CategoryID equals p.CategoryID select p.isInappropriate).FirstOrDefault());
            if (is_appropriate == 1)
            {
                MessageBox.Show("+18 Staff", "Window Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            gvProductList.DataSource = prd.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvShoppingCart.CurrentCell.RowIndex;
            Console.WriteLine("row index : " + rowIndex);
            int p_id = Convert.ToInt32(gvShoppingCart.CurrentRow.Cells[0].Value);
            DataGridViewRow row = gvShoppingCart.Rows[rowIndex];
            string p_name = Convert.ToString(row.Cells[1].Value);
            var p_price = Convert.ToDouble((from p in trendyolEntities.products where p.ProductID == p_id select p.Price).Single());
            Console.WriteLine("p_price : " + p_price);
            int stok_amount = Convert.ToInt32(row.Cells[3].Value);
            gvShoppingCart.Rows.RemoveAt(rowIndex);

            var query = from ord in trendyolEntities.products where ord.ProductName == p_name select ord;
            foreach (product i in query)
            {
                i.stock += stok_amount;
            }

            var total_cash = Convert.ToDouble(textBoxcash.Text);
            total_cash += (p_price * stok_amount);
            textBoxcash.Text = Convert.ToString(total_cash);

            var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            trendyolEntities.customers.Where(p => p.CustomerID == cust_id).ToList().ForEach(x => x.Cash = total_cash);
            Console.WriteLine("p_id : " + p_id);

            var deleted_rows = (from od in trendyolEntities.order_details
                                join o in trendyolEntities.orders on od.OrderID equals o.OrderID
                                where od.ProductID == p_id
                                //select new { order_id = o.OrderID, order_details_order_id = od.OrderID }).FirstOrDefault();
                                select new { order_id = o, od_order_id = od });
            foreach (var item in deleted_rows)
            {
                trendyolEntities.order_details.Remove(item.od_order_id);
                trendyolEntities.orders.Remove(item.order_id);
            }
            trendyolEntities.SaveChanges();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxProductName.Text = gvProductList.SelectedRows[0].Cells["ProductName"].Value.ToString();
            textBoxProductPrice.Text = gvProductList.SelectedRows[0].Cells["Price"].Value.ToString();
            textBoxProductID.Text = gvProductList.SelectedRows[0].Cells["ProductID"].Value.ToString();
            textBoxQuantity.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DateTime orderDate = DateTime.Parse(textBoxDate.Text);
            var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            var customerCash = Convert.ToDouble((from q in trendyolEntities.customers where q.CustomerID == cust_id select q.Cash).Single());
            order add_order = new order();
            add_order.OrderID = n;
            add_order.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
            add_order.OrderDate = orderDate;
            trendyolEntities.orders.Add(add_order);
            order_details order_items = new order_details();
            order_items.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            order_items.OrderID = add_order.OrderID;
            order_items.OrderDetailID = n;
            order_items.ProductID = trendyolEntities.products.First(a => a.ProductName == textBoxProductName.Text).ProductID;
            var totalAmount = (from p in trendyolEntities.customers
                               join c in trendyolEntities.orders on p.CustomerID equals c.CustomerID
                               join a in trendyolEntities.order_details on c.OrderID equals a.OrderID
                               join d in trendyolEntities.products on a.ProductID equals d.ProductID
                               where d.ProductID == order_items.ProductID
                               select new
                               {
                                   //Quantity = a.Quantity,
                                   //TotalAmount = a.Quantity * Convert.ToInt32(textBoxpprice.Text)
                                   TotalAmount = (order_items.Quantity * d.Price)
                               });
            Console.WriteLine("Quantity :" + order_items.Quantity);
            Console.WriteLine("Product ID :" + order_items.ProductID);

            trendyolEntities.order_details.Add(order_items);


            foreach (var item in totalAmount)
            {
                Console.WriteLine("total : " + item.TotalAmount);
            }

            /* var total_amount = (from l in totalAmount orderby l.TotalAmount select l.TotalAmount).Single(); */// Bu First idi sadece
            var total_amount = order_items.Quantity * Convert.ToDouble(textBoxProductPrice.Text);
            Console.WriteLine("Last total : " + total_amount);

            var p_name = textBoxProductName.Text;
            var quantity = textBoxQuantity.Text;


            var query = from ord in trendyolEntities.products where ord.ProductName == p_name select ord;
            var product_stock = 0;

            if (textBoxcash.Text == "" || textBoxProductName.Text == "" || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            foreach (product i in query)
            {
                product_stock = i.stock;
            }

            if (Convert.ToInt32(textBoxQuantity.Text) > product_stock || (product_stock - Convert.ToInt32(textBoxQuantity.Text)) < 0)
            {
                MessageBox.Show("No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            var category_name = cbCategoryType.Text;
            var is_appropriate = Convert.ToInt32((from q in trendyolEntities.categories where q.CategoryName == category_name join p in trendyolEntities.products on q.CategoryID equals p.CategoryID select p.isInappropriate).Single());
            var is_hidden = Convert.ToInt32((from q in trendyolEntities.categories where q.CategoryName == category_name join p in trendyolEntities.products on q.CategoryID equals p.CategoryID select p.isHidden).Single());

            if (is_appropriate == 1 && is_hidden == 1)
            {
                MessageBox.Show("It is hidden to buy. You cannot buy this product", "Window Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                foreach (product i in query)
                {
                    product_stock = i.stock;
                    //Console.WriteLine("Stock : ", product_stock);
                }

                if (customerCash <= 0 || customerCash - total_amount <= 0)
                {

                    MessageBox.Show("No Money or No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                // Create a new DataGridViewColumn object and set its properties
                DataGridViewColumn column1 = new DataGridViewColumn();
                column1.HeaderText = "Product ID";
                column1.Name = "ProductIDColumn";
                column1.CellTemplate = new DataGridViewTextBoxCell();

                // Add the column to the Columns collection of the DataGridView control
                gvShoppingCart.Columns.Add(column1);

                // Repeat the process for each additional column you want to add
                DataGridViewColumn column2 = new DataGridViewColumn();
                column2.HeaderText = "Product Name";
                column2.Name = "ProductNameColumn";
                column2.CellTemplate = new DataGridViewTextBoxCell();
                gvShoppingCart.Columns.Add(column2);

                // etc.
                DataGridViewColumn column3 = new DataGridViewColumn();
                column3.HeaderText = "Product Price";
                column3.Name = "ProductPriceColumn";
                column3.CellTemplate = new DataGridViewTextBoxCell();
                gvShoppingCart.Columns.Add(column3);


                DataGridViewColumn column4 = new DataGridViewColumn();
                column4.HeaderText = "Quantity";
                column4.Name = "ProductQuantityColumn";
                column4.CellTemplate = new DataGridViewTextBoxCell();
                gvShoppingCart.Columns.Add(column4);

                DataGridViewColumn column5 = new DataGridViewColumn();
                column5.HeaderText = "total";
                column5.Name = "ProductTotalColumn";
                column5.CellTemplate = new DataGridViewTextBoxCell();
                gvShoppingCart.Columns.Add(column5);

                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(gvShoppingCart);
                //addRow.Cells[0].Value = "Test";
                addRow.Cells[0].Value = textBoxProductID.Text; // burada hata veriyor
                addRow.Cells[1].Value = textBoxProductName.Text;
                addRow.Cells[2].Value = textBoxProductPrice.Text;
                addRow.Cells[3].Value = textBoxQuantity.Text;
                addRow.Cells[4].Value = Convert.ToDouble(total_amount);
                gvShoppingCart.Rows.Add(addRow);

                //var selected_rows = (from p in trendyolEntities.products
                //                       join c in trendyolEntities.categories on p.CategoryID equals c.CategoryID
                //                       where c.CategoryName == 
                //                       select new
                //                       {
                                        
                //                       }).ToList();
                //gvProductList.DataSource = selected_rows;

                customerCash = customerCash - Convert.ToDouble(total_amount);
                trendyolEntities.customers.Where(p => p.CustomerID == cust_id).ToList().ForEach(x => x.Cash = customerCash);

                int stok_amount = Convert.ToInt32(quantity);
                Console.WriteLine("stok_amount : " + stok_amount);


                foreach (product i in query)
                {

                    if (i.stock <= 0 || i.stock - Convert.ToInt32(textBoxQuantity.Text) <= 0)
                    {


                        MessageBox.Show("No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }

                    i.stock -= stok_amount;



                    //trendyolDBEntities.SaveChanges();

                }

                textBoxcash.Text = Convert.ToString(customerCash);

                trendyolEntities.SaveChanges();
            }

            n++;
        }

    }
}
