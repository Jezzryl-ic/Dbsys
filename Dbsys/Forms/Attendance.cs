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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Employee_Dashboard Frl = new Frm_Employee_Dashboard();
            Frl.Show();
            this.Hide();
        }
    }
}
