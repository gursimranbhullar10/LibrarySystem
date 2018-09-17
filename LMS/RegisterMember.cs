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
    public partial class RegisterMember : Form
    {

        /**
        * Name: Harsh Patel
        * StudentId:991466208
        * Page: Add members page
        * Description: This page is useful to add members in our system.
        * 
        * */
        RegisterDatasetTableAdapters.RegisterTableAdapter adRegister;
        RegisterDataset.RegisterDataTable tblRegister;
        public RegisterMember()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
            InitializeComponent();
            adRegister = new RegisterDatasetTableAdapters.RegisterTableAdapter();
            tblRegister = new RegisterDataset.RegisterDataTable();
        }
        /**
* Name:Harsh patel
* Description: this below method validate Requiredfield validation control
* */
        public Boolean validateMe()
        {
            if (txtFname.Text == "")
            {
                MessageBox.Show("Please enter first name");
                return false;
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("Please enter last name");
                return false;
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter phone#");
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter email");
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
                return false;
            }

            return true;

        }
        /**
* Name:Harsh patel
* Description: this below method clear all control
* */
        public void clearControl()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            pictureBox1.Image = null;
            lblPath.Text = "";
            txtFname.Focus();
        }
        /**
    * Name:Harsh patel
    * Description: this below method is use to upload image
    * */

        public Boolean imageUpload()
        {
            //MessageBox.Show(path);
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null || filename == "openFileDialog1")
                {
                    MessageBox.Show("Please select a valid image.");
                    return false;
                }
                else
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);

                    MessageBox.Show("Image uploaded successfully.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Already Exits");
                return false;
            }
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int row=0;


            if (validateMe())
            {
                if (imageUpload())
                {
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    row = adRegister.Insert(txtFname.Text.Trim(), txtLname.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim(),15, 5, "\\Image\\" + filename, 3);
                }
             }
        
                if (row == 1)
                {
                    MessageBox.Show("Record Inserted");
                }
                else if(row == -1)
                {
                    MessageBox.Show("Record Not Inserted");
                }
            clearControl();
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RegisterMember rm = new RegisterMember();
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Select image to be upload.";

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string Imagepath = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        lblPath.Text = Imagepath;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);

                    }
                }
                else
                {
                    MessageBox.Show("Please Upload an image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.UserID = "";
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
        /**
   * Name:Harsh patel
   * Description: this event validate email format
   * */

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex emailValidation = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmail.Text.Length > 0)
            {
                if (!emailValidation.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Please enter valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;

                }

            }
        }
    }
}
