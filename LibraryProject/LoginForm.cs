using LibraryProject.Repositories;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)){
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                return;
            }
            var repo = new UserRepository();
            var user = repo.ValidateUser(username, password);
            if(user == null)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                return;
            }

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                return;
            }
            var repo = new UserRepository();
            var user = repo.ValidateUser(username, password);
            if (user == null)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                return;
            }

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
