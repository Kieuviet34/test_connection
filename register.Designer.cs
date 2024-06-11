namespace UD1
{
    partial class register
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirmpass = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_regist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_showpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(144, 25);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(472, 34);
            this.txt_email.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(144, 65);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(472, 34);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(144, 105);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(472, 34);
            this.txt_password.TabIndex = 2;
            // 
            // txt_confirmpass
            // 
            this.txt_confirmpass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpass.Location = new System.Drawing.Point(144, 145);
            this.txt_confirmpass.Name = "txt_confirmpass";
            this.txt_confirmpass.PasswordChar = '*';
            this.txt_confirmpass.Size = new System.Drawing.Size(472, 34);
            this.txt_confirmpass.TabIndex = 3;
            this.txt_confirmpass.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(324, 225);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(292, 34);
            this.txt_phone.TabIndex = 4;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(144, 185);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(472, 34);
            this.txt_address.TabIndex = 5;
            // 
            // btn_regist
            // 
            this.btn_regist.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regist.Location = new System.Drawing.Point(144, 265);
            this.btn_regist.Name = "btn_regist";
            this.btn_regist.Size = new System.Drawing.Size(240, 87);
            this.btn_regist.TabIndex = 6;
            this.btn_regist.Text = "Đăng kí";
            this.btn_regist.UseVisualStyleBackColor = true;
            this.btn_regist.Click += new System.EventHandler(this.btn_regist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "số điện thoại";
            // 
            // chk_showpass
            // 
            this.chk_showpass.AutoSize = true;
            this.chk_showpass.Location = new System.Drawing.Point(144, 234);
            this.chk_showpass.Name = "chk_showpass";
            this.chk_showpass.Size = new System.Drawing.Size(111, 20);
            this.chk_showpass.TabIndex = 13;
            this.chk_showpass.Text = "hiện mật khẩu";
            this.chk_showpass.UseVisualStyleBackColor = true;
            this.chk_showpass.CheckedChanged += new System.EventHandler(this.chk_showpass_CheckedChanged);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_showpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regist);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_confirmpass);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_email);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_confirmpass;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_regist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_showpass;
    }
}