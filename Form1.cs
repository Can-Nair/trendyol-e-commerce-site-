using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace CustomerPanel
{
    public partial class Form1 : Form
    {
        private readonly trendyolDemoEntities trendyolDemoDBEntities;
        
        public Form1()
        {

            InitializeComponent();
            trendyolDemoDBEntities = new trendyolDemoEntities();
            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxCustomerID.Text = Convert.ToString(4);
            var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            textBoxcash.Text = Convert.ToString((from q in trendyolDemoDBEntities.customers where q.CustomerID == cust_id select q.cash).Single());

            //var customerCash = from q in trendyolDemoDBEntities.customers where q.CustomerID == Convert.ToInt32(textBoxCustomerID.Text) select q.cash;

        }

        void loadData() {

            var st = from s in trendyolDemoDBEntities.products select s;
            gvShoppingCart.DataSource = st;
            
        }

        int grandTotal = 0, n = 0;
        //int total_amount = 0;
        Decimal Account = 0;

        private void button1_Click(object sender, EventArgs e) 
        {
            DateTime orderDate = DateTime.Parse(textBoxDate.Text);
            //Account = Convert.ToDecimal(textBoxcash.Text);
            //var prodID = from i in trendyolDemoDBEntities.products where i.ProductName == textBoxpname.Text select i.ProductID;
            //ÇALIŞTI
            
            var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            //var customerCash = Convert.ToInt32((from q in trendyolDemoDBEntities.customers where q.CustomerID == cust_id select q.cash).Single());
            var customerCash = Convert.ToDouble((from q in trendyolDemoDBEntities.customers where q.CustomerID == cust_id select q.cash).Single());

            //textBoxcash.Text = Convert.ToString(customerCash);
            //textBoxcash.Text = Convert.ToString((from q in trendyolDemoDBEntities.customers where q.CustomerID == cust_id select q.cash).Single());

            //var customerCash = from q in trendyolDemoDBEntities.customers where q.Username == "Alfred" select q.cash;

            //ÇALIŞTI
            //total_amount = Convert.ToInt32(textBoxpprice.Text) * Convert.ToInt32(textBoxqname.Text);

            //ADD TO SQL TABLE

            /*var order_date = from p in trendyolDemoDBEntities.orders
                             join c in trendyolDemoDBEntities.customers on p.CustomerID equals c.CustomerID
                             select new
                             {
                                 //OrderDate = p.OrderDate,
                                 OrderDate = p.OrderDate
                             };*/
            //DateTime enteredDate = DateTime.Parse(Convert.ToString(order_date));


            order add_order = new order();
            add_order.OrderID = n;
            add_order.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
            //add_order.OrderDate = orderDate;
            add_order.OrderDate = orderDate;

            //add_order.ShipperID = 1;
            trendyolDemoDBEntities.orders.Add(add_order);
            //trendyolDemoDBEntities.SaveChanges();

            order_details order_items = new order_details();
            order_items.Quantity = Convert.ToInt32(textBoxqname.Text);
            //order_items.OrderID = n + 1;
            //order_items.OrderID = trendyolDemoDBEntities.orders.OrderID;
            // order_items.OrderID = Convert.ToInt32(trendyolDemoDBEntities.orders.Select(o => o.OrderID).ToString());
            //order_items.OrderID = Convert.ToInt32(from o in trendyolDemoDBEntities.orders select o.OrderID);
            order_items.OrderID = add_order.OrderID;

            //order_items.OrderDetailID = n + 1;
            order_items.OrderDetailID = n;

            order_items.ProductID = trendyolDemoDBEntities.products.First(a => a.ProductName == textBoxpname.Text).ProductID;
            var totalAmount = (from p in trendyolDemoDBEntities.customers
                               join c in trendyolDemoDBEntities.orders on p.CustomerID equals c.CustomerID
                               join a in trendyolDemoDBEntities.order_details on c.OrderID equals a.OrderID
                               join d in trendyolDemoDBEntities.products on a.ProductID equals d.ProductID
                               where d.ProductID == order_items.ProductID
                               select new
                               {
                                   //Quantity = a.Quantity,
                                   //TotalAmount = a.Quantity * Convert.ToInt32(textBoxpprice.Text)
                                   TotalAmount = (order_items.Quantity * d.Price)
                               });
            Console.WriteLine("Quantity :" + order_items.Quantity);
            Console.WriteLine("Product ID :" + order_items.ProductID);

            trendyolDemoDBEntities.order_details.Add(order_items);

            // ORDER - DATE- JOIN

            /*var order_date = from p in trendyolDemoDBEntities.orders
                             join c in trendyolDemoDBEntities.customers on p.CustomerID equals c.CustomerID
                             select new
                             {
                                 //OrderDate = p.OrderDate,
                                 OrderDate = p.OrderDate
                         }.ToString();*/

            /*order_date.ToList().ForEach(x =>
            {
                Console.WriteLine($"OrderDate: {x.OrderDate}");
            });*/


            // TOTAL - AMOUNT - JOIN
            //List<int> last_element_total = new List<int>();


            /*var totalAmount = (from p in trendyolDemoDBEntities.customers
                             join c in trendyolDemoDBEntities.orders on p.CustomerID equals c.CustomerID
                             join a in trendyolDemoDBEntities.order_details on c.OrderID equals a.OrderID
                             join d in trendyolDemoDBEntities.products on a.ProductID equals d.ProductID

                              select new
                             {
                                  //Quantity = a.Quantity,
                                  //TotalAmount = a.Quantity * Convert.ToInt32(textBoxpprice.Text)
                                  TotalAmount = (a.Quantity * d.Price)
                              });*/

            foreach (var item in totalAmount)
            {
                Console.WriteLine("total : "+ item.TotalAmount);
                //trendyolDemoDBEntities.order_details.Remove(item.od_order_id);
                //trendyolDemoDBEntities.orders.Remove(item.order_id);
            }
            //Console.WriteLine("Last total : " + Convert.ToDouble(totalAmount.));
            //var tot_result = ((from l in totalAmount orderselect l.TotalAmount).OrderBy(l => l.To)).FirstOrDefault();
            var total_amount = (from l in totalAmount orderby l.TotalAmount  select l.TotalAmount).First();

            Console.WriteLine("Last total : " + total_amount);

            /*totalAmount.ToList().ForEach(x =>
            {
                //Console.WriteLine($"totalAmount: {x.TotalAmount}");
            });*/

            //totalAmount.Last().ToString();



            //int Total = Convert.ToInt32(textBoxpprice.Text) * Convert.ToInt32(textBoxqname.Text);
            //Decimal Account = 0;
            /*if (Convert.ToInt32(textBoxqname.Text) <= 0 )
            {
                MessageBox.Show("No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                total_amount = Convert.ToInt32(textBoxpprice.Text) * Convert.ToInt32(textBoxqname.Text);
            }*/



            var p_name = textBoxpname.Text;
            var quantity = textBoxqname.Text;

            //ÇALIŞTI
            //var product = trendyolDBEntities.products.Single(x => x.ProductName.Equals(p_name));
            //Console.WriteLine("product name : ", product);


            var query = from ord in trendyolDemoDBEntities.products where ord.ProductName == p_name select ord;
            var product_stock = 0;

            /*if (textBoxcash.Text == "")
            {
                MessageBox.Show("Enter Money", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }*/

            if (textBoxcash.Text == "" || textBoxpname.Text == "" || textBoxqname.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Enter Money", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            //Decimal Account = Convert.ToDecimal(textBoxcash.Text);

            foreach (product i in query)
            {
                product_stock = i.stock;
                //Console.WriteLine("Stock : ", product_stock);
            }

            if (Convert.ToInt32(textBoxqname.Text) > product_stock  || (product_stock - Convert.ToInt32(textBoxqname.Text)) < 0)
            {
                MessageBox.Show("No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            // ishidden && isappropriate
            var category_name = cbCategoryType.Text;
            var is_appropriate = Convert.ToInt32((from q in trendyolDemoDBEntities.categories where q.CategoryName == category_name join p in trendyolDemoDBEntities.products on q.CategoryID equals p.CategoryID select p.isInappropriate).Single());
            var is_hidden = Convert.ToInt32((from q in trendyolDemoDBEntities.categories where q.CategoryName == category_name join p in trendyolDemoDBEntities.products on q.CategoryID equals p.CategoryID select p.isHidden).Single());

            if (is_appropriate == 1 && is_hidden == 1)
            {
                MessageBox.Show("It is hidden to buy. You cannot buy this product", "Window Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

         
            //total_amount = Convert.ToInt32(textBoxpprice.Text) * Convert.ToInt32(textBoxqname.Text);



            /*if (textBoxpname.Text == "" || textBoxqname.Text == "" ) {

                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/


            else
            {

                //Decimal Account = Convert.ToDecimal(textBoxcash.Text);
                //KAPANDI
                //Account = Convert.ToDecimal(textBoxcash.Text);
                
                foreach (product i in query)
                {
                    product_stock = i.stock;
                    //Console.WriteLine("Stock : ", product_stock);
                }


                /*if (Account <= 0 || Account - total_amount <= 0)
                {

                    MessageBox.Show("No Money or No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }*/
                if (customerCash <= 0 || customerCash - total_amount <= 0)
                {

                    MessageBox.Show("No Money or No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                //total_amount = Convert.ToInt32(textBoxpprice.Text) * Convert.ToInt32(textBoxqname.Text);

                /*if (Convert.ToInt32(textBoxqname.Text) > product_stock)
                {
                    MessageBox.Show("No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }*/


                // BAKKKKKK
                //var result = (from i in totalAmount select i).Last();
                //var result = Convert.ToInt32(totalAmount.ToList().Last());
                //Console.WriteLine("Last : ", result);

                //int Total = Convert.ToInt32(textBoxpprice.Text) * Convert.ToInt32(textBoxqname.Text);
                //Console.WriteLine("Total : ", Total);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(gvShoppingCart);
                //addRow.Cells[0].Value = ++n;
                addRow.Cells[0].Value = textBoxpid.Text;
                addRow.Cells[1].Value = textBoxpname.Text;
                addRow.Cells[2].Value = textBoxpprice.Text;
                addRow.Cells[3].Value = textBoxqname.Text;
                //addRow.Cells[4].Value = total_amount;
                //addRow.Cells[4].Value = Convert.ToInt32(totalAmount.Last().ToString());
                addRow.Cells[4].Value = Convert.ToDouble(total_amount);
                gvShoppingCart.Rows.Add(addRow);
                //grandTotal += total_amount;
                //Account = Account - total_amount;
                customerCash = customerCash - Convert.ToDouble(total_amount);
                //textBoxcash.Text = Convert.ToString(customerCash);
                trendyolDemoDBEntities.customers.Where(p => p.CustomerID == cust_id).ToList().ForEach(x => x.cash = customerCash);
                //Account = Account - Convert.ToInt32(totalAmount.Last().ToString());
                //Account = Account - ((from i in totalAmount select i).Last());
                //Account = Account - Convert.ToInt32(result);

                //textBoxcash.Text = Account.ToString();
                //textBoxcash.Text = customerCash.ToString();
                //int stok_amount = Math.Abs(Convert.ToInt32(addRow.Cells["ProductQuantity"].Value));
                int stok_amount = Convert.ToInt32(quantity);
                Console.WriteLine("stok_amount : "+ stok_amount);
                //ÇALIŞTI
                //product.stock -= Convert.ToInt32(textBoxqname.Text);

                foreach (product i in query)
                {

                    if (i.stock <= 0 || i.stock - Convert.ToInt32(textBoxqname.Text) <= 0)
                    {


                        MessageBox.Show("No Stock", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }

                    i.stock -= stok_amount;



                    //trendyolDBEntities.SaveChanges();

                }
                //gvProductList.DataSource = query;
                textBoxcash.Text = Convert.ToString(customerCash);

                trendyolDemoDBEntities.SaveChanges();

            }

            n++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var categories = trendyolDBEntities.categories.ToList();
            cbCategoryType.DisplayMember = "CategoryName";
            cbCategoryType.ValueMember = "CategoryID";
            cbCategoryType.DataSource = categories;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var categories = trendyolDemoDBEntities.categories.ToList();
            cbCategoryType.DisplayMember = "CategoryName";
            cbCategoryType.ValueMember = "CategoryID";
            cbCategoryType.DataSource = categories;
            trendyolDemoDBEntities.SaveChanges();

            /*DataGridViewCheckBoxColumn chxbox = new DataGridViewCheckBoxColumn();
            //chxbox.HeaderText = "Select";
            chxbox.Name = "ProductCheckBox";
            gvProductList.Columns.Insert(0, chxbox);*/

        }

        private void gvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var categories = trendyolDBEntities.categories.ToList();
            //gvProductList.DataSource = categories;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
    
            var category_name = cbCategoryType.Text;
            //if (category_name.Text == "")
            var is_appropriate = Convert.ToInt32((from q in trendyolDemoDBEntities.categories where q.CategoryName == category_name join p in trendyolDemoDBEntities.products on q.CategoryID equals p.CategoryID select p.isInappropriate).Single());
            if (is_appropriate == 1 )
            {
                MessageBox.Show("+18 Staff", "Window Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            Console.WriteLine(category_name);
            var catID = trendyolDemoDBEntities.categories.Where(x => x.CategoryName == category_name).Select(x => x.CategoryID).ToList();
            int i = catID[0];
            Console.WriteLine(i);
            var prd = trendyolDemoDBEntities.products.Where(q => q.CategoryID == i).Select(q => new { q.ProductID, q.ProductName, q.SupplierID, q.CategoryID, q.stock, q.Price }).ToList();
            gvProductList.DataSource = prd.ToList();
    



        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) {


            //ÇALIŞTI
            //gvShoppingCart.Rows.RemoveAt(gvShoppingCart.SelectedRows[0].Index);


            int rowIndex = gvShoppingCart.CurrentCell.RowIndex;
            Console.WriteLine("row index : "+ rowIndex);
            int p_id = Convert.ToInt32(gvShoppingCart.CurrentRow.Cells["ProductID"].Value);

            //ÇALIŞTI
            //int p_id = Convert.ToInt32(gvShoppingCart.CurrentRow.Cells["ProductID"].Value);
            // Console.WriteLine("p_id : " + p_id);

            //var od_query = trendyolDemoDBEntities.order_details.Where(w => w.ProductID == rowIndex);

            //ÇALIŞTI
            //var od_query2 = trendyolDemoDBEntities.order_details.Where(w => w.ProductID == p_id).FirstOrDefault();

            //var query2 = trendyolDemoDBEntities.orders.Where(o => o.OrderID == Convert.ToInt32(od_query.Select(w => w.OrderID))).FirstOrDefault();
            //var q3 = (od_query.Select(w => w.OrderID)).First();
            //var query2 = trendyolDemoDBEntities.orders.Single(o => o.OrderID == q3);
            //ÇALIŞTI
            //trendyolDemoDBEntities.order_details.Remove(od_query2);

            //trendyolDemoDBEntities.orders.Remove(query2);

            DataGridViewRow row = gvShoppingCart.Rows[rowIndex];

            string p_name = Convert.ToString(row.Cells["ProductName"].Value);
            //int p_price = Convert.ToInt32(row.Cells["ProductPrice"].Value);
            
            //int p_price = Convert.ToInt32(row.Cells["ProductPrice"].Value);
            //Çalıştı
            var p_price = Convert.ToDouble((from p in trendyolDemoDBEntities.products where p.ProductID == p_id select p.Price).Single());
            Console.WriteLine("p_price : " + p_price);
            //var p_price = Convert.ToInt32(trendyolDemoDBEntities.products.Where(p => p.ProductID == p_id).Select(p => p.Price).OrderByDescending(p => p)  LastOrDefault());

            int stok_amount = Convert.ToInt32(row.Cells["ProductQuantity"].Value);

            gvShoppingCart.Rows.RemoveAt(rowIndex);

            var query = from ord in trendyolDemoDBEntities.products where ord.ProductName == p_name select ord;
            foreach (product i in query)
            {
                i.stock += stok_amount;
            }

            var total_cash = Convert.ToDouble(textBoxcash.Text);
            total_cash += (p_price * stok_amount);
            textBoxcash.Text = Convert.ToString(total_cash);
            //textBoxcash.Text += p_price.ToString();

            // EKLENDİ
            var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            trendyolDemoDBEntities.customers.Where(p => p.CustomerID == cust_id).ToList().ForEach(x => x.cash = total_cash);

            //var deleteuser = trendyolDemoDBEntities.order_details.FirstOrDefault(e => e.ProductID == p_id);

            //int p_id = Convert.ToInt32(gvShoppingCart.CurrentRow.Cells["ProductID"].Value);
            Console.WriteLine("p_id : " + p_id);
            //https://www.codeproject.com/Questions/5322110/How-to-delete-from-bridge-table-using-LINQ-in-Csha
            var deleted_rows = (from od in trendyolDemoDBEntities.order_details
                          join o in trendyolDemoDBEntities.orders on od.OrderID equals o.OrderID
                          where   od.ProductID == p_id
                          //select new { order_id = o.OrderID, order_details_order_id = od.OrderID }).FirstOrDefault();
                          select new {order_id = o, od_order_id = od });
            foreach (var item in deleted_rows)
            {
                trendyolDemoDBEntities.order_details.Remove(item.od_order_id);
                trendyolDemoDBEntities.orders.Remove(item.order_id);
            }
            //var od_query2 = trendyolDemoDBEntities.order_details.Where(w => w.ProductID == p_id).FirstOrDefault();
            //trendyolDemoDBEntities.order_details.Remove(od_query2);
            //trendyolDemoDBEntities.order_details.Remove(deleted_rows);
            trendyolDemoDBEntities.SaveChanges();





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxcash_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            /*if (textBoxpname.Text == "" || textBoxpprice.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }*/

            /*if (textBoxpname.Text == "" || textBoxpprice.Text == "" || textBoxpid.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }*/
            textBoxpname.Text = gvProductList.SelectedRows[0].Cells["ProductName"].Value.ToString();
            textBoxpprice.Text = gvProductList.SelectedRows[0].Cells["Price"].Value.ToString();
            textBoxpid.Text = gvProductList.SelectedRows[0].Cells["ProductID"].Value.ToString();
            textBoxqname.Clear();

            //var cust_id = Convert.ToInt32(textBoxCustomerID.Text);
            //textBoxcash.Text = Convert.ToString((from q in trendyolDemoDBEntities.customers where q.CustomerID == cust_id select q.cash).Single());
            //gvProductList.Update();
            //gvProductList.Refresh();
            //gvProductList.Refresh();
        }
    }
}
