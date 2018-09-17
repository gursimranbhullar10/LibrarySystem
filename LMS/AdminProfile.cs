using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{

    /**
       * Name: Harsh Patel
       * StudentId:991466208
       * Page: Admin profile page
       * Description: This page contains profile of Admin 
       * 
       * */
    public partial class AdminProfile : System.Windows.Forms.Form
    {
        RegisterDatasetTableAdapters.RegisterTableAdapter adRegister;
        RegisterDataset.RegisterDataTable tblRegister;
        public AdminProfile()
        {
            //AppDomain.CurrentDomain.SetData("DataDirectory", @"H:\LMS\LMS");
            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
            InitializeComponent();
            adRegister = new RegisterDatasetTableAdapters.RegisterTableAdapter();
            tblRegister = new RegisterDataset.RegisterDataTable();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            this.Hide();
            Register re = new Register();
            re.Show();
        }

        

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            //int id = int.Parse(txtProductId.Text);


            adRegister.FillByEmail(tblRegister, Program.UserID);

            if (tblRegister.Count == 1)
            {
                var row = tblRegister[0];

                lblFname.Text = row.Fname.ToString();
                lblLname.Text = row.Lname.ToString();
                lblPhone.Text = row.Phone.ToString();
                lblEmail.Text = row.Email;
              pictureBox1.Image= new Bitmap(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + row.Photo);
            }
            else
            {
                label1.Text = "Something went wrong.. Please try again!!";
                label1.ForeColor = Color.Red;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.UserID = "";
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            this.Hide();
            AddBook abs = new AddBook();
            abs.Show();
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            this.Hide();
            ViewMembers vm = new ViewMembers();
            vm.Show();
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile();
            this.Hide();
            ViewBooks vb = new ViewBooks();
            vb.Show();
        }
    }
}
