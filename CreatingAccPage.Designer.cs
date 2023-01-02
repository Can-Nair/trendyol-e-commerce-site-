namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Şifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.TamAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Şehir = new System.Windows.Forms.TextBox();
            this.PostaKod = new System.Windows.Forms.TextBox();
            this.Ülke = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tedarikçi = new System.Windows.Forms.CheckBox();
            this.Yarat = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni hesap";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.Location = new System.Drawing.Point(191, 130);
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.Size = new System.Drawing.Size(254, 22);
            this.KullanıcıAdı.TabIndex = 1;
            this.KullanıcıAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı(*):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre(*):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Şifre
            // 
            this.Şifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Şifre.Location = new System.Drawing.Point(191, 158);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(254, 22);
            this.Şifre.TabIndex = 4;
            this.Şifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(108, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adres:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(191, 186);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(254, 22);
            this.Adres.TabIndex = 6;
            this.Adres.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TamAd
            // 
            this.TamAd.Location = new System.Drawing.Point(191, 102);
            this.TamAd.Name = "TamAd";
            this.TamAd.Size = new System.Drawing.Size(254, 22);
            this.TamAd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tam Ad(*):";
            // 
            // Şehir
            // 
            this.Şehir.Location = new System.Drawing.Point(191, 214);
            this.Şehir.Name = "Şehir";
            this.Şehir.Size = new System.Drawing.Size(254, 22);
            this.Şehir.TabIndex = 9;
            // 
            // PostaKod
            // 
            this.PostaKod.Location = new System.Drawing.Point(191, 242);
            this.PostaKod.Name = "PostaKod";
            this.PostaKod.Size = new System.Drawing.Size(254, 22);
            this.PostaKod.TabIndex = 10;
            this.PostaKod.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Ülke
            // 
            this.Ülke.Location = new System.Drawing.Point(191, 270);
            this.Ülke.Name = "Ülke";
            this.Ülke.Size = new System.Drawing.Size(254, 22);
            this.Ülke.TabIndex = 11;
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(191, 298);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(254, 22);
            this.Telefon.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Şehir:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(67, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Posta Kodu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(117, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ülke:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefon Numarası:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Tedarikçi
            // 
            this.Tedarikçi.AutoSize = true;
            this.Tedarikçi.Location = new System.Drawing.Point(191, 378);
            this.Tedarikçi.Name = "Tedarikçi";
            this.Tedarikçi.Size = new System.Drawing.Size(136, 20);
            this.Tedarikçi.TabIndex = 17;
            this.Tedarikçi.Text = "Tedarikçi misiniz?";
            this.Tedarikçi.UseVisualStyleBackColor = true;
            this.Tedarikçi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Yarat
            // 
            this.Yarat.Location = new System.Drawing.Point(191, 415);
            this.Yarat.Name = "Yarat";
            this.Yarat.Size = new System.Drawing.Size(75, 23);
            this.Yarat.TabIndex = 18;
            this.Yarat.Text = " Yarat";
            this.Yarat.UseVisualStyleBackColor = true;
            this.Yarat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(191, 340);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(117, 20);
            this.Admin.TabIndex = 19;
            this.Admin.Text = "Admin misiniz?";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Yarat);
            this.Controls.Add(this.Tedarikçi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Ülke);
            this.Controls.Add(this.PostaKod);
            this.Controls.Add(this.Şehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TamAd);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Şifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KullanıcıAdı);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KullanıcıAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Şifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TamAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Şehir;
        private System.Windows.Forms.TextBox PostaKod;
        private System.Windows.Forms.TextBox Ülke;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Tedarikçi;
        private System.Windows.Forms.Button Yarat;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.CheckBox Admin;
    }
}

