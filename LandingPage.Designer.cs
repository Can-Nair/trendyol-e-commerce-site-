namespace trendyol
{
    partial class LandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerEnter = new System.Windows.Forms.Button();
            this.supplierEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Button();
            this.cbShipperPath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // customerEnter
            // 
            this.customerEnter.Location = new System.Drawing.Point(266, 398);
            this.customerEnter.Name = "customerEnter";
            this.customerEnter.Size = new System.Drawing.Size(162, 90);
            this.customerEnter.TabIndex = 0;
            this.customerEnter.Text = "Müşteri";
            this.customerEnter.UseVisualStyleBackColor = true;
            this.customerEnter.Click += new System.EventHandler(this.customerEnter_Click);
            // 
            // supplierEnter
            // 
            this.supplierEnter.Location = new System.Drawing.Point(576, 398);
            this.supplierEnter.Name = "supplierEnter";
            this.supplierEnter.Size = new System.Drawing.Size(162, 90);
            this.supplierEnter.TabIndex = 1;
            this.supplierEnter.Text = "Tedarikçi";
            this.supplierEnter.UseVisualStyleBackColor = true;
            this.supplierEnter.Click += new System.EventHandler(this.supplierEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 128);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRENDYOL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MV Boli", 58F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(297, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 128);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alışveriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(186, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aşağıdan hesap türünüzü seçip giriş yapabilirsiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(345, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hala hesabınız yok mu?";
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(425, 596);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(162, 90);
            this.signUp.TabIndex = 6;
            this.signUp.Text = "Kayıt OL";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // cbShipperPath
            // 
            this.cbShipperPath.AutoSize = true;
            this.cbShipperPath.Location = new System.Drawing.Point(448, 291);
            this.cbShipperPath.Name = "cbShipperPath";
            this.cbShipperPath.Size = new System.Drawing.Size(139, 20);
            this.cbShipperPath.TabIndex = 7;
            this.cbShipperPath.Text = "Become a shipper";
            this.cbShipperPath.UseVisualStyleBackColor = true;
            this.cbShipperPath.CheckedChanged += new System.EventHandler(this.cbShipperPath_CheckedChanged);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 710);
            this.Controls.Add(this.cbShipperPath);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplierEnter);
            this.Controls.Add(this.customerEnter);
            this.Name = "LandingPage";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerEnter;
        private System.Windows.Forms.Button supplierEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.CheckBox cbShipperPath;
    }
}

