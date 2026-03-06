using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using LibraryProject.ConnectionString;
using LibraryProject.Dtos;

namespace LibraryProject
{
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }
        private void LoadMembers()
        {
            using(IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var members = conn.Query<MemberDto>(@"
                     Select MemberId, MemberFullName, MemberPhone, MemberEmail
                      
                     From Members
                     Order by MemberId Desc").ToList();
                dgvMembers.DataSource = members;
            }
        }
        private void SearchMembers(string keyword)
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var members = conn.Query<MemberDto>(@"
                    Select MemberId, MemberFullName,MemberPhone,MemberEmail
                    From Members
                    where 
                        (@K IS NULL OR @K= '') OR
                        (MemberFullName LIKE '%' +@K + '%'
                        OR MemberPhone LIKE '%' +@K + '%'
                        OR MemberEmail LIKE '%' +@K + '%')
                    Order by MemberId DESC",
                    new {K = keyword}).ToList();
                dgvMembers.DataSource = members;
            }
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            LoadMembers();


        }

        private void btnList_Click(object sender, EventArgs e)
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var members = conn.Query<MemberDto>(@"
                    Select MemberId,MemberFullName,MemberPhone,MemberEmail
                    from Members
                    order by MemberId DESC").ToList();
                dgvMembers.DataSource = members;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Ad soyad alanı boş kalamaz");
            }
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                conn.Execute(@"
                    INSERT INTO Members (MemberFullName, MemberPhone, MemberEmail)
                    Values (@MemberFullName, @MemberPhone, @MemberEmail)",
                    new
                    {
                        MemberFullName = txtFullName.Text.Trim(),
                        MemberPhone = txtPhone.Text.Trim(),
                        MemberEmail = txtEmail.Text.Trim(),
                    });
            }
            LoadMembers();
            MessageBox.Show("Üye eklendi");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                conn.Execute(@"Delete from Members Where MemberId = @memberId", new { MemberId = int.Parse(txtMemberId.Text) });
            }
            LoadMembers() ;
            MessageBox.Show("Üye silindi");

        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var selected = dgvMembers.Rows[e.RowIndex].DataBoundItem as MemberDto;
            if(selected == null) return;

                txtMemberId.Text = selected.MemberId.ToString();
                txtFullName.Text = selected.MemberFullName;
                txtPhone.Text = selected.MemberPhone;
                txtEmail.Text = selected.MemberEmail;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                conn.Execute(@"
                     Update Members
                     Set MemberFullName = @MemberFullName,
                      MemberPhone = @MemberPhone,
                      MemberEmail = @MemberEmail
                    Where MemberId = @MemberId",
                    new
                    {
                        MemberId = int.Parse(txtMemberId.Text),
                        MemberFullName = txtFullName.Text.Trim(),
                        MemberPhone = txtPhone.Text.Trim(),
                        MemberEmail = txtEmail.Text.Trim(),
                    });
            }
            LoadMembers() ;
            MessageBox.Show("Üye Güncellendi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMembers(txtSearch.Text.Trim());
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if(this.Owner!=null)
                this.Owner.Show();
            this.Close();

        }
    }
}
