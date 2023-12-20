using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;

namespace Dbsys.Forms
{
    public partial class Frm_Register : Form
    {
        public bool hasChange = false;
        private string IMG_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image");
        public string username = string.Empty;
        private DBSYSEntities db;

        public Frm_Register()
        {
            InitializeComponent();
            if (!Directory.Exists(IMG_PATH))
                Directory.CreateDirectory(IMG_PATH);

            db = new DBSYSEntities();
        }
        //public string username = String.Empty;
        //DBSYSEntities db; 
        //public Frm_Register()
        //{
        //    InitializeComponent();
        //    //
        //  db = new DBSYSEntities();
        //}

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
        }

        private void cbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Role.ToList();

            cbBoxRole.ValueMember = "roleId";
            cbBoxRole.DisplayMember = "roleName";
            cbBoxRole.DataSource = roles;
            cbBoxRole.DisplayMember = "accountNumber";
            cbBoxRole.DisplayMember = "phoneNumber";
            cbBoxRole.DisplayMember = "email";
            cbBoxRole.DisplayMember = "fullName";



        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtfullName.Text))
            {
                errorProvider1.SetError(txtfullName, "Empty field");
                return;
            }
                if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtAccountnum.Text))
            {
                errorProvider1.SetError(txtAccountnum, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPhonenum.Text))
            {
                errorProvider1.SetError(txtPhonenum, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtRepassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }

            if (!txtPassword.Text.Equals(txtRepassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRepassword, "Password does not match");
                return;
            }

            try
            {
                UserAccount nUserAccount = new UserAccount();
                nUserAccount.userName = txtUsername.Text;
                nUserAccount.fullName = txtfullName.Text;
                nUserAccount.userPassword = txtPassword.Text;
                nUserAccount.roleId = (Int32)cbBoxRole.SelectedValue;
                nUserAccount.userStatus = "Active";
                nUserAccount.Email = txtEmail.Text;
                nUserAccount.accountNumber = txtAccountnum.Text;
                nUserAccount.phoneNumber = txtPhonenum.Text;

                username = txtUsername.Text;

                using (var db = new DBSYSEntities())
                {
                    db.UserAccount.Add(nUserAccount);
                    db.SaveChanges();

                    String oldpath = label11.Text;
                    String newFile = $"Img_{DateTime.Now.ToString("yyyy-M-d_H-m-ss")}.jpg";
                    String newFilepath = Path.Combine(IMG_PATH, newFile);

                    System.IO.File.Copy(oldpath, newFilepath);

                    var newPicture = new pictures();
                    newPicture.picImage = newFile;

                    db.pictures.Add(newPicture);
                    db.SaveChanges();

                    hasChange = true;
                }

                //txtPassword.Clear();
                //txtRepassword.Clear();
                //txtUsername.Clear();
                //txtPhonenum.Clear();
                //txtAccountnum.Clear();
                //txtEmail.Clear();
                //txtfullName.Clear();

                txtPassword.Clear();
                txtRepassword.Clear();
                txtUsername.Clear();
                txtPhonenum.Clear();
                txtAccountnum.Clear();
                txtEmail.Clear();
                txtfullName.Clear();
                MessageBox.Show("Registered!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String cbResultSelected = cbBoxRole.SelectedValue.ToString();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            String path = ofd.FileName;

            label11.Text = path;
            txtPictureBox.Image = new Bitmap(path);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
