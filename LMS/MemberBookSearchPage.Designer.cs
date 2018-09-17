namespace LMS
{
	partial class MemberBookSearchPage
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
			this.BtnHome = new System.Windows.Forms.Button();
			this.GridBooks = new System.Windows.Forms.DataGridView();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.BookDataSet = new System.Windows.Forms.BindingSource(this.components);
			this.libraryMSDataSet = new LMS.LibraryMSDataSet();
			this.cmbField = new System.Windows.Forms.ComboBox();
			this.cmbText = new System.Windows.Forms.ComboBox();
			this.LblSearchByField = new System.Windows.Forms.Label();
			this.LblSearchText = new System.Windows.Forms.Label();
			this.LstInfo = new System.Windows.Forms.ListBox();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.BtnIssue = new System.Windows.Forms.Button();
			this.bookTableAdapter = new LMS.LibraryMSDataSetTableAdapters.BookTableAdapter();
			this.lblSearchPage = new System.Windows.Forms.Label();
			this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.libraryMSDataSetRequest = new LMS.LibraryMSDataSet1();
			this.requestTableAdapter = new LMS.LibraryMSDataSet1TableAdapters.RequestTableAdapter();
			this.libraryMSDataSet2 = new LMS.LibraryMSDataSet2();
			this.BtnHistory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.bindingSourceId = new System.Windows.Forms.BindingSource(this.components);
			this.registerTableAdapter = new LMS.LibraryMSDataSetTableAdapters.RegisterTableAdapter();
			this.IssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.numOfIssuesTableAdapter = new LMS.LibraryMSDataSetTableAdapters.NumOfIssuesTableAdapter();
			this.bindingSourceCopies = new System.Windows.Forms.BindingSource(this.components);
			this.copiesTableAdapter = new LMS.LibraryMSDataSetTableAdapters.CopiesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.GridBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BookDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryMSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryMSDataSetRequest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryMSDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IssueBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceCopies)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnHome
			// 
			this.BtnHome.Location = new System.Drawing.Point(864, 11);
			this.BtnHome.Name = "BtnHome";
			this.BtnHome.Size = new System.Drawing.Size(75, 23);
			this.BtnHome.TabIndex = 0;
			this.BtnHome.Text = "Home Page";
			this.BtnHome.UseVisualStyleBackColor = true;
			this.BtnHome.Click += new System.EventHandler(this.button1_Click);
			// 
			// GridBooks
			// 
			this.GridBooks.AutoGenerateColumns = false;
			this.GridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
			this.GridBooks.DataSource = this.bookBindingSource;
			this.GridBooks.Location = new System.Drawing.Point(265, 40);
			this.GridBooks.Name = "GridBooks";
			this.GridBooks.Size = new System.Drawing.Size(674, 346);
			this.GridBooks.TabIndex = 1;
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			// 
			// authorDataGridViewTextBoxColumn
			// 
			this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
			this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
			this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
			// 
			// iSBNDataGridViewTextBoxColumn
			// 
			this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
			// 
			// publisherDataGridViewTextBoxColumn
			// 
			this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
			this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
			this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			// 
			// bookBindingSource
			// 
			this.bookBindingSource.DataMember = "Book";
			this.bookBindingSource.DataSource = this.BookDataSet;
			// 
			// BookDataSet
			// 
			this.BookDataSet.DataSource = this.libraryMSDataSet;
			this.BookDataSet.Position = 0;
			// 
			// libraryMSDataSet
			// 
			this.libraryMSDataSet.DataSetName = "LibraryMSDataSet";
			this.libraryMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbField
			// 
			this.cmbField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbField.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbField.FormattingEnabled = true;
			this.cmbField.Items.AddRange(new object[] {
            "BookId",
            "BookName",
            "Author",
            "ISBN",
            "Publisher",
            "Category",
            "NoofCopy"});
			this.cmbField.Location = new System.Drawing.Point(100, 40);
			this.cmbField.Name = "cmbField";
			this.cmbField.Size = new System.Drawing.Size(121, 25);
			this.cmbField.TabIndex = 2;
			this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
			// 
			// cmbText
			// 
			this.cmbText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbText.DataSource = this.bookBindingSource;
			this.cmbText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbText.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbText.FormattingEnabled = true;
			this.cmbText.Location = new System.Drawing.Point(100, 78);
			this.cmbText.Name = "cmbText";
			this.cmbText.Size = new System.Drawing.Size(121, 25);
			this.cmbText.TabIndex = 3;
			// 
			// LblSearchByField
			// 
			this.LblSearchByField.AutoSize = true;
			this.LblSearchByField.Location = new System.Drawing.Point(13, 40);
			this.LblSearchByField.Name = "LblSearchByField";
			this.LblSearchByField.Size = new System.Drawing.Size(81, 13);
			this.LblSearchByField.TabIndex = 4;
			this.LblSearchByField.Text = "Search By Field";
			// 
			// LblSearchText
			// 
			this.LblSearchText.AutoSize = true;
			this.LblSearchText.Location = new System.Drawing.Point(13, 86);
			this.LblSearchText.Name = "LblSearchText";
			this.LblSearchText.Size = new System.Drawing.Size(65, 13);
			this.LblSearchText.TabIndex = 5;
			this.LblSearchText.Text = "Search Text";
			// 
			// LstInfo
			// 
			this.LstInfo.DataSource = this.bookBindingSource;
			this.LstInfo.DisplayMember = "BookName";
			this.LstInfo.FormattingEnabled = true;
			this.LstInfo.Location = new System.Drawing.Point(12, 141);
			this.LstInfo.Name = "LstInfo";
			this.LstInfo.Size = new System.Drawing.Size(228, 199);
			this.LstInfo.TabIndex = 7;
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.FileName = "OpenDialog";
			// 
			// BtnIssue
			// 
			this.BtnIssue.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnIssue.Location = new System.Drawing.Point(12, 344);
			this.BtnIssue.Name = "BtnIssue";
			this.BtnIssue.Size = new System.Drawing.Size(114, 53);
			this.BtnIssue.TabIndex = 12;
			this.BtnIssue.Text = "Generate Request To Issue Book";
			this.BtnIssue.UseVisualStyleBackColor = true;
			this.BtnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
			// 
			// bookTableAdapter
			// 
			this.bookTableAdapter.ClearBeforeFill = true;
			// 
			// lblSearchPage
			// 
			this.lblSearchPage.AutoSize = true;
			this.lblSearchPage.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearchPage.Location = new System.Drawing.Point(12, 1);
			this.lblSearchPage.Name = "lblSearchPage";
			this.lblSearchPage.Size = new System.Drawing.Size(149, 36);
			this.lblSearchPage.TabIndex = 9;
			this.lblSearchPage.Text = "Search Page";
			// 
			// requestBindingSource
			// 
			this.requestBindingSource.DataMember = "Request";
			this.requestBindingSource.DataSource = this.libraryMSDataSetRequest;
			// 
			// libraryMSDataSetRequest
			// 
			this.libraryMSDataSetRequest.DataSetName = "LibraryMSDataSet1";
			this.libraryMSDataSetRequest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// requestTableAdapter
			// 
			this.requestTableAdapter.ClearBeforeFill = true;
			// 
			// libraryMSDataSet2
			// 
			this.libraryMSDataSet2.DataSetName = "LibraryMSDataSet2";
			this.libraryMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// BtnHistory
			// 
			this.BtnHistory.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHistory.Location = new System.Drawing.Point(132, 344);
			this.BtnHistory.Name = "BtnHistory";
			this.BtnHistory.Size = new System.Drawing.Size(114, 53);
			this.BtnHistory.TabIndex = 13;
			this.BtnHistory.Text = "My Library History";
			this.BtnHistory.UseVisualStyleBackColor = true;
			this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Select A Book to Issue:";
			// 
			// bindingSourceId
			// 
			this.bindingSourceId.DataMember = "Register";
			this.bindingSourceId.DataSource = this.libraryMSDataSet;
			// 
			// registerTableAdapter
			// 
			this.registerTableAdapter.ClearBeforeFill = true;
			// 
			// IssueBindingSource
			// 
			this.IssueBindingSource.DataMember = "NumOfIssues";
			this.IssueBindingSource.DataSource = this.libraryMSDataSet;
			// 
			// numOfIssuesTableAdapter
			// 
			this.numOfIssuesTableAdapter.ClearBeforeFill = true;
			// 
			// bindingSourceCopies
			// 
			this.bindingSourceCopies.DataMember = "Copies";
			this.bindingSourceCopies.DataSource = this.libraryMSDataSet;
			// 
			// copiesTableAdapter
			// 
			this.copiesTableAdapter.ClearBeforeFill = true;
			// 
			// MemberBookSearchPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(952, 418);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnHistory);
			this.Controls.Add(this.BtnIssue);
			this.Controls.Add(this.lblSearchPage);
			this.Controls.Add(this.LstInfo);
			this.Controls.Add(this.LblSearchText);
			this.Controls.Add(this.LblSearchByField);
			this.Controls.Add(this.cmbText);
			this.Controls.Add(this.cmbField);
			this.Controls.Add(this.GridBooks);
			this.Controls.Add(this.BtnHome);
			this.MaximizeBox = false;
			this.Name = "MemberBookSearchPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search My Book";
			this.Load += new System.EventHandler(this.MemberBookSearchPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BookDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryMSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryMSDataSetRequest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryMSDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IssueBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceCopies)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnHome;
		private System.Windows.Forms.DataGridView GridBooks;
		private System.Windows.Forms.ComboBox cmbField;
		private System.Windows.Forms.ComboBox cmbText;
		private System.Windows.Forms.Label LblSearchByField;
		private System.Windows.Forms.Label LblSearchText;
		private System.Windows.Forms.ListBox LstInfo;
		private System.Windows.Forms.BindingSource BookDataSet;
		private LibraryMSDataSet libraryMSDataSet;
		private System.Windows.Forms.Button BtnIssue;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		private System.Windows.Forms.BindingSource bookBindingSource;
		private LibraryMSDataSetTableAdapters.BookTableAdapter bookTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label lblSearchPage;
		private System.Windows.Forms.BindingSource requestBindingSource;
		private LibraryMSDataSet1 libraryMSDataSetRequest;
		private LibraryMSDataSet1TableAdapters.RequestTableAdapter requestTableAdapter;
		private LibraryMSDataSet2 libraryMSDataSet2;
		private System.Windows.Forms.Button BtnHistory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource bindingSourceId;
		private LibraryMSDataSetTableAdapters.RegisterTableAdapter registerTableAdapter;
		private System.Windows.Forms.BindingSource IssueBindingSource;
		private LibraryMSDataSetTableAdapters.NumOfIssuesTableAdapter numOfIssuesTableAdapter;
		private System.Windows.Forms.BindingSource bindingSourceCopies;
		private LibraryMSDataSetTableAdapters.CopiesTableAdapter copiesTableAdapter;
	}
}