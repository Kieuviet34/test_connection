using me_may_bel_cee_suck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string confirmpass = txt_confirmpass.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string connection = "Data Source=MSI;Initial Catalog=test_db;Persist Security Info=True;" +
                "User ID=sa;Password=1234;";
            if (password != confirmpass)
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();

                string query = "INSERT INTO users (email, username, user_address, user_password, phone) " +
                                  "OUTPUT INSERTED.id " +
                                  "VALUES (@Email, @Username, @Address, @Password, @Phone)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Phone", phone);

                int userId = (int)cmd.ExecuteScalar();
                MessageBox.Show($"Đăng kí thành công, id của bạn là: {userId}");

                this.Hide();
                loginform loginform = new loginform();
                loginform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occur " + ex.Message);
                throw;
            }
        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showpass.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_confirmpass.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
                txt_confirmpass.PasswordChar= '*';
            }
        }
    }
}
