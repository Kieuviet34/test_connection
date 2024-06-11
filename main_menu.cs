using cap_nhat_danh_sach_sinh_vien;
using me_may_bel_cee_suck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mainform f1  = new mainform();
            f1.Show();
            this.Hide();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mẹ mày béo", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_sinhvien sv = new frm_sinhvien();
            sv.Show();
            this.Hide();
        }

        

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
