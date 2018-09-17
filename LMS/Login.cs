using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        /**
         * Name: Harsh Patel
         * StudentId:991466208
         * Page: Login page
         * Description: This page contains authenticate user logic
         * 
         * */

        RegisterDatasetTableAdapters.LoginCheckTableAdapter checkLogin;
        RegisterDataset.LoginCheckDataTable tblLogin;
        public LoginForm()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",@Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
            InitializeComponent();
            checkLogin = new RegisterDatasetTableAdapters.LoginCheckTableAdapter();
            tblLogin = new RegisterDataset.LoginCheckDataTable();
            ddlRole.Items.Insert(0, "Select a role");
            ddlRole.SelectedIndex = 0;
        }

        /**
         * Name:Harsh patel
         * Description: this below method validate Requiredfield validation control
         * */

        public Boolean validateMe()
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter Email");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password");
                return false;
            }
            else if (ddlRole.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a Role");
                return false;
            }
            return true;
        }

        /**
        * Name:Harsh patel
        * Description: this below even authiticate users
        * */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateMe())
            {

                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                int role = ddlRole.SelectedIndex;

                tblLogin = checkLogin.GetDataByLogin(email, password, role);

                if (tblLogin.Count == 1)
                {
                    Program.UserID = email;
                    MessageBox.Show("Welcome " + email);
                    LoginForm f1 = new LoginForm();
                    this.Hide();
                    if (ddlRole.SelectedIndex == 1)
                    {
                        AdminProfile ap = new AdminProfile();
                        ap.Show();
                    }
                    else if (ddlRole.SelectedIndex == 2)
                    {
                        WindowsFormsApp1.LibrarianPage librarianPage = new WindowsFormsApp1.LibrarianPage();
                        librarianPage.Show();
                    }
                    else if (ddlRole.SelectedIndex == 3)
                    {
                        // Open Librarian Members/Students Page
                        MemberPage mp = new MemberPage();
                        mp.Show();
                    }


                }
                else
                {

                    lblErrorMsg.Text = "UserName or Password not correct.. Please Try Again !!";
                    lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                    txtEmail.Clear();
                    txtPassword.Clear();
                    ddlRole.SelectedIndex = 0;
                    txtEmail.Focus();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm f1 = new LoginForm();
            this.Hide();
            RegisterMember rm = new RegisterMember();
            rm.Show();
        }

        private void lnkForgotPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm f1 = new LoginForm();
            this.Hide();
            ForgotPassword fp = new ForgotPassword();
            fp.Show();

        }
	}
}
