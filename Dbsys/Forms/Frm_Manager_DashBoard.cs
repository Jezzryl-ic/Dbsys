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
    public partial class Frm_Manager_DashBoard : Form
    {
        UserRepository userRepo;
        public Frm_Manager_DashBoard()
        {
            InitializeComponent();
        }

        private void Frm_Teacher_DashBoard_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepository();

            dgv_main2.DataSource = userRepo.View_Manager_2();

        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login Frl = new Frm_Login();
            Frl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmAtt Frl = new ConfirmAtt();
            Frl.Show();
            this.Hide();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmAtt Frl = new ConfirmAtt();
            Frl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
               PermissionLeave Frl = new PermissionLeave();
                        Frl.Show();
                        this.Hide();
        }
    }

}
