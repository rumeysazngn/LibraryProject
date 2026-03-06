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
    public partial class OverdueForm : Form
    {
        public OverdueForm()
        {
            InitializeComponent();
        }
        private void LoadOverdues()
        {
            using(IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var list = conn.Query<OverdueDto>(@"

                    Select L.LoanId, M.MemberFullName, B.BookTitle, L.LoanDate, L.DueDate,
                        DATEDIFF(DAY,L.DueDate, CAST(GETDATE() AS DATE)) AS DaysLate
                    From Loans L
                    INNER JOIN Members M ON M.MemberId = L.MemberId
                    INNER JOIN Books B ON B.BookId = L.BookId
                    where L.Status = 'OnLoan' and L.DueDate < Cast(GETDATE() AS DATE)
                    ORDER BY DaysLate desc, L.DueDate ASC").ToList();
                dgvOverdues.DataSource = list;
            }
        }

        private void OverdueForm_Load(object sender, EventArgs e)
        {
            LoadOverdues();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if(this.Owner!=null)
            
                this.Owner.Show();
            this.Close();
            
        }
    }
}
