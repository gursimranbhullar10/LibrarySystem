namespace LMS
{
	partial class MemberPage
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
			this.pnlProfile = new System.Windows.Forms.Panel();
			this.lnkLblDelete = new System.Windows.Forms.LinkLabel();
			this.btnPass = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.lnkLblChangePassword = new System.Windows.Forms.LinkLabel();
			this.lnkLblLogout = new System.Windows.Forms.LinkLabel();
			this.btnCloseEdit = new System.Windows.Forms.Button();
			this.btnUpdatePhone = new System.Windows.Forms.Button();
			this.btnEditContactInfo = new System.Windows.Forms.Button();
			this.txtFname = new System.Windows.Forms.TextBox();
			this.txtLname = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblProfile = new System.Windows.Forms.Label();
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnPic = new System.Windows.Forms.Button();
			this.PbProfilePic = new System.Windows.Forms.PictureBox();
			this.pnlWorking = new System.Windows.Forms.Panel();
			this.BtnHistory = new System.Windows.Forms.Button();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.pnlProfile.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbProfilePic)).BeginInit();
			this.pnlWorking.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlProfile
			// 
			this.pnlProfile.Controls.Add(this.lnkLblDelete);
			this.pnlProfile.Controls.Add(this.btnPass);
			this.pnlProfile.Controls.Add(this.txtPass);
			this.pnlProfile.Controls.Add(this.lnkLblChangePassword);
			this.pnlProfile.Controls.Add(this.lnkLblLogout);
			this.pnlProfile.Controls.Add(this.btnCloseEdit);
			this.pnlProfile.Controls.Add(this.btnUpdatePhone);
			this.pnlProfile.Controls.Add(this.btnEditContactInfo);
			this.pnlProfile.Controls.Add(this.txtFname);
			this.pnlProfile.Controls.Add(this.txtLname);
			this.pnlProfile.Controls.Add(this.txtEmail);
			this.pnlProfile.Controls.Add(this.txtPhone);
			this.pnlProfile.Controls.Add(this.label5);
			this.pnlProfile.Controls.Add(this.label4);
			this.pnlProfile.Controls.Add(this.label3);
			this.pnlProfile.Controls.Add(this.label2);
			this.pnlProfile.Controls.Add(this.lblProfile);
			this.pnlProfile.Controls.Add(this.BtnClear);
			this.pnlProfile.Controls.Add(this.BtnPic);
			this.pnlProfile.Controls.Add(this.PbProfilePic);
			this.pnlProfile.Location = new System.Drawing.Point(18, 12);
			this.pnlProfile.Name = "pnlProfile";
			this.pnlProfile.Size = new System.Drawing.Size(584, 227);
			this.pnlProfile.TabIndex = 5;
			// 
			// lnkLblDelete
			// 
			this.lnkLblDelete.AutoSize = true;
			this.lnkLblDelete.Location = new System.Drawing.Point(54, 214);
			this.lnkLblDelete.Name = "lnkLblDelete";
			this.lnkLblDelete.Size = new System.Drawing.Size(81, 13);
			this.lnkLblDelete.TabIndex = 36;
			this.lnkLblDelete.TabStop = true;
			this.lnkLblDelete.Text = "Delete Account";
			this.lnkLblDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblDelete_LinkClicked);
			// 
			// btnPass
			// 
			this.btnPass.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPass.Location = new System.Drawing.Point(442, 36);
			this.btnPass.Name = "btnPass";
			this.btnPass.Size = new System.Drawing.Size(139, 31);
			this.btnPass.TabIndex = 35;
			this.btnPass.Text = "Change and save";
			this.btnPass.UseVisualStyleBackColor = true;
			this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(424, 8);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(157, 20);
			this.txtPass.TabIndex = 34;
			// 
			// lnkLblChangePassword
			// 
			this.lnkLblChangePassword.AutoSize = true;
			this.lnkLblChangePassword.Location = new System.Drawing.Point(325, 11);
			this.lnkLblChangePassword.Name = "lnkLblChangePassword";
			this.lnkLblChangePassword.Size = new System.Drawing.Size(93, 13);
			this.lnkLblChangePassword.TabIndex = 33;
			this.lnkLblChangePassword.TabStop = true;
			this.lnkLblChangePassword.Text = "Change Password";
			this.lnkLblChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblChangePassword_LinkClicked);
			// 
			// lnkLblLogout
			// 
			this.lnkLblLogout.AutoSize = true;
			this.lnkLblLogout.Location = new System.Drawing.Point(518, 11);
			this.lnkLblLogout.Name = "lnkLblLogout";
			this.lnkLblLogout.Size = new System.Drawing.Size(52, 13);
			this.lnkLblLogout.TabIndex = 32;
			this.lnkLblLogout.TabStop = true;
			this.lnkLblLogout.Text = "LOGOUT";
			this.lnkLblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLogout_LinkClicked);
			// 
			// btnCloseEdit
			// 
			this.btnCloseEdit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseEdit.Location = new System.Drawing.Point(449, 175);
			this.btnCloseEdit.Name = "btnCloseEdit";
			this.btnCloseEdit.Size = new System.Drawing.Size(121, 38);
			this.btnCloseEdit.TabIndex = 31;
			this.btnCloseEdit.Text = "Close Edit Mode";
			this.btnCloseEdit.UseVisualStyleBackColor = true;
			this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
			// 
			// btnUpdatePhone
			// 
			this.btnUpdatePhone.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdatePhone.Location = new System.Drawing.Point(430, 122);
			this.btnUpdatePhone.Name = "btnUpdatePhone";
			this.btnUpdatePhone.Size = new System.Drawing.Size(140, 28);
			this.btnUpdatePhone.TabIndex = 30;
			this.btnUpdatePhone.Text = "Update Phone";
			this.btnUpdatePhone.UseVisualStyleBackColor = true;
			this.btnUpdatePhone.Click += new System.EventHandler(this.btnUpdatePhone_Click);
			// 
			// btnEditContactInfo
			// 
			this.btnEditContactInfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditContactInfo.Location = new System.Drawing.Point(304, 190);
			this.btnEditContactInfo.Name = "btnEditContactInfo";
			this.btnEditContactInfo.Size = new System.Drawing.Size(139, 34);
			this.btnEditContactInfo.TabIndex = 28;
			this.btnEditContactInfo.Text = "Edit Contact Info";
			this.btnEditContactInfo.UseVisualStyleBackColor = true;
			this.btnEditContactInfo.Click += new System.EventHandler(this.btnEditContactInfo_Click);
			// 
			// txtFname
			// 
			this.txtFname.Location = new System.Drawing.Point(304, 54);
			this.txtFname.Name = "txtFname";
			this.txtFname.Size = new System.Drawing.Size(120, 20);
			this.txtFname.TabIndex = 27;
			// 
			// txtLname
			// 
			this.txtLname.Location = new System.Drawing.Point(304, 91);
			this.txtLname.Name = "txtLname";
			this.txtLname.Size = new System.Drawing.Size(120, 20);
			this.txtLname.TabIndex = 26;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(304, 164);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(120, 20);
			this.txtEmail.TabIndex = 25;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(304, 130);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(120, 20);
			this.txtPhone.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(193, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(193, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Phone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(193, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Last Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(190, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "First Name";
			// 
			// lblProfile
			// 
			this.lblProfile.AutoSize = true;
			this.lblProfile.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProfile.Location = new System.Drawing.Point(189, 13);
			this.lblProfile.Name = "lblProfile";
			this.lblProfile.Size = new System.Drawing.Size(130, 22);
			this.lblProfile.TabIndex = 14;
			this.lblProfile.Text = "Member Profile";
			this.lblProfile.Click += new System.EventHandler(this.label1_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnClear.Location = new System.Drawing.Point(106, 175);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(73, 36);
			this.BtnClear.TabIndex = 2;
			this.BtnClear.Text = "Remove";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// BtnPic
			// 
			this.BtnPic.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPic.Location = new System.Drawing.Point(10, 175);
			this.BtnPic.Name = "BtnPic";
			this.BtnPic.Size = new System.Drawing.Size(73, 36);
			this.BtnPic.TabIndex = 1;
			this.BtnPic.Text = "Upload";
			this.BtnPic.UseVisualStyleBackColor = true;
			this.BtnPic.Click += new System.EventHandler(this.BtnPic_Click);
			// 
			// PbProfilePic
			// 
			this.PbProfilePic.Image = global::LMS.Properties.Resources.Profile;
			this.PbProfilePic.ImageLocation = "";
			this.PbProfilePic.Location = new System.Drawing.Point(10, 14);
			this.PbProfilePic.Name = "PbProfilePic";
			this.PbProfilePic.Size = new System.Drawing.Size(169, 155);
			this.PbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PbProfilePic.TabIndex = 0;
			this.PbProfilePic.TabStop = false;
			// 
			// pnlWorking
			// 
			this.pnlWorking.Controls.Add(this.BtnHistory);
			this.pnlWorking.Controls.Add(this.BtnSearch);
			this.pnlWorking.Location = new System.Drawing.Point(18, 242);
			this.pnlWorking.Name = "pnlWorking";
			this.pnlWorking.Size = new System.Drawing.Size(584, 157);
			this.pnlWorking.TabIndex = 4;
			// 
			// BtnHistory
			// 
			this.BtnHistory.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHistory.Location = new System.Drawing.Point(167, 89);
			this.BtnHistory.Name = "BtnHistory";
			this.BtnHistory.Size = new System.Drawing.Size(267, 65);
			this.BtnHistory.TabIndex = 1;
			this.BtnHistory.Text = "LIBRARY HISTORY";
			this.BtnHistory.UseVisualStyleBackColor = true;
			this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
			// 
			// BtnSearch
			// 
			this.BtnSearch.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSearch.Location = new System.Drawing.Point(167, 3);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(267, 65);
			this.BtnSearch.TabIndex = 0;
			this.BtnSearch.Text = "FIND A BOOK";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// MemberPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(617, 405);
			this.Controls.Add(this.pnlProfile);
			this.Controls.Add(this.pnlWorking);
			this.MaximizeBox = false;
			this.Name = "MemberPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MemberPage";
			this.Load += new System.EventHandler(this.MemberPage_Load);
			this.pnlProfile.ResumeLayout(false);
			this.pnlProfile.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbProfilePic)).EndInit();
			this.pnlWorking.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlProfile;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnPic;
		private System.Windows.Forms.PictureBox PbProfilePic;
		private System.Windows.Forms.Panel pnlWorking;
		private System.Windows.Forms.Button BtnHistory;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblProfile;
		private System.Windows.Forms.Button btnUpdatePhone;
		private System.Windows.Forms.Button btnEditContactInfo;
		private System.Windows.Forms.TextBox txtFname;
		private System.Windows.Forms.TextBox txtLname;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Button btnCloseEdit;
		private System.Windows.Forms.LinkLabel lnkLblLogout;
		private System.Windows.Forms.LinkLabel lnkLblChangePassword;
		private System.Windows.Forms.Button btnPass;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.LinkLabel lnkLblDelete;
	}
}