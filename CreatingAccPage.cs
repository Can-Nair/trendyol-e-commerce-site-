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
using System.Xml;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yaratma tuşunun olduğu bölme
            
            String username = KullanıcıAdı.Text.Trim();
            String password = Şifre.Text.Trim();
            String customerName = TamAd.Text.Trim();
            String address = Adres.Text.Trim();
            String postCode = PostaKod.Text.Trim();
            String city = Şehir.Text.Trim();
            String country = Ülke.Text.Trim();
            String telno = Telefon.Text.Trim();
            Boolean isSeller = Tedarikçi.Checked;
            Boolean isAdmin = Admin.Checked;
            var isValid = true;

            SHA256 sha = SHA256.Create();
            // Encrypting the password
            byte[] data =  sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();

            for(int i=0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

                var hashed_password = sBuilder.ToString();
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                isValid = false;
                MessageBox.Show("Missing required information. Try again.")
            }
            if (isValid == true) {
                MessageBox.Show($"Hesabınız başarıyla yaratıldı {KullanıcıAdı.Text}!\n\r" +
                 $"Kullanıcı adınız : {username}\n\r" +
                   $"Şifreniz : {password}\n\r");
                
            }   
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
