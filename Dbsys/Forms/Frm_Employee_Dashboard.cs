using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Dbsys.Forms
{
    public partial class Frm_Employee_Dashboard : Form
    {
        UserRepository userRepo;
   
        public Frm_Employee_Dashboard()
        {
            InitializeComponent();
            // Initialize the user repository


        }


        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Login Frl = new Frm_Login();
            Frl.Show();
            this.Hide();
        }

        private void dataGridView23_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {

            // Initialize the user repository
            userRepo = new UserRepository();
            dataGridView23.DataSource = userRepo.View_Employee();
        //    loadUser();
        //}

        //private void loadUser()
        //{
        //    dataGridView23.DataSource = userRepo.UserAccounts();
        //    loadUser();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendance Frl = new Attendance();
            Frl.Show();
            this.Hide();
        }

        private void dataGridView23_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        //    try
        //    {
        //        userSelectedId = (Int32)dataGridView23.Rows[e.RowIndex].Cells[0].Value;
        //        txtAccnumbe = (TextBox)dataGridView23.Rows[e.RowIndex].Cells[1].Value;
        //        txtName.Text = dataGridView23.Rows[e.RowIndex].Cells[2].Value as String;
        //        txtEmail.Text = dataGridView23.Rows[e.RowIndex].Cells[3].Value as String;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Exception : {ex.Message}");
        //    }
        }
    }
}


