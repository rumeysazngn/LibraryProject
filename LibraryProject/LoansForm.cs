using Dapper;
using LibraryProject.ConnectionString;
using LibraryProject.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class LoansForm : Form
    {
        public LoansForm()
        {
            InitializeComponent();
        }
        private void LoadMembers()
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var members = conn.Query<MemberDto>("Select MemberId,MemberFullName from Members").ToList();

                cmbMember.DataSource = members;
                cmbMember.DisplayMember = "MemberFullName";
                cmbMember.ValueMember = "MemberId";
                cmbMember.SelectedIndex = -1;
            }
        }
        private void LoadBooks() //stokta olan kşitaplar
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var books = conn.Query("Select BookId, BookTitle From Books where StockAvailable > 0").ToList();
                cmbBook.DataSource = books;
                cmbBook.DisplayMember = "BookTitle";
                cmbBook.ValueMember = "BookId";
                cmbBook.SelectedIndex = -1;
            }
        }
        private void LoadLoans()
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var loans = conn.Query(@"
                    select L.LoanId, M.MemberFullName,
                    B.BookTitle, L.LoanDate, L.DueDate,L.ReturnDate,L.Status
                    from Loans L
                    INNER JOIN Members M ON M.MemberId = L.MemberId
                    INNER JOIN Books B ON B.BookId = L.BookId
                    ORDER BY L.LoanId desc").ToList();
                dgvLoans.DataSource = loans;
            }
        }

        private void LoansForm_Load(object sender, EventArgs e)
        {
            
            dtpDueDate.Value = DateTime.Now.AddDays(7);
            dtpLoanDate.Value = DateTime.Now;

            LoadMembers();
            LoadBooks();
            LoadLoans();

        }

        private void btnGiveLoan_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedValue == null || cmbBook.SelectedValue == null)
            {
                MessageBox.Show("Üye ve kitap seçmelisin.");
                return;
            }

            int memberId = Convert.ToInt32(cmbMember.SelectedValue);
            int bookId = Convert.ToInt32(cmbBook.SelectedValue);

            // tarih kontrolü (opsiyonel ama iyi)
            if (dtpDueDate.Value.Date < dtpLoanDate.Value.Date)
            {
                MessageBox.Show("Teslim tarihi, alış tarihinden önce olamaz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DatabaseConnectionString.ConnStr))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                     
                        int stock = conn.ExecuteScalar<int>(
                            "SELECT ISNULL(StockAvailable,0) FROM Books WHERE BookId=@BookId",
                            new { BookId = bookId },
                            tran);

                        if (stock <= 0)
                            throw new Exception("Bu kitabın stokta uygun kopyası yok.");

                      
                        conn.Execute(@"
                    INSERT INTO Loans (BookId, MemberId, LoanDate, DueDate, Status)
                    Values (@BookId, @MemberId, @LoanDate, @DueDate, 'OnLoan')",
                            new
                            {
                                BookId = bookId,
                                MemberId = memberId,
                                LoanDate = dtpLoanDate.Value.Date,
                                DueDate = dtpDueDate.Value.Date
                            },
                            tran);

                        
                        conn.Execute(@"
                    UPDATE Books
                    Set StockAvailable = ISNULL(StockAvailable,0) - 1
                    Where BookId = @BookId",
                            new { BookId = bookId },
                            tran);

                        tran.Commit();
                        MessageBox.Show("Kitap ödünç verildi.");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            
            LoadLoans();
            LoadBooks(); // stok>0 olanlar güncelle
        }

        private void btnReturnLoad_Click(object sender, EventArgs e)
        {
            if(dgvLoans.CurrentRow == null)
            {
                MessageBox.Show("Listeden bir kayıt seçmelisin");
                return;
            }
            int loanId = Convert.ToInt32(dgvLoans.CurrentRow.Cells["LoanId"].Value);
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionString.ConnStr))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        int bookId = conn.ExecuteScalar<int>(@"
                                Select BookId From Loans where LoanId = @LoanId and Status='OnLoan'",
                                new { LoanId = loanId },
                                tran);
                        if( bookId == 0)
                            throw new Exception("Bu Kayıt zaten iade edilmiş");
                        conn.Execute(@"Update Loans Set ReturnDate = @ReturnDate,
                                            Status = 'Returned' where LoanId = @LoanId",
                                            new { LoanId = loanId, ReturnDate = DateTime.Now.Date }, tran);

                        conn.Execute(@"Update Books Set StockAvailable=ISNULL(StockAvailable,0) +1
                                            where BookId = @BookId",
                                            new { BookId = bookId }, tran);
                        tran.Commit();
                        MessageBox.Show("Kitap iadesi alındı");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message); 
                    }

                }

            }
            LoadLoans();
            LoadBooks();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
            this.Close();
        }

        private void dgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
