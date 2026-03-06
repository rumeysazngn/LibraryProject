using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooksForm frm = new BooksForm();
            frm.Owner = this;      
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MembersForm frm = new MembersForm();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnNoals_Click(object sender, EventArgs e)
        {
            LoansForm frm = new LoansForm();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btngecikenler_Click(object sender, EventArgs e)
        {
            OverdueForm frm = new OverdueForm();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm frm = new DashboardForm();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}
