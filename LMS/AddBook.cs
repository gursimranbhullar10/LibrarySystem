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
       * Page: Add book page
       * Description: This page is use to add books.
       * 
       * */
    public partial class AddBook : System.Windows.Forms.Form
    {
        BookDatasetTableAdapters.BookTableAdapter adBook;
        BookDataset.BookDataTable tblBook;

        public AddBook()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
            adBook = new BookDatasetTableAdapters.BookTableAdapter();
            tblBook = new BookDataset.BookDataTable();
        }

        /**
        * Name:Harsh patel
        * Description: this below method validate Requiredfield validation control
        * */
        public Boolean validateMe()
        {
            if (txtBookName.Text == "")
            {
                MessageBox.Show("Please enter Book Name");
                return false;
            }
            else if (txtAuthor.Text == "")
            {
                MessageBox.Show("Please enter Author Name");
                return false;
            }
            else if (txtISBN.Text == "")
            {
                MessageBox.Show("Please ISBN#");
                return false;
            }
            else if (txtPublisher.Text == "")
            {
                MessageBox.Show("Please enter Publisher");
                return false;
            }
            else if (txtCategory.Text == "")
            {
                MessageBox.Show("Please enter Category");
                return false;
            }
            else if (txtNoofCopy.Text == "")
            {
                MessageBox.Show("Please enter #ofCopy");
                return false;
            }

            return true;

        }

        public void clearControl()
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            txtPublisher.Clear();
            txtCategory.Clear();
            txtNoofCopy.Clear();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (validateMe())
            {
                int row;
                try
                {
                    row = adBook.Insert(txtBookName.Text.Trim(), txtAuthor.Text.Trim(), txtISBN.Text.Trim(), txtPublisher.Text.Trim(), txtCategory.Text.Trim(), Convert.ToInt32(txtNoofCopy.Text));
                    MessageBox.Show("Book Added Succesfully");
                    clearControl();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured... Please try again!!");
                    clearControl();
                }
            }
            else
            { }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddBook ap = new AddBook();
            this.Close();
            AdminProfile ab = new AdminProfile();
            ab.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.UserID = "";
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

       
    }
}
