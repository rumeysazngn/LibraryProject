using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Grafikler için bu kütüphane şart
using Dapper;
using LibraryProject.ConnectionString;

namespace LibraryProject
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void LoadDashboard()
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                
                // 1. ÜST PANEL: ÖZET RAKAMLAR
               

                int totalBooks = conn.ExecuteScalar<int>("Select COUNT(*) FROM Books");
                lblTotalBooks.Text = totalBooks.ToString();

                lblTotalMembers.Text = conn.ExecuteScalar<int>("Select Count(*) FROM Members").ToString();

                lblOverdueBook.Text = conn.ExecuteScalar<int>("Select count(*) FROM Loans where Status='OnLoan' and DueDate < Cast(GETDATE() AS DATE)").ToString();

                //lblDueMember.Text = conn.ExecuteScalar<int>("SELECT COUNT(DISTINCT MemberId) From Loans Where Status ='OnLoan' and DueDate < CAST(GETDATE() AS DATE)").ToString();

                
                // 2. ALT PANEL: TOP 5 LİSTELERİ (DATAGRIDVIEW)
               

                // En Çok Okunan 5 Kitap (Dapper Query ile listeyi doğrudan Grid'e bağlıyoruz)
                var topBooksQuery = @"
                    Select TOP 5 B.BookTitle as 'Kitap Adı', COUNT(*) as 'Okunma Sayısı' 
                    From Loans L 
                    INNER JOIN Books B ON B.BookId = L.BookId
                    group by B.BookTitle order by COUNT(*) DESC";
                dgvTopBooks.DataSource = conn.Query(topBooksQuery).ToList();

                // En Çok Kitap Okuyan 5 Üye
                var topMembersQuery = @"
                    Select TOP 5 M.MemberFullName as 'Üye Adı', Count(*) as 'Okuduğu Kitap' 
                    From Loans L 
                    INNER JOIN Members M ON M.MemberId = L.MemberId
                    group by M.MemberFullName order by Count(*) DESC";
                dgvTopMembers.DataSource = conn.Query(topMembersQuery).ToList();

                
                // 3. ORTA PANEL: GRAFİKLER (CHART)
               

                // --- Pasta Grafiği 
                int onLoanBooks = conn.ExecuteScalar<int>("Select count(*) FROM Loans where Status='OnLoan'");
                int availableBooks = totalBooks - onLoanBooks; // Toplam kitaptan ödünçtekileri çıkarıp raftakileri buluyoruz

               
                chartBookStatus.Series[0].Points.Clear();
                chartBookStatus.Series[0].Points.AddXY("Rafta", availableBooks);
                chartBookStatus.Series[0].Points.AddXY("Ödünçte", onLoanBooks);

                // --- Sütun Grafiği
                
                var monthlyLoansQuery = @"
                    SELECT DATENAME(month, LoanDate) as Ay, COUNT(*) as Adet
                    FROM Loans
                    WHERE YEAR(LoanDate) = YEAR(GETDATE())
                    GROUP BY DATENAME(month, LoanDate), MONTH(LoanDate)
                    ORDER BY MONTH(LoanDate)";

                var monthlyData = conn.Query(monthlyLoansQuery).ToList();

                
                chartMonthlyLoans.Series[0].Points.Clear();
                foreach (var item in monthlyData)
                {
                    chartMonthlyLoans.Series[0].Points.AddXY(item.Ay, item.Adet);
                }
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
            this.Close();
        }

        private void chartBookStatus_Click(object sender, EventArgs e)
        {

        }
    }
}