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
    public partial class ViewMembers : Form
    {

        /**
       * Name:Harsh patel
       * Description: this page is useful to display all members
       * */
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryMSDataSet4.Register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.libraryMSDataSet4.Register);

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ViewMembers vb = new ViewMembers();
            this.Hide();
            AdminProfile ap = new AdminProfile();
            ap.Show();

        }
    }
}
