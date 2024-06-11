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
using UD1;

namespace cap_nhat_danh_sach_sinh_vien
    {
        public partial class frm_sinhvien : Form
        {
            public frm_sinhvien()
            {
                InitializeComponent();
            }

            private void btn_exit_Click(object sender, EventArgs e)
            {
                this.Close();
                frm_main f1 = new frm_main();
                f1.Show();
            }

            
        private void btn_update_Click(object sender, EventArgs e)   
        {
            string name = txt_name.Text;
            string email = txt_email.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string classname = txt_classname.Text;
            string classcode = txt_classcode.Text;
            string password = txt_password.Text;
            string connection = "Data Source=MSI;Initial Catalog=test_db;User ID=sa;Password=1234;";
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(address)||
                string.IsNullOrEmpty(phone)|| string.IsNullOrEmpty(classname)||
                string.IsNullOrEmpty(classcode)||
                string.IsNullOrEmpty(password))
            {            
                MessageBox.Show("Vui long nhap thong tin hoc sinh", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                
            }
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();

                string masv;
                using (SqlCommand command = new SqlCommand("GenerateStudentID", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    masv = (string)command.ExecuteScalar();
                }

                string query = "INSERT INTO sinh_vien (student_id, student_name, student_address, email, student_phone, student_password, student_class, class_code) " +
                                   "VALUES (@StudentID, @Name, @Address, @Email, @Phone, @Password, @Classname, @Classcode)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", masv);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Classname", classname);
                    cmd.Parameters.AddWithValue("@Classcode", classcode);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Thêm sinh viên thành công! ID của sinh viên là: {masv}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
                throw;
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_phone.Clear();
            txt_classname.Clear();
            txt_classcode.Clear();
            txt_password.Clear();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
