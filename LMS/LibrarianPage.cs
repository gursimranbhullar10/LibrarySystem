using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LibrarianPage : Form
    {
        DataSet1 ds1;
        DataSet1.IssueDataTable ibdt;
        DataSet1TableAdapters.IssueTableAdapter ibtm;
        String state = "Books";
        String btn = "";
        int ID;
        DataSet1TableAdapters.Book1TableAdapter BookTableAdapter;
        DataSet1.Book1DataTable Books;
        DataSet1.RequestDataTable requestBooks;
        DataSet1TableAdapters.RequestTableAdapter RequestBookTableAdapter;
        LMS.LibraryMSDataSet1TableAdapters.RequestTableAdapter RequestTableAdapterlms;
        LMS.LibraryMSDataSet1.RequestDataTable requestslms;
        LMS.LibraryMSDataSet1TableAdapters.RegisterTableAdapter RegisterTableAdapter;
       LMS.LibraryMSDataSet1.RegisterDataTable registers;
        public LibrarianPage()
        {
            InitializeComponent();
            ds1 = new DataSet1();
            ibtm = new DataSet1TableAdapters.IssueTableAdapter();
            ibdt = new DataSet1.IssueDataTable();
            Books = new DataSet1.Book1DataTable();
            BookTableAdapter = new DataSet1TableAdapters.Book1TableAdapter();
            requestBooks = new DataSet1.RequestDataTable();
            RequestBookTableAdapter = new DataSet1TableAdapters.RequestTableAdapter();
            RegisterTableAdapter = new LMS.LibraryMSDataSet1TableAdapters.RegisterTableAdapter();
            registers = new LMS.LibraryMSDataSet1.RegisterDataTable();
            RequestTableAdapterlms = new LMS.LibraryMSDataSet1TableAdapters.RequestTableAdapter();
            requestslms = new LMS.LibraryMSDataSet1.RequestDataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             BookTableAdapter.Fill(Books);
            //Loads Books table by default
            dataGridView1.DataSource = Books;
            dataGridView1.Refresh();
            cmbFilters.SelectedIndex = 0;
            btnSave.Enabled = false;
            RegisterTableAdapter.FillByEmailID(registers,LMS.Program.UserID);
            //Loads User Pofile
            txtFirstName.Text = registers.Rows[0]["Fname"].ToString();
            txtLastName.Text = registers.Rows[0]["Lname"].ToString();
            txtPhoneNo.Text = registers.Rows[0]["Phone"].ToString();
            txtEmail.Text = registers.Rows[0]["Email"].ToString();
            pctrBox.Image = new Bitmap(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + registers.Rows[0]["Photo"].ToString());

        }

        private void btnIssuedBooks_Click(object sender, EventArgs e)
        {
            DataTable ab=new DataTable();
            ab = ibtm.GetData();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ab;
            dataGridView1.Refresh();
            state = "IssueBooks";
            //check if there is row in issue book table
            if (ibdt.Rows.Count > 0)
            {
                labelControl(Convert.ToInt32(ibdt.Rows[0]["IssueID"].ToString()));
            }
                labelControl(-3);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.FormattedValue.ToString() != "")
            {
                labelControl(-3);
                if (state == "Books")
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["BookID"].FormattedValue.ToString());
                    labelControl(ID);
                }
                else if (state == "IssueBooks" || state == "OverDueBooks")
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["IssueID"].FormattedValue.ToString());
                    labelControl(ID);
                }
                else
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["RequestID"].FormattedValue.ToString());
                    labelControl(ID);

                }
            }
        }

        private void btnOverdueBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ibdt.Clear();
            ibtm.FillByOverDueBooks(ibdt, DateTime.Today.ToString());
            dataGridView1.DataSource = ibdt;
            dataGridView1.Refresh();
            state = "OverDueBooks";
            if (ibdt.Rows.Count > 0)
            {
                labelControl(Convert.ToInt32(ibdt.Rows[0]["IssueID"].ToString()));
            }
            labelControl(-3);
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            BookTableAdapter.Fill(Books);
            DataTable table = Books.Clone();
            dataGridView1.AutoGenerateColumns = true;
            BookTableAdapter.Fill(Books);
            dataGridView1.DataSource = Books;
            dataGridView1.Refresh();
            state = "Books";
            if (Books.Rows.Count > 0)
            {
                labelControl(Convert.ToInt32(Books.Rows[0]["BookID"].ToString()));
            }
                labelControl(-3);
        }



        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestBookTableAdapter.Fill(requestBooks);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = requestBooks;
            dataGridView1.Refresh();
            state = "Requests";
            if (requestBooks.Rows.Count > 0)
            {
                labelControl(Convert.ToInt32(requestBooks.Rows[0]["RequestID"].ToString()));
            }
                labelControl(-3);
        }
        private void labelControl(int ID)
        {
            if (ID >= 0)
            {
                lblWarning.Text = "";
                if (state == "Books")
                {
                    DataTable a = BookTableAdapter.GetDataByBookID(ID);
                    textBox2.Text = a.Rows[0]["BookName"].ToString();
                    textBox3.Text = a.Rows[0]["Author"].ToString();
                    textBox4.Text = a.Rows[0]["ISBN"].ToString();
                    textBox5.Text = a.Rows[0]["Publisher"].ToString();
                    textBox6.Text = a.Rows[0]["Category"].ToString();
                    textBox7.Text = a.Rows[0]["NoofCopy"].ToString();
                    label1.Text = "Book Name";
                    label2.Text = "Book Author";
                    label3.Text = "ISBN";
                    label4.Text = "Book Publisher";
                    label5.Text = "Category";
                    label6.Text = "Total Quantity";
                    textBox7.Visible = true;
                    label6.Visible = true;
                    label7.Visible = false;
                    textBox8.Visible = false;
                    btnAdd.Text = "Add";
                    btnEdit.Text = "Edit";
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;

                }
                else if (state == "IssueBooks" || state == "OverDueBooks")
                {
                    textBox7.Visible = true;
                    label6.Visible = true;
                    DataTable a = ibtm.GetDataByIssueID(ID);
                    textBox2.Text = a.Rows[0]["BookID"].ToString();
                    textBox3.Text = a.Rows[0]["UserID"].ToString();
                    textBox4.Text = a.Rows[0]["IssueDate"].ToString();
                    DateTime? dt1;
                    if (Convert.IsDBNull(a.Rows[0]["ExpectedReturn"]))
                    {
                        dt1 = null;
                        textBox5.Text = null;
                    }
                    else
                    {
                        dt1 = Convert.ToDateTime(a.Rows[0]["ExpectedReturn"]);
                        textBox5.Text = dt1.Value.Date.ToShortDateString();
                    }
                  
                    DateTime? dt2;
                    if (Convert.IsDBNull(a.Rows[0]["ActualReturn"]))
                    {
                        dt2 = null;
                        textBox6.Text = null;
                    }
                    else
                    {
                        dt2 = Convert.ToDateTime(a.Rows[0]["ActualReturn"]);
                        textBox6.Text = dt2.Value.Date.ToShortDateString();
                    }

                    textBox7.Text = a.Rows[0]["OverDuePayment"].ToString();
                    textBox8.Text = a.Rows[0]["PaymentStatus"].ToString();
                    label1.Text = "Member ID";
                    label2.Text = "Book ID";
                    label3.Text = "Issue Date";
                    label4.Text = "Expected Return Date";
                    label5.Text = "Actual Return Date";
                    label6.Text = "Over Dues";
                    label7.Text = "Paid Status";
                    btnAdd.Text = "Add";
                    btnEdit.Text = "Edit";
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;
                }

                else
                {
                    DataTable a = RequestBookTableAdapter.GetDataByRequestID(ID);
                    textBox2.Text = a.Rows[0]["UserID"].ToString();
                    textBox3.Text = a.Rows[0]["BookID"].ToString();
                    textBox4.Text = a.Rows[0]["Status"].ToString();
                    textBox5.Text = Convert.ToDateTime(a.Rows[0]["RequestDate"]).ToString("mm/dd/yyyy");
                    textBox6.Text = a.Rows[0]["RequestType"].ToString();
                    textBox7.Visible = false;
                    label1.Text = "Member ID";
                    label2.Text = "Book ID";
                    label3.Text = "Request Status";
                    label4.Text = "Request Date";
                    label5.Text = "Request Type";
                    label6.Visible = false;
                    label7.Visible = false;
                    textBox8.Visible = false;
                    btnAdd.Text = "Accept";
                    btnEdit.Text = "Decline";
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            else if (ID == -1)
            {
                btnSave.Enabled = true;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
                if (state == "Books")
                {
                    label7.Visible = false;
                    textBox8.Visible = false;
                    textBox7.Visible = true;
                    label6.Visible = true;
                }
                else if (state == "IssueBooks" || state == "OverDueBooks")
                {
                    textBox7.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    textBox8.Visible = true;
                }
                else
                {
                    textBox7.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    textBox8.Visible = false;
                }
            }
            else if (ID == -2)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
            }
            else if (ID == -3)
            {
                textBox2.BackColor = Color.FromArgb(211, 211, 211);
                textBox3.BackColor = Color.FromArgb(211, 211, 211);
                textBox4.BackColor = Color.FromArgb(211, 211, 211);
                textBox5.BackColor = Color.FromArgb(211, 211, 211);
                textBox6.BackColor = Color.FromArgb(211, 211, 211);
                textBox7.BackColor = Color.FromArgb(211, 211, 211);
                textBox8.BackColor = Color.FromArgb(211, 211, 211);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            state = "Books";
            if (cmbFilters.SelectedIndex == 1)
            {
                DataTable a = BookTableAdapter.GetDataByBookID(Convert.ToInt32(txtSearch.Text));
                if (a.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(a.Rows[0]["BookID"].ToString());
                }
                labelControl(ID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = a;
                dataGridView1.Refresh();
            }
            else if (cmbFilters.SelectedIndex == 2)
            {
                DataTable a = BookTableAdapter.GetDataByBookName(txtSearch.Text);
                if (a.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(a.Rows[0]["BookID"].ToString());
                }
                    labelControl(ID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = a;
                dataGridView1.Refresh();
            }
            else if (cmbFilters.SelectedIndex == 3)
            {
                DataTable a = BookTableAdapter.GetDataByBookPublisher(txtSearch.Text);
                if (a.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(a.Rows[0]["BookID"].ToString());
                }
                    labelControl(ID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = a;
                dataGridView1.Refresh();
            }
            else if (cmbFilters.SelectedIndex == 4)
            {
                DataTable a = BookTableAdapter.GetDataByBookAuthor(txtSearch.Text);
                if (a.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(a.Rows[0]["BookID"].ToString());
                }
                    labelControl(ID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = a;
                dataGridView1.Refresh();
            }
            else if (cmbFilters.SelectedIndex == 5)
            {
                DataTable a = BookTableAdapter.GetDataByBookCategory(txtSearch.Text);
                if (a.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(a.Rows[0]["BookID"].ToString());

                }
                labelControl(ID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = a;
                dataGridView1.Refresh();
            }
            else if (cmbFilters.SelectedIndex == 6)
            {
                DataTable a = BookTableAdapter.GetDataByBookISBN(txtSearch.Text);
                if (a.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(a.Rows[0]["BookID"].ToString());
                }
                    labelControl(ID);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = a;
                dataGridView1.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelControl(-1);
            btn = "Add";
            if (state == "Requests")
            {
                btn = "Accept";
                acceptRequest(Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["RequestID"].FormattedValue.ToString()));
                labelControl(Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["RequestID"].FormattedValue.ToString()));
                RequestBookTableAdapter.Fill(requestBooks);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = requestBooks;
                dataGridView1.Refresh();
                state = "Requests";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, Boolean> errors = new Dictionary<string, bool>();
            List<String> a = new List<string>();
            a.Add(textBox2.Text);
            a.Add(textBox3.Text);
            a.Add(textBox4.Text);
            a.Add(textBox5.Text);
            a.Add(textBox6.Text);
            a.Add(textBox7.Text);
            a.Add(textBox8.Text);
            if (btn == "Add")
            {
                if (state == "Books")
                {
                    if (validCheck(ref a, "Books", ref errors))
                    {
                        BookTableAdapter.InsertBook(textBox2.Text, textBox3.Text, textBox4.Text, textBox6.Text
                    , textBox5.Text
                    , Convert.ToInt32(textBox7.Text));
                        BookTableAdapter.Fill(Books);
                        dataGridView1.DataSource = Books;
                        dataGridView1.Refresh();
                        state = "Books";
                        labelControl(-2);
                        labelControl(-3);
                    }
                    else
                    {
                        lblWarning.Text = "Please Fill Required Fields in correct format";
                        foreach (var ab in errors)
                        {
                            if (ab.Value)
                            {
                                switch (ab.Key)
                                {
                                    case "text2":
                                        textBox2.BackColor = Color.Red;
                                        break;
                                    case "text3":
                                        textBox3.BackColor = Color.Red;
                                        break;
                                    case "text4":
                                        textBox4.BackColor = Color.Red;
                                        break;
                                    case "text5":
                                        textBox5.BackColor = Color.Red;
                                        break;
                                    case "text6":
                                        textBox6.BackColor = Color.Red;
                                        break;
                                    case "text7":
                                        textBox7.BackColor = Color.Red;
                                        break;
                                    case "text8":
                                        textBox8.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                    }
                }
                else if (state == "IssueBooks")
                {
                    if (validCheck(ref a, "IssueBooks", ref errors))
                    {
                        ibtm.InsertIssueBook(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, textBox6.Text
                 , textBox5.Text
                 , Convert.ToDecimal(textBox7.Text), textBox8.Text);
                        ibtm.Fill(ibdt);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = ibdt;
                        dataGridView1.Refresh();
                        state = "IssueBooks";
                        labelControl(-2);
                        labelControl(-3);
                    }
                    else
                    {
                        lblWarning.Text = "Please Fill Required Fields in correct format";
                        foreach (var ab in errors)
                        {
                            if (ab.Value)
                            {
                                switch (ab.Key)
                                {
                                    case "text2":
                                        textBox2.BackColor = Color.Red;
                                        break;
                                    case "text3":
                                        textBox3.BackColor = Color.Red;
                                        break;
                                    case "text4":
                                        textBox4.BackColor = Color.Red;
                                        break;
                                    case "text5":
                                        textBox5.BackColor = Color.Red;
                                        break;
                                    case "text6":
                                        textBox6.BackColor = Color.Red;
                                        break;
                                    case "text7":
                                        textBox7.BackColor = Color.Red;
                                        break;
                                    case "text8":
                                        textBox8.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                    }
                }

            }
            else if (btn == "Edit")
            {
                if (state == "Books")
                {
                    if (validCheck(ref a, "Books", ref errors))
                    {
                        BookTableAdapter.UpdateBooks(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text
                , textBox6.Text, Convert.ToInt32(textBox7.Text)
                , this.ID);
                        BookTableAdapter.Fill(Books);
                        dataGridView1.DataSource = Books;
                        dataGridView1.Refresh();
                        state = "Books";
                        labelControl(ID);
                        labelControl(-3);
                    }
                    else
                    {
                        lblWarning.Text = "Please Fill Required Fields in correct format";
                        foreach (var ab in errors)
                        {
                            if (ab.Value)
                            {
                                switch (ab.Key)
                                {
                                    case "text2":
                                        textBox2.BackColor = Color.Red;
                                        break;
                                    case "text3":
                                        textBox3.BackColor = Color.Red;
                                        break;
                                    case "text4":
                                        textBox4.BackColor = Color.Red;
                                        break;
                                    case "text5":
                                        textBox5.BackColor = Color.Red;
                                        break;
                                    case "text6":
                                        textBox6.BackColor = Color.Red;
                                        break;
                                    case "text7":
                                        textBox7.BackColor = Color.Red;
                                        break;
                                    case "text8":
                                        textBox8.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                    }
                }
                else if (state == "IssueBooks" || state == "OverDueBooks")
                {
                    if (validCheck(ref a, "IssueBooks", ref errors))
                    {
                        ibtm.UpdateIssueBook(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text
                     , textBox6.Text
                     , Convert.ToDecimal(textBox7.Text), textBox8.Text, ID);
                        ibtm.Fill(ibdt);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = ibdt;
                        dataGridView1.Refresh();
                        state = "IssueBooks";
                        labelControl(ID);
                        labelControl(-3);
                    }
                    else
                    {
                        lblWarning.Text = "Please Fill Required Fields in correct format";
                        foreach (var ab in errors)
                        {
                            if (ab.Value)
                            {
                                switch (ab.Key)
                                {
                                    case "text2":
                                        textBox2.BackColor = Color.Red;
                                        break;
                                    case "text3":
                                        textBox3.BackColor = Color.Red;
                                        break;
                                    case "text4":
                                        textBox4.BackColor = Color.Red;
                                        break;
                                    case "text5":
                                        textBox5.BackColor = Color.Red;
                                        break;
                                    case "text6":
                                        textBox6.BackColor = Color.Red;
                                        break;
                                    case "text7":
                                        textBox7.BackColor = Color.Red;
                                        break;
                                    case "text8":
                                        textBox8.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                    }
                }

                else
                {
                    if (validCheck(ref a, "Requests", ref errors))
                    {
                        RequestBookTableAdapter.UpdateRequest(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToBoolean(textBox4.Text)
                      , textBox5.Text
                      , textBox6.Text, this.ID);
                        RequestBookTableAdapter.Fill(requestBooks);
                        dataGridView1.DataSource = requestBooks;
                        dataGridView1.Refresh();
                        state = "Requests";
                        labelControl(ID);
                        labelControl(-3);
                    }
                    else
                    {
                                lblWarning.Text = "Please Fill Required Fields in correct format";
                        foreach (var ab in errors)
                        {
                            if (ab.Value)
                            {
                                switch (ab.Key)
                                {
                                    case "text2":
                                        textBox2.BackColor = Color.Red;
                                        break;
                                    case "text3":
                                        textBox3.BackColor = Color.Red;
                                        break;
                                    case "text4":
                                        textBox4.BackColor = Color.Red;
                                        break;
                                    case "text5":
                                        textBox5.BackColor = Color.Red;
                                        break;
                                    case "text6":
                                        textBox6.BackColor = Color.Red;
                                        break;
                                    case "text7":
                                        textBox7.BackColor = Color.Red;
                                        break;
                                    case "text8":
                                        textBox8.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                    }
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.FormattedValue.ToString() != "")
            {

                btn = "Edit";
                if (state == "Books")
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["BookID"].FormattedValue.ToString());
                    labelControl(-1);
                    labelControl(ID);
                    this.ID = ID;
                }
                else if (state == "IssueBooks" || state == "OverDueBooks")
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["IssueID"].FormattedValue.ToString());
                    labelControl(-1);
                    labelControl(ID);
                    this.ID = ID;
                }
                else
                {
                    int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["RequestID"].FormattedValue.ToString());
                    RequestBookTableAdapter.UpdateRequestStatus(false, ID);
                    RequestBookTableAdapter.Fill(requestBooks);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = requestBooks;
                    dataGridView1.Refresh();
                    labelControl(ID);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            labelControl(-3);
            if (state == "Books")
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["BookID"].FormattedValue.ToString());
                BookTableAdapter.DeleteBook(ID);
                BookTableAdapter.Fill(Books);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = Books;
                dataGridView1.Refresh();
            }
            else if (state == "IssueBooks" || state == "OverDueBooks")
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["IssueID"].FormattedValue.ToString());
                ibtm.DeleteIssueBook(ID);
                ibtm.Fill(ibdt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ibdt;
                dataGridView1.Refresh();
            }
            else
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells["RequestID"].FormattedValue.ToString());
                RequestBookTableAdapter.DeleteRequest(ID);
                RequestBookTableAdapter.Fill(requestBooks);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = requestBooks;
                dataGridView1.Refresh();
            }
        }
        private Boolean validCheck(ref List<String> a, string type, ref Dictionary<string, Boolean> errors)
        {

            Boolean text2 = false;
            Boolean text3 = false;
            Boolean text4 = false;
            Boolean text5 = false;
            Boolean text6 = false;
            Boolean text7 = false;
            Boolean text8 = false;
            if (state == "Books")
            {
                int result;

                if (!int.TryParse(a[5], out result))
                {
                    text7 = true;
                }
            }
            else if (state == "IssueBooks" || state == "OverDueBooks")
            {
                DataTable table1 = BookTableAdapter.GetData();
                for (int i = 0; i < table1.Rows.Count; i++) {
                    if (table1.Rows[i]["BookID"].ToString() == a[0])
                    {
                        text2 = false;
                    }
                    else
                    {
                        text2 = true;
                    }

                }
                DataTable table2 = RegisterTableAdapter.GetDataUser();
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    if (table2.Rows[i]["UserID"].ToString() == a[1])
                    {
                        text3 = false;
                    }
                    else
                    {
                        text3 = true;
                    }

                }

                DateTime result1;
                if (DateTime.TryParse(a[2], out result1)) {
                    text4 = false;
                }
                else
                {
                    text4 = true;
                }
                DateTime result2;
                if (a[3] != null)
                {
                    if (DateTime.TryParse(a[3], out result2))
                    {
                        text5 = false;
                    }
                }
                else
                {
                    text5 = true;
                }
                DateTime result3;
                if (a[4] != null)
                {
                    if (DateTime.TryParse(a[4], out result3))
                    {
                        text6 = false;
                    }
                }
                else
                {
                    text6 = true;
                }
                int result4;
                if (a[5] != null)
                {
                    if (int.TryParse(a[5], out result4))
                    {
                        text7 = false;
                    }
                }
                else
                {
                    text7 = true;
                }

            }
            else
            {
                DataTable table1 = BookTableAdapter.GetData();
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (table1.Rows[i]["BookID"].ToString() == a[1])
                    {
                        text3 = false;
                    }
                    else
                    {
                        text3 = true;
                    }

                }
                DataTable table2 = RegisterTableAdapter.GetDataUser();
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    if (table2.Rows[i]["UserID"].ToString() == a[0])
                    {
                        text2 = false;
                    }
                    else
                    {
                        text2 = true;
                    }

                }

                //    textBox4.Text = a.Rows[0]["Status"].ToString();

                DateTime result1;
                if (DateTime.TryParse(a[3], out result1))
                {
                    text5 = false;
                }
                else
                {
                    text5 = true;
                }
                // textBox6.Text = a.Rows[0]["RequestType"].ToString();

            }
            errors.Add("text2", text2);
            errors.Add("text3", text3);
            errors.Add("text4", text4);
            errors.Add("text5", text5);
            errors.Add("text6", text6);
            errors.Add("text7", text7);
            errors.Add("text8", text8);
            foreach (var error in errors)
            {
                if (error.Value)
                {
                    return !error.Value;
                }
            }
            return true;
        }
        //This method will accept request according to their type and afer checking different conditions.
        private void acceptRequest(int requestID)
        {
             RequestTableAdapterlms.FillByRequestID(requestslms,requestID);
          int  userID = Convert.ToInt32(requestslms.Rows[0]["UserId"]);
            int bookID = Convert.ToInt32(requestslms.Rows[0]["BookId"]);
            String requestType = requestslms.Rows[0]["RequestType"].ToString();
            if (requestType=="issue")
            {
                DataTable e = RegisterTableAdapter.GetDataByNooReIssue(userID);
                if (( Convert.ToInt32(e.Rows[0]["NoofReIssue"])- ibtm.getNoOfReissue(bookID, userID)) > 0)
                {
                    RequestBookTableAdapter.UpdateRequestStatus(true, requestID);
                    ibtm.InsertIssueBook(userID,bookID, DateTime.Now.ToShortDateString(), DateTime.Now.AddDays(15).ToShortDateString(), null, null, null);
                }
            }

            else if (requestType=="extend")
            {
                DataTable b = RequestBookTableAdapter.GetDataByPreviousRequest(bookID, Convert.ToDateTime(requestslms.Rows[0]["RequestDate"]).ToShortDateString());
                DataTable c = BookTableAdapter.GetDataByBookID(Convert.ToInt32(requestslms.Rows[0]["BookID"]));
                DataTable d = ibtm.GetDataByEreturnDate(userID,bookID);
                if (b.Rows.Count <= 0&& Convert.ToInt32(c.Rows[0]["NoofCopy"]) >0)
                {
                    RequestBookTableAdapter.UpdateRequestStatus(true, requestID);
                    ibtm.UpdateEReturnDate(Convert.ToDateTime(d.Rows[0]["ExpectedReturn"]).AddDays(15).ToShortDateString(), userID,bookID);
                }

            }
            else if(requestType=="return")
            {
                DataTable d = ibtm.GetDataByEreturnDate(userID,bookID);
                ibtm.UpdateReturn(DateTime.Now.ToShortDateString(), Convert.ToInt32(DateTime.Now.Subtract(Convert.ToDateTime(d.Rows[0]["ExpectedReturn"])))*1,userID,bookID);
            }
            else
            {
                ibtm.UpdatePaymentStatus("true", userID, bookID);
            }

        }

        private void lnklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LMS.Program.UserID = "";
            this.Hide();
            LMS.LoginForm lf = new LMS.LoginForm();
            lf.Show();
        }
    }
    
}
