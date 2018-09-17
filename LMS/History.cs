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
	//Author of This page: Sehajpreet Singh
	public partial class History : Form
	{
		//declaring all the required dataset tables and adapters  
		LibraryMSDataSet3.RequestDataTable tblRequest;
	
		LibraryMSDataSet3TableAdapters.RequestTableAdapter adRequest;
		LibraryMSDataSet3.IssueDataTable tblIssue;
		LibraryMSDataSet3TableAdapters.IssueTableAdapter adIssue;
		LibraryMSDataSet3.BookDataTable tblBooks;
		LibraryMSDataSet3TableAdapters.BookTableAdapter adBooks;
		LibraryMSDataSet3.RegisterDataTable tblReg;
		LibraryMSDataSet3TableAdapters.RegisterTableAdapter adReg;
		public History()
		{
			InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
			//intializing all the required dataset tables and adapters  
			tblRequest = new LibraryMSDataSet3.RequestDataTable();
			adRequest = new LibraryMSDataSet3TableAdapters.RequestTableAdapter();
			tblIssue = new LibraryMSDataSet3.IssueDataTable();
			adIssue = new LibraryMSDataSet3TableAdapters.IssueTableAdapter();
			tblBooks = new LibraryMSDataSet3.BookDataTable();
			adBooks = new LibraryMSDataSet3TableAdapters.BookTableAdapter();
			tblReg = new LibraryMSDataSet3.RegisterDataTable();
			adReg = new LibraryMSDataSet3TableAdapters.RegisterTableAdapter();
        }

		private void BtnHome_Click(object sender, EventArgs e)
		{
			//going back to home
			this.Hide();
			MemberPage mp = new MemberPage();
			mp.Show();
		}

		private void History_Load(object sender, EventArgs e)
		{
		

		}

     

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void BtnExtend_Click(object sender, EventArgs e)
		{
			if (TxtId.Text.Equals("")) { MessageBox.Show("Please Provide the Issue ID"); }
			else
			{//request for extension of date for returning book
				adReg.Fill(tblReg, Program.UserID.ToString());
				var row = tblReg[0];
				LibraryMSDataSet3.IssueBookIdDataTable tblBID = new LibraryMSDataSet3.IssueBookIdDataTable();
				LibraryMSDataSet3TableAdapters.IssueBookIdTableAdapter adBID = new LibraryMSDataSet3TableAdapters.IssueBookIdTableAdapter();
				adBID.Fill(tblBID, Convert.ToInt32(TxtId.Text));
				var irow = tblBID[0];
				adRequest.Insert(irow.BookId, null, "extend", DateTime.Now.Date, row.UserId, irow.BookName, Program.UserID.ToString());
				MessageBox.Show("Extension Requested");
			}
		}

		private void BtnLoadBooks_Click(object sender, EventArgs e)
		{
			//loading all the issued books

			adReg.Fill(tblReg,Program.UserID.ToString());
			var row= tblReg[0];
			adIssue.FillIssue(tblIssue, row.UserId);

			for (int i = 0; i < tblIssue.Count; i++)
			{
				var fillRows = tblIssue[i];
				int id = fillRows.BookId;
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
				fillRows.BookName = arow.BookName;
				fillRows.Email = Program.UserID.ToString();

			}
			adIssue.Update(tblIssue);
			gridBooks.DataSource = adIssue.GetIssueData(row.UserId);
		
		}

		private void BtnLoadLogs_Click(object sender, EventArgs e)
		{
			//loading all the requests
			adReg.Fill(tblReg, Program.UserID.ToString());
			var row = tblReg[0];
			adRequest.FillRequest(tblRequest, row.UserId);
			gridRequest.DataSource = adRequest.GetRequestData(row.UserId);
		}

		private void LoadAllBooksButton_Click(object sender, EventArgs e)
		{
			//loading all the avaliable books
			adBooks.Fill(tblBooks);
			gridBooks.DataSource = adBooks.GetData();
		}

		private void BtnReturn_Click(object sender, EventArgs e)
		{
			if (TxtId.Text.Equals("")) { MessageBox.Show("Please Provide the Issue ID"); }
			else
			{// requesting to return a book
				adReg.Fill(tblReg, Program.UserID.ToString());
				var row = tblReg[0];
				LibraryMSDataSet3.IssueBookIdDataTable tblBID = new LibraryMSDataSet3.IssueBookIdDataTable();
				LibraryMSDataSet3TableAdapters.IssueBookIdTableAdapter adBID = new LibraryMSDataSet3TableAdapters.IssueBookIdTableAdapter();
				adBID.Fill(tblBID, Convert.ToInt32(TxtId.Text));
				var irow = tblBID[0];
				adRequest.Insert(irow.BookId, null, "return", DateTime.Now.Date, row.UserId, irow.BookName, Program.UserID.ToString());
				MessageBox.Show("Return Requested");
			}
		}

		private void BtnPayment_Click(object sender, EventArgs e)
		{
			if (TxtId.Text.Equals("")) { MessageBox.Show("Please Provide the Issue ID"); }
			else
			{//requesting to make the payment
				adReg.Fill(tblReg, Program.UserID.ToString());
				var row = tblReg[0];
				LibraryMSDataSet3.IssueBookIdDataTable tblBID = new LibraryMSDataSet3.IssueBookIdDataTable();
				LibraryMSDataSet3TableAdapters.IssueBookIdTableAdapter adBID = new LibraryMSDataSet3TableAdapters.IssueBookIdTableAdapter();
				adBID.Fill(tblBID, Convert.ToInt32(TxtId.Text));
				var irow = tblBID[0];
				adRequest.Insert(irow.BookId, null, "payment", DateTime.Now.Date, row.UserId, irow.BookName, Program.UserID.ToString());
				MessageBox.Show("Payment Requested");
			}
		}

		private void gridRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
