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

namespace me_may_bel_cee_suck
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_main f1 = new frm_main();
            f1.Show();
        }
    }
}
