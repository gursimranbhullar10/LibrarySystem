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

namespace LMS
{
	public partial class MemberPage : Form
	{
		//Author of This page: Sehajpreet Singh
		//Attaching and declaring Datasets
		RegisterDatasetTableAdapters.RegisterTableAdapter adRegister;
		RegisterDataset.RegisterDataTable tblRegister;
		public MemberPage()
		{

            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
            InitializeComponent();
			//intializing Datasets
			adRegister = new RegisterDatasetTableAdapters.RegisterTableAdapter();
			tblRegister = new RegisterDataset.RegisterDataTable();
		}
		private void BtnPic_Click(object sender, EventArgs e)
		{
			//uploading pic
			string folderPath = (Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
#if !DEBUG
          folderPath = (Application.StartupPath.Substring(0, (Application.StartupPath.Length - 12)));
          
#endif

			//on Button Click Dialog box is opening to select the picture from operating System And Upload it to Picture Box
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
				dlg.Title = "Open Image";

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					PbProfilePic.ImageLocation = dlg.FileName;

				}
			}

		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			//removing pic
			PbProfilePic.Image = LMS.Properties.Resources.Profile;
		}

		private void MemberPage_Load(object sender, EventArgs e)
		{
			// on form load accessing all the contact info
		
			adRegister.FillByEmail(tblRegister, Program.UserID);

			if (tblRegister.Count == 1)
			{
				var row = tblRegister[0];
				
				txtFname.Text = row.Fname.ToString();
				txtLname.Text = row.Lname.ToString();
				txtPhone.Text = row.Phone.ToString();
				txtEmail.Text = row.Email;
				PbProfilePic.Image= new Bitmap(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + row.Photo);
			}
			else
			{
				lblProfile.Text = "Something went wrong.. Please try again!!";
				lblProfile.ForeColor = Color.Red;

			}
			txtFname.Enabled = false;
			txtLname.Enabled = false;
			txtPhone.Enabled = false;
			txtEmail.Enabled = false;
			btnCloseEdit.Visible = false;
			btnUpdatePhone.Visible = false;
			txtPass.Visible = false;
			btnPass.Visible = false;

		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			//opening the search page
			this.Close();
			MemberBookSearchPage mbsp = new MemberBookSearchPage();
			mbsp.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//logout from current user

            Program.UserID = "";
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }



		private void BtnHistory_Click(object sender, EventArgs e)
		{
			//opening the library history
			this.Close();
			History historyPage = new History();
			historyPage.Show();
		}

		

		private void btnEditContactInfo_Click(object sender, EventArgs e)
		{
			// editing the contact information
			btnCloseEdit.Visible = true;
			btnUpdatePhone.Visible = true;
			btnEditContactInfo.Visible = false;
			txtPhone.Enabled = true;
		}

		private void btnCloseEdit_Click(object sender, EventArgs e)
		{
			// closing  the editing
			btnEditContactInfo.Visible = true;
			btnCloseEdit.Visible = false;
			btnUpdatePhone.Visible = false;
			txtPhone.Enabled = false;
		}

		private void btnUpdatePhone_Click(object sender, EventArgs e)
		{
			//saving the and updating the contact info
			adRegister.FillByEmail(tblRegister, Program.UserID);

			if (tblRegister.Count == 1)
			{
				var row = tblRegister[0];
				
				row.Phone = txtPhone.Text;
			}
			adRegister.Update(tblRegister);
		}

		private void lnkLblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//to change password
			lnkLblChangePassword.Visible = false;
			txtPass.Visible =true;
			btnPass.Visible = true;
		}

		private void btnPass_Click(object sender, EventArgs e)
		{
			//now saving and updating password in database
			lnkLblChangePassword.Visible = true;
			txtPass.Visible = false;
			btnPass.Visible = false;
			adRegister.FillByEmail(tblRegister, Program.UserID);

			if (tblRegister.Count == 1)
			{
				var row = tblRegister[0];

				row.Password = txtPass.Text;
			}
			adRegister.Update(tblRegister);
		}

		private void lnkLblDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//requesting for deleting the account
			LibraryMSDataSet3.DeleteRequestDataTable dr = new LibraryMSDataSet3.DeleteRequestDataTable();
			LibraryMSDataSet3TableAdapters.DeleteRequestTableAdapter adr = new LibraryMSDataSet3TableAdapters.DeleteRequestTableAdapter();
			LibraryMSDataSet3.RegisterDataTable tblR = new LibraryMSDataSet3.RegisterDataTable();
			LibraryMSDataSet3TableAdapters.RegisterTableAdapter adR = new LibraryMSDataSet3TableAdapters.RegisterTableAdapter();
			adR.Fill(tblR,Program.UserID.ToString());
			var irow = tblR[0];
			adr.Insert(irow.UserId ,Program.UserID.ToString());
			MessageBox.Show("Requested to delete account");
		}
	}
}
