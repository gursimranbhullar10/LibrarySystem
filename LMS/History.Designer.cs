namespace LMS
{
	partial class History
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
			this.BtnHome = new System.Windows.Forms.Button();
			this.lblLibraryHistory = new System.Windows.Forms.Label();
			this.gridBooks = new System.Windows.Forms.DataGridView();
			this.TxtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnReturn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.gridRequest = new System.Windows.Forms.DataGridView();
			this.LblRequests = new System.Windows.Forms.Label();
			this.BtnLoadBooks = new System.Windows.Forms.Button();
			this.BtnLoadLogs = new System.Windows.Forms.Button();
			this.BtnExtend = new System.Windows.Forms.Button();
			this.BtnPayment = new System.Windows.Forms.Button();
			this.LoadAllBooksButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridRequest)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnHome
			// 
			this.BtnHome.Location = new System.Drawing.Point(884, 12);
			this.BtnHome.Name = "BtnHome";
			this.BtnHome.Size = new System.Drawing.Size(75, 23);
			this.BtnHome.TabIndex = 1;
			this.BtnHome.Text = "Home Page";
			this.BtnHome.UseVisualStyleBackColor = true;
			this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
			// 
			// lblLibraryHistory
			// 
			this.lblLibraryHistory.AutoSize = true;
			this.lblLibraryHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLibraryHistory.Location = new System.Drawing.Point(12, 9);
			this.lblLibraryHistory.Name = "lblLibraryHistory";
			this.lblLibraryHistory.Size = new System.Drawing.Size(341, 39);
			this.lblLibraryHistory.TabIndex = 13;
			this.lblLibraryHistory.Text = "LIBRARY HISTORY";
			// 
			// gridBooks
			// 
			this.gridBooks.AllowUserToAddRows = false;
			this.gridBooks.AllowUserToDeleteRows = false;
			this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBooks.Location = new System.Drawing.Point(19, 93);
			this.gridBooks.Name = "gridBooks";
			this.gridBooks.ReadOnly = true;
			this.gridBooks.Size = new System.Drawing.Size(940, 255);
			this.gridBooks.TabIndex = 10;
			// 
			// TxtId
			// 
			this.TxtId.Location = new System.Drawing.Point(86, 364);
			this.TxtId.Name = "TxtId";
			this.TxtId.Size = new System.Drawing.Size(100, 20);
			this.TxtId.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 367);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Issue ID";
			// 
			// BtnReturn
			// 
			this.BtnReturn.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnReturn.Location = new System.Drawing.Point(429, 354);
			this.BtnReturn.Name = "BtnReturn";
			this.BtnReturn.Size = new System.Drawing.Size(155, 50);
			this.BtnReturn.TabIndex = 16;
			this.BtnReturn.Text = "Generate Request To Return Book";
			this.BtnReturn.UseVisualStyleBackColor = true;
			this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 28);
			this.label2.TabIndex = 17;
			this.label2.Text = "Books Issued";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// gridRequest
			// 
			this.gridRequest.AllowUserToAddRows = false;
			this.gridRequest.AllowUserToDeleteRows = false;
			this.gridRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridRequest.Location = new System.Drawing.Point(22, 435);
			this.gridRequest.Name = "gridRequest";
			this.gridRequest.ReadOnly = true;
			this.gridRequest.Size = new System.Drawing.Size(745, 150);
			this.gridRequest.TabIndex = 18;
			this.gridRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRequest_CellContentClick);
			// 
			// LblRequests
			// 
			this.LblRequests.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblRequests.Location = new System.Drawing.Point(17, 401);
			this.LblRequests.Name = "LblRequests";
			this.LblRequests.Size = new System.Drawing.Size(142, 31);
			this.LblRequests.TabIndex = 0;
			this.LblRequests.Text = "MY LOGS";
			// 
			// BtnLoadBooks
			// 
			this.BtnLoadBooks.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLoadBooks.Location = new System.Drawing.Point(215, 354);
			this.BtnLoadBooks.Name = "BtnLoadBooks";
			this.BtnLoadBooks.Size = new System.Drawing.Size(94, 50);
			this.BtnLoadBooks.TabIndex = 19;
			this.BtnLoadBooks.Text = "LOAD MY ISSUE INFO";
			this.BtnLoadBooks.UseVisualStyleBackColor = true;
			this.BtnLoadBooks.Click += new System.EventHandler(this.BtnLoadBooks_Click);
			// 
			// BtnLoadLogs
			// 
			this.BtnLoadLogs.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLoadLogs.Location = new System.Drawing.Point(792, 498);
			this.BtnLoadLogs.Name = "BtnLoadLogs";
			this.BtnLoadLogs.Size = new System.Drawing.Size(155, 23);
			this.BtnLoadLogs.TabIndex = 20;
			this.BtnLoadLogs.Text = "LOAD MY LOGS";
			this.BtnLoadLogs.UseVisualStyleBackColor = true;
			this.BtnLoadLogs.Click += new System.EventHandler(this.BtnLoadLogs_Click);
			// 
			// BtnExtend
			// 
			this.BtnExtend.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnExtend.Location = new System.Drawing.Point(601, 354);
			this.BtnExtend.Name = "BtnExtend";
			this.BtnExtend.Size = new System.Drawing.Size(166, 50);
			this.BtnExtend.TabIndex = 21;
			this.BtnExtend.Text = "Generate Request To Extend Date";
			this.BtnExtend.UseVisualStyleBackColor = true;
			this.BtnExtend.Click += new System.EventHandler(this.BtnExtend_Click);
			// 
			// BtnPayment
			// 
			this.BtnPayment.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPayment.Location = new System.Drawing.Point(792, 354);
			this.BtnPayment.Name = "BtnPayment";
			this.BtnPayment.Size = new System.Drawing.Size(167, 50);
			this.BtnPayment.TabIndex = 22;
			this.BtnPayment.Text = "Generate Request To Make Payment";
			this.BtnPayment.UseVisualStyleBackColor = true;
			this.BtnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
			// 
			// LoadAllBooksButton
			// 
			this.LoadAllBooksButton.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadAllBooksButton.Location = new System.Drawing.Point(315, 354);
			this.LoadAllBooksButton.Name = "LoadAllBooksButton";
			this.LoadAllBooksButton.Size = new System.Drawing.Size(98, 50);
			this.LoadAllBooksButton.TabIndex = 23;
			this.LoadAllBooksButton.Text = "LOAD ALL BOOKS INFO";
			this.LoadAllBooksButton.UseVisualStyleBackColor = true;
			this.LoadAllBooksButton.Click += new System.EventHandler(this.LoadAllBooksButton_Click);
			// 
			// History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(971, 596);
			this.Controls.Add(this.LoadAllBooksButton);
			this.Controls.Add(this.BtnPayment);
			this.Controls.Add(this.BtnExtend);
			this.Controls.Add(this.BtnLoadLogs);
			this.Controls.Add(this.BtnLoadBooks);
			this.Controls.Add(this.LblRequests);
			this.Controls.Add(this.gridRequest);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnReturn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtId);
			this.Controls.Add(this.lblLibraryHistory);
			this.Controls.Add(this.gridBooks);
			this.Controls.Add(this.BtnHome);
			this.MaximizeBox = false;
			this.Name = "History";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MY LOGS";
			this.Load += new System.EventHandler(this.History_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridRequest)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnHome;
		private System.Windows.Forms.Label lblLibraryHistory;
		private System.Windows.Forms.DataGridView gridBooks;
		private System.Windows.Forms.TextBox TxtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnReturn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gridRequest;
		private System.Windows.Forms.Label LblRequests;
		private System.Windows.Forms.Button BtnLoadBooks;
		private System.Windows.Forms.Button BtnLoadLogs;
		private System.Windows.Forms.Button BtnExtend;
		private System.Windows.Forms.Button BtnPayment;
		private System.Windows.Forms.Button LoadAllBooksButton;
	}
}