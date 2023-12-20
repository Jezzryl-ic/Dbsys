using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class PermissionLeave : Form
    {
        public PermissionLeave()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Frm_Manager_DashBoard Frl = new Frm_Manager_DashBoard();
            Frl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Manager_DashBoard Frl = new Frm_Manager_DashBoard();
            Frl.Show();
            this.Hide();
        }
    }
}
