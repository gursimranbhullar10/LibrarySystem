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
	public partial class MemberBookSearchPage : Form
	{
		//Author of This page: Sehajpreet Singh
		public MemberBookSearchPage()
		{
			InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
        }

		private void button1_Click(object sender, EventArgs e)
		{
			//going back to home page
			this.Close();
			MemberPage mp = new MemberPage();
			mp.Show();
		}

		private void MemberBookSearchPage_Load(object sender, EventArgs e)
		{
			//getting number of copies from dataset table adapter
			this.copiesTableAdapter.FillCopies(this.libraryMSDataSet.Copies,Program.UserID.ToString());
			// TODO: This line of code loads data into the 'libraryMSDataSet.Register' table. You can move, or remove it, as needed.
			this.registerTableAdapter.FillUID(this.libraryMSDataSet.Register, Program.UserID.ToString());
			//getting user id
			string userEmail = Program.UserID.ToString();
			this.registerTableAdapter.GetDataUID(Program.UserID.ToString());
			//accesing number of issues
			var row = libraryMSDataSet.Register[0];
			this.numOfIssuesTableAdapter.FillNumIssue(this.libraryMSDataSet.NumOfIssues, row.UserId);
			// TODO: This line of code loads data into the 'libraryMSDataSet.Book' table. You can move, or remove it, as needed.
			//accesing books table and then filling it up with help of dataset
			this.bookTableAdapter.Fill(this.libraryMSDataSet.Book);
			//assigning the columns  of dataset to combobox
			cmbField.SelectedIndex = 1;
			cmbText.DisplayMember = "BookName";

		}

		private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
		{
			//setting up searching criteria
			if (cmbField.SelectedIndex == 0) { cmbText.DisplayMember = "BookId";}
			else if (cmbField.SelectedIndex == 1) { cmbText.DisplayMember = "BookName"; }
			else if (cmbField.SelectedIndex == 2) { cmbText.DisplayMember = "Author"; }
			else if (cmbField.SelectedIndex == 3) { cmbText.DisplayMember = "ISBN"; }
			else if (cmbField.SelectedIndex == 4) { cmbText.DisplayMember = "Publisher"; }
			else if (cmbField.SelectedIndex == 5) { cmbText.DisplayMember = "Category"; }
			else { cmbText.DisplayMember = "NoofCopy"; }
		}

		private void BtnIssue_Click(object sender, EventArgs e)
		{
			//requesting for issueing a book

			int id = -100;
			if (cmbField.SelectedIndex == 0) {
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex)); }
			else if (cmbField.SelectedIndex == 1) {
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex));
			}
			else if (cmbField.SelectedIndex == 2) {
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex));
			}
			else if (cmbField.SelectedIndex == 3) {
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex));
			}
			else if (cmbField.SelectedIndex == 4) {
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex));
			}
			else if (cmbField.SelectedIndex == 5)
			{
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex));
			}
			else {
				id = Convert.ToInt32(LstInfo.GetItemText(LstInfo.SelectedIndex));
			}
			var iRow = libraryMSDataSet.NumOfIssues[0];
			var cRow = libraryMSDataSet.Copies[0];
			//checking the limit
			if (iRow.Expr1<cRow.NoofIssue) {
				id = id + 1;
				LibraryMSDataSet3.RegisterDataTable tblReg = new LibraryMSDataSet3.RegisterDataTable();
				LibraryMSDataSet3TableAdapters.RegisterTableAdapter adReg = new LibraryMSDataSet3TableAdapters.RegisterTableAdapter();
				LibraryMSDataSet3.RequestDataTable tblRequest = new LibraryMSDataSet3.RequestDataTable();
				LibraryMSDataSet3TableAdapters.RequestTableAdapter adRequest = new LibraryMSDataSet3TableAdapters.RequestTableAdapter();
				adReg.Fill(tblReg, Program.UserID.ToString());
				var urow = tblReg[0];
				LibraryMSDataSet3.BookDataTable tblBID = new LibraryMSDataSet3.BookDataTable();
				LibraryMSDataSet3TableAdapters.BookTableAdapter adBID = new LibraryMSDataSet3TableAdapters.BookTableAdapter();
			
				adBID.FillById(tblBID, id);
				var arow = tblBID[0];
				adRequest.Insert(arow.BookId, null, "issue", DateTime.Now.Date, urow.UserId, arow.BookName, Program.UserID.ToString());
				MessageBox.Show("Your Selected book is requested for issue"); }
			else { MessageBox.Show("Limit Exceeded");
			}
		}

		private void BtnHistory_Click(object sender, EventArgs e)
		{
			//opening the library history
			this.Close();
			History hPage = new History();
			hPage.Show();
		}
	}
}
