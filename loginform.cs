using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UD1;
using System.Data.SqlClient;

namespace me_may_bel_cee_suck
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void txt_log_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_log.Text;
            string password = txt_pass.Text;
            string connection = "Data Source=MSI;Initial Catalog=test_db;Persist Security Info=True;" +
                "User ID=sa;Password=1234;";
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                string query = "select count(*) from users where username = @name and user_password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("password", password);

                int userCnt = (int)cmd.ExecuteScalar();

                if (userCnt > 0)
                {
                    this.Hide();
                    frm_main main = new frm_main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
                throw;
            }

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            this.txt_log.Text = "";
            this.txt_pass.Text = "";
            this.txt_log.Focus();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.Hide();
            register regist = new register();
            regist.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_showpass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }
    }
}
