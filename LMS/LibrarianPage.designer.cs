namespace WindowsFormsApp1
{
    partial class LibrarianPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cmbFilters = new System.Windows.Forms.ComboBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnShowBooks = new System.Windows.Forms.Button();
			this.btnIssuedBooks = new System.Windows.Forms.Button();
			this.btnOverdueBooks = new System.Windows.Forms.Button();
			this.btnRequest = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblWarning = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEMail = new System.Windows.Forms.Label();
			this.txtPhoneNo = new System.Windows.Forms.TextBox();
			this.lblMobileNo = new System.Windows.Forms.Label();
			this.pctrBox = new System.Windows.Forms.PictureBox();
			this.lnklblLogout = new System.Windows.Forms.LinkLabel();
			this.DataSet1 = new WindowsFormsApp1.DataSet1();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(24, 262);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(481, 325);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// cmbFilters
			// 
			this.cmbFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFilters.FormattingEnabled = true;
			this.cmbFilters.Items.AddRange(new object[] {
            "Search Type",
            "Book ID",
            "Book Name",
            "Book Publisher",
            "Book Author",
            "Book Category",
            "ISBN"});
			this.cmbFilters.Location = new System.Drawing.Point(698, 188);
			this.cmbFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbFilters.Name = "cmbFilters";
			this.cmbFilters.Size = new System.Drawing.Size(92, 21);
			this.cmbFilters.TabIndex = 1;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(804, 188);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(113, 20);
			this.txtSearch.TabIndex = 2;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(927, 179);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(70, 36);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(928, 301);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(70, 36);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(928, 369);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(70, 36);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(928, 434);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(70, 36);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(928, 502);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(70, 36);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnShowBooks
			// 
			this.btnShowBooks.Location = new System.Drawing.Point(42, 200);
			this.btnShowBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnShowBooks.Name = "btnShowBooks";
			this.btnShowBooks.Size = new System.Drawing.Size(70, 36);
			this.btnShowBooks.TabIndex = 8;
			this.btnShowBooks.Text = "All Books";
			this.btnShowBooks.UseVisualStyleBackColor = true;
			this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
			// 
			// btnIssuedBooks
			// 
			this.btnIssuedBooks.Location = new System.Drawing.Point(142, 200);
			this.btnIssuedBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnIssuedBooks.Name = "btnIssuedBooks";
			this.btnIssuedBooks.Size = new System.Drawing.Size(70, 36);
			this.btnIssuedBooks.TabIndex = 9;
			this.btnIssuedBooks.Text = "Issued Books";
			this.btnIssuedBooks.UseVisualStyleBackColor = true;
			this.btnIssuedBooks.Click += new System.EventHandler(this.btnIssuedBooks_Click);
			// 
			// btnOverdueBooks
			// 
			this.btnOverdueBooks.Location = new System.Drawing.Point(242, 200);
			this.btnOverdueBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnOverdueBooks.Name = "btnOverdueBooks";
			this.btnOverdueBooks.Size = new System.Drawing.Size(70, 36);
			this.btnOverdueBooks.TabIndex = 10;
			this.btnOverdueBooks.Text = "Overdue Books";
			this.btnOverdueBooks.UseVisualStyleBackColor = true;
			this.btnOverdueBooks.Click += new System.EventHandler(this.btnOverdueBooks_Click);
			// 
			// btnRequest
			// 
			this.btnRequest.Location = new System.Drawing.Point(342, 200);
			this.btnRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRequest.Name = "btnRequest";
			this.btnRequest.Size = new System.Drawing.Size(70, 36);
			this.btnRequest.TabIndex = 11;
			this.btnRequest.Text = "Requests";
			this.btnRequest.UseVisualStyleBackColor = true;
			this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(569, 312);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Book Name:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(685, 312);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(113, 20);
			this.textBox2.TabIndex = 13;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(685, 349);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(113, 20);
			this.textBox3.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(569, 349);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Publisher";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(685, 392);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(113, 20);
			this.textBox4.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(569, 392);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Author";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(685, 434);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(113, 20);
			this.textBox5.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(569, 434);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 20);
			this.label4.TabIndex = 18;
			this.label4.Text = "ISBN";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(685, 483);
			this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(113, 20);
			this.textBox6.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(569, 483);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 20;
			this.label5.Text = "Category";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(685, 525);
			this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(113, 20);
			this.textBox7.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(569, 525);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 22;
			this.label6.Text = "Stock Left";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(685, 567);
			this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(113, 20);
			this.textBox8.TabIndex = 25;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(569, 567);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 20);
			this.label7.TabIndex = 24;
			this.label7.Text = "Stock Left";
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWarning.ForeColor = System.Drawing.Color.Red;
			this.lblWarning.Location = new System.Drawing.Point(569, 242);
			this.lblWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 20);
			this.lblWarning.TabIndex = 26;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(298, 23);
			this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(60, 13);
			this.lblFirstName.TabIndex = 27;
			this.lblFirstName.Text = "First Name:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(377, 23);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(128, 20);
			this.txtFirstName.TabIndex = 28;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(377, 128);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(128, 20);
			this.txtLastName.TabIndex = 30;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(298, 128);
			this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(61, 13);
			this.lblLastName.TabIndex = 29;
			this.lblLastName.Text = "Last Name:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(695, 128);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(128, 20);
			this.txtEmail.TabIndex = 32;
			// 
			// lblEMail
			// 
			this.lblEMail.AutoSize = true;
			this.lblEMail.Location = new System.Drawing.Point(616, 128);
			this.lblEMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEMail.Name = "lblEMail";
			this.lblEMail.Size = new System.Drawing.Size(35, 13);
			this.lblEMail.TabIndex = 31;
			this.lblEMail.Text = "Email:";
			// 
			// txtPhoneNo
			// 
			this.txtPhoneNo.Location = new System.Drawing.Point(695, 23);
			this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPhoneNo.Name = "txtPhoneNo";
			this.txtPhoneNo.Size = new System.Drawing.Size(128, 20);
			this.txtPhoneNo.TabIndex = 34;
			// 
			// lblMobileNo
			// 
			this.lblMobileNo.AutoSize = true;
			this.lblMobileNo.Location = new System.Drawing.Point(616, 25);
			this.lblMobileNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMobileNo.Name = "lblMobileNo";
			this.lblMobileNo.Size = new System.Drawing.Size(81, 13);
			this.lblMobileNo.TabIndex = 33;
			this.lblMobileNo.Text = "Phone Number:";
			// 
			// pctrBox
			// 
			this.pctrBox.Location = new System.Drawing.Point(38, 25);
			this.pctrBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pctrBox.Name = "pctrBox";
			this.pctrBox.Size = new System.Drawing.Size(176, 121);
			this.pctrBox.TabIndex = 35;
			this.pctrBox.TabStop = false;
			// 
			// lnklblLogout
			// 
			this.lnklblLogout.AutoSize = true;
			this.lnklblLogout.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnklblLogout.Location = new System.Drawing.Point(946, 9);
			this.lnklblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lnklblLogout.Name = "lnklblLogout";
			this.lnklblLogout.Size = new System.Drawing.Size(65, 25);
			this.lnklblLogout.TabIndex = 36;
			this.lnklblLogout.TabStop = true;
			this.lnklblLogout.Text = "Logout";
			this.lnklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogout_LinkClicked);
			// 
			// DataSet1
			// 
			this.DataSet1.DataSetName = "DataSet1";
			this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// LibrarianPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(1022, 623);
			this.Controls.Add(this.lnklblLogout);
			this.Controls.Add(this.pctrBox);
			this.Controls.Add(this.txtPhoneNo);
			this.Controls.Add(this.lblMobileNo);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEMail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRequest);
			this.Controls.Add(this.btnOverdueBooks);
			this.Controls.Add(this.btnIssuedBooks);
			this.Controls.Add(this.btnShowBooks);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.cmbFilters);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "LibrarianPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Librarian Page";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctrBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnIssuedBooks;
        private System.Windows.Forms.Button btnOverdueBooks;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DataSet1TableAdapters.Book1TableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.PictureBox pctrBox;
        private System.Windows.Forms.LinkLabel lnklblLogout;
    }
}

