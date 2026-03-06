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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }
        private void LoadBooks()
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var books = conn.Query<BookDto>(@"
                    SELECT 
                        B.BookId,
                        B.BookTitle,
                        B.BookAuthor,
                        B.StockTotal,
                        B.StockAvailable,
                        B.CreatedAt,
                        B.CategoryId,
                        C.CategoryName
                    FROM Books B
                    LEFT JOIN Categories C ON C.CategoryId = B.CategoryId
                    ORDER BY B.BookId DESC").ToList();
                dvgBooks.DataSource = books;
            }
        }
        private void LoadCategories()
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var categories = conn.Query<CategoryDto>(@"
                        Select CategoryId, CategoryName from Categories order by CategoryName").ToList();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = -1;

            }


        }
        private void SearchBooks(string keyword)
        {
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                var books = conn.Query<BookDto>(@"
                    SELECT 
                        B.BookId, B.BookTitle, B.BookAuthor,
                        B.StockTotal, B.StockAvailable, B.CreatedAt,
                       
                        B.CategoryId,
                        C.CategoryName
                    FROM Books B
                    LEFT JOIN Categories C ON C.CategoryId = B.CategoryId
                    WHERE (@K IS NULL OR @K = '')
                       OR B.BookTitle LIKE '%' + @K + '%'
                       OR B.BookAuthor LIKE '%' + @K + '%'
                       OR C.CategoryName LIKE '%' + @K + '%'
                    ORDER BY B.BookId DESC",
                    new { K = keyword }).ToList();

                dvgBooks.DataSource = books;
            }
        }
        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadBooks();
        }

        private void dvgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // başlığa tıklamayı engeller

            BookDto selected = dvgBooks.Rows[e.RowIndex].DataBoundItem as BookDto;
            if (selected == null) return;

            txtId.Text = selected.BookId.ToString();
            txtTitle.Text = selected.BookTitle;
            txtAuthor.Text = selected.BookAuthor;
            cmbCategory.SelectedValue = selected.CategoryId;
            nudStockTotal.Value = selected.StockTotal;
            nudStockAvailable.Value = selected.StockAvailable;
        }

        private void dvgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            BookDto selected = dvgBooks.Rows[e.RowIndex].DataBoundItem as BookDto;
            if (selected == null) return;

            txtId.Text = selected.BookId.ToString();
            txtTitle.Text = selected.BookTitle;
            txtAuthor.Text = selected.BookAuthor;
            cmbCategory.SelectedValue = selected.CategoryId;
            nudStockTotal.Value = selected.StockTotal;
            nudStockAvailable.Value = selected.StockAvailable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            SearchBooks(keyword);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Kitap adı boş olamaz");
                return;
            }
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                conn.Execute(@"
                    INSERT INTO Books
                        (BookTitle, BookAuthor, CategoryId, StockTotal, StockAvailable, CreatedAt)
                        VALUES
                        (@BookTitle, @BookAuthor, @CategoryId, @StockTotal, @StockAvailable, GETDATE())",
                    new
                    {
                        BookTitle = txtTitle.Text.Trim(),
                        BookAuthor = txtAuthor.Text.Trim(),
                        
                        CategoryId = cmbCategory.SelectedValue == null ? (int?)null : Convert.ToInt32(cmbCategory.SelectedValue),
                        StockTotal = (int)nudStockTotal.Value,
                        StockAvailable = (int)nudStockAvailable.Value
                    });
            }
            LoadBooks();
            MessageBox.Show("Kitap Eklendi");
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Kitap adı boş kalamaz");
                return;
            }
            using(IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                conn.Execute(@"
                     UPDATE Books
                     SET
                            BookTitle = @BookTitle,
                            BookAuthor = @BookAuthor,
                            CategoryId = @CategoryId,
                            StockTotal = @StockTotal,
                            StockAvailable = @StockAvailable
                     WHERE BookId = @BookId",
                    new
                    {
                        BookId = int.Parse(txtId.Text),
                        BookTitle = txtTitle.Text.Trim(),
                        BookAuthor = txtAuthor.Text.Trim(),
                        CategoryId = cmbCategory.SelectedValue == null ? (int?)null : Convert.ToInt32(cmbCategory.SelectedValue),
                        
                        StockTotal =(int)nudStockTotal.Value,
                        StockAvailable = (int)nudStockAvailable.Value
                    });
            }
            LoadBooks() ;
            MessageBox.Show("Kitap Güncellendi.");


            
                    






                  

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Silmek için listeden bir kitap seç.");
                return;
            }

            var confirm = MessageBox.Show("Bu kitabı silmek istiyor musun?",
                                          "Onay", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;
            using (IDbConnection conn = DatabaseConnectionString.GetConnection())
            {
                conn.Execute("Delete from Books Where BookId = @BookId", new { BookId = id });
            }
            LoadBooks();
            MessageBox.Show("Kitap silindi.");
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
            this.Close();
        }
    }
}
