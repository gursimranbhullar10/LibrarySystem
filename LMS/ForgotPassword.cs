using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace LMS
{
    public partial class ForgotPassword : Form
    {
        RegisterDatasetTableAdapters.RegisterTableAdapter adRegister;
        RegisterDataset.RegisterDataTable tblRegister;
        public ForgotPassword()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)));
            InitializeComponent();
            adRegister = new RegisterDatasetTableAdapters.RegisterTableAdapter();
            tblRegister = new RegisterDataset.RegisterDataTable();
        }

        public Boolean validateMe()
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter Email");
                return false;
            }
            return true;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (validateMe())
            {

                SmtpClient client = new SmtpClient();

                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("chokem18@gmail.com", "Zxcvbnm@1");
                client.EnableSsl = true;

                try
                {
                    adRegister.FillByEmail(tblRegister, txtEmail.Text);
                    if (tblRegister.Count == 1)
                    {
                        var row = tblRegister[0];
                        MailMessage message = new MailMessage("chokem18@gmail.com", txtEmail.Text, "Password Recovery for Library Management System", "Your Password is :  " + row.Password);
                        client.Send(message);
                        MessageBox.Show("Email sent succesfully..!!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry.. We can't find EmailId !!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information");
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex emailValidation = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmail.Text.Length > 0)
            {
                if (!emailValidation.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Please enter valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
