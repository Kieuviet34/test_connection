namespace me_may_bel_cee_suck
{
    partial class loginform
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.chk_remember = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.chk_showpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_log.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(395, 85);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(380, 34);
            this.txt_log.TabIndex = 2;
            this.txt_log.TextChanged += new System.EventHandler(this.txt_log_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(395, 139);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(380, 34);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // chk_remember
            // 
            this.chk_remember.AutoSize = true;
            this.chk_remember.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_remember.Location = new System.Drawing.Point(395, 216);
            this.chk_remember.Name = "chk_remember";
            this.chk_remember.Size = new System.Drawing.Size(138, 29);
            this.chk_remember.TabIndex = 4;
            this.chk_remember.Text = "remember";
            this.chk_remember.UseVisualStyleBackColor = true;
            this.chk_remember.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(272, 272);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 35);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(485, 272);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 35);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "memaybel";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(661, 272);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(114, 35);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "register";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // chk_showpass
            // 
            this.chk_showpass.AutoSize = true;
            this.chk_showpass.Location = new System.Drawing.Point(607, 216);
            this.chk_showpass.Name = "chk_showpass";
            this.chk_showpass.Size = new System.Drawing.Size(169, 30);
            this.chk_showpass.TabIndex = 8;
            this.chk_showpass.Text = "Hiện mật khẩu";
            this.chk_showpass.UseVisualStyleBackColor = true;
            this.chk_showpass.CheckedChanged += new System.EventHandler(this.chk_showpass_CheckedChanged);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.chk_showpass);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.chk_remember);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "loginform";
            this.Text = "memaybel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.CheckBox chk_remember;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.CheckBox chk_showpass;
    }
}

