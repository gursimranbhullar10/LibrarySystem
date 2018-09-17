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
	public partial class MemberPage : Form
	{
		//Author of This page: Sehajpreet Singh
		RegisterDatasetTableAdapters.RegisterTableAdapter adRegister;
		RegisterDataset.RegisterDataTable tblRegister;
		public MemberPage()
		{
			AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\sehaj\Desktop\LMS\LMS\LMS");
			InitializeComponent();
			adRegister = new RegisterDatasetTableAdapters.RegisterTableAdapter();
			tblRegister = new RegisterDataset.RegisterDataTable();
		}
		private void BtnPic_Click(object sender, EventArgs e)
		{
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
			PbProfilePic.Image = LMS.Properties.Resources.Profile;
		}

		private void MemberPage_Load(object sender, EventArgs e)
		{
			adRegister.FillByEmail(tblRegister, Program.UserID);

			if (tblRegister.Count == 1)
			{
				var row = tblRegister[0];

				txtFname.Text = row.Fname.ToString();
				txtLname.Text = row.Lname.ToString();
				txtPhone.Text = row.Phone.ToString();
				txtEmail.Text = row.Email;
			PbProfilePic.Image = LMS.Properties.Resources.Profile; 
			}
			else
			{
				label1.Text = "Something went wrong.. Please try again!!";
				label1.ForeColor = Color.Red;

			}

		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			this.Hide();
			MemberBookSearchPage mbsp = new MemberBookSearchPage();
			mbsp.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lnkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Program.UserID = "";
			Application.Exit();
		}
	}
}
