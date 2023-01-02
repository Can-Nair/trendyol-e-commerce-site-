namespace trendyol
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.supplierCheckBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(77, 183);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "change";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(65, 129);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(100, 22);
            this.tbNewPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your new password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(65, 85);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // supplierCheckBox2
            // 
            this.supplierCheckBox2.AutoSize = true;
            this.supplierCheckBox2.Location = new System.Drawing.Point(63, 157);
            this.supplierCheckBox2.Name = "supplierCheckBox2";
            this.supplierCheckBox2.Size = new System.Drawing.Size(116, 20);
            this.supplierCheckBox2.TabIndex = 7;
            this.supplierCheckBox2.Text = "I am a supplier";
            this.supplierCheckBox2.UseVisualStyleBackColor = true;
            this.supplierCheckBox2.CheckedChanged += new System.EventHandler(this.supplierCheckBox2_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 214);
            this.Controls.Add(this.supplierCheckBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.CheckBox supplierCheckBox2;
    }
}