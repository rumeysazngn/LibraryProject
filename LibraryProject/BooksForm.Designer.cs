namespace LibraryProject
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudStockAvailable = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudStockTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlRigth = new System.Windows.Forms.Panel();
            this.dvgBooks = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockTotal)).BeginInit();
            this.pnlRigth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBooks)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLeft.Controls.Add(this.label7);
            this.pnlLeft.Controls.Add(this.btnRemove);
            this.pnlLeft.Controls.Add(this.btnUpdated);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.nudStockAvailable);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.nudStockTotal);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.cmbCategory);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.txtAuthor);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.txtTitle);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.txtId);
            this.pnlLeft.Controls.Add(this.lblId);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(255, 553);
            this.pnlLeft.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(70, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kitap Bilgileri";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Image = global::LibraryProject.Properties.Resources.icons8_remove_50;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(55, 479);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 71);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Sil";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdated
            // 
            this.btnUpdated.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdated.Image = global::LibraryProject.Properties.Resources.icons8_update_50;
            this.btnUpdated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdated.Location = new System.Drawing.Point(55, 404);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(152, 71);
            this.btnUpdated.TabIndex = 11;
            this.btnUpdated.Text = "Güncelle";
            this.btnUpdated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdated.UseVisualStyleBackColor = false;
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Image = global::LibraryProject.Properties.Resources.icons8_add_50;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(55, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 71);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(55, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listele";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudStockAvailable
            // 
            this.nudStockAvailable.Location = new System.Drawing.Point(110, 224);
            this.nudStockAvailable.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStockAvailable.Name = "nudStockAvailable";
            this.nudStockAvailable.Size = new System.Drawing.Size(120, 22);
            this.nudStockAvailable.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mevcut Stok:";
            // 
            // nudStockTotal
            // 
            this.nudStockTotal.Location = new System.Drawing.Point(110, 187);
            this.nudStockTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStockTotal.Name = "nudStockTotal";
            this.nudStockTotal.Size = new System.Drawing.Size(120, 22);
            this.nudStockTotal.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Stok:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(110, 157);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(119, 24);
            this.cmbCategory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.Silver;
            this.txtAuthor.Location = new System.Drawing.Point(109, 119);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(130, 22);
            this.txtAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Silver;
            this.txtTitle.Location = new System.Drawing.Point(109, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(130, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Silver;
            this.txtId.Location = new System.Drawing.Point(109, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 22);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(66, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // pnlRigth
            // 
            this.pnlRigth.Controls.Add(this.dvgBooks);
            this.pnlRigth.Controls.Add(this.pnlTop);
            this.pnlRigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRigth.Location = new System.Drawing.Point(255, 0);
            this.pnlRigth.Name = "pnlRigth";
            this.pnlRigth.Size = new System.Drawing.Size(727, 553);
            this.pnlRigth.TabIndex = 1;
            // 
            // dvgBooks
            // 
            this.dvgBooks.AllowUserToAddRows = false;
            this.dvgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgBooks.Location = new System.Drawing.Point(0, 157);
            this.dvgBooks.MultiSelect = false;
            this.dvgBooks.Name = "dvgBooks";
            this.dvgBooks.ReadOnly = true;
            this.dvgBooks.RowHeadersVisible = false;
            this.dvgBooks.RowHeadersWidth = 51;
            this.dvgBooks.RowTemplate.Height = 24;
            this.dvgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgBooks.Size = new System.Drawing.Size(727, 396);
            this.dvgBooks.TabIndex = 1;
            this.dvgBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBooks_CellClick);
            this.dvgBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBooks_CellContentClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMainMenu);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(727, 157);
            this.pnlTop.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainMenu.Image = global::LibraryProject.Properties.Resources.icons8_menu_50;
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(501, 42);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(174, 65);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Ana Sayfa";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(287, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kitap Listesi";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::LibraryProject.Properties.Resources.icons8_search_50;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(113, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 62);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ARA";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Location = new System.Drawing.Point(113, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kitap Adı";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlRigth);
            this.Controls.Add(this.pnlLeft);
            this.MaximizeBox = false;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Yönetimi";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockTotal)).EndInit();
            this.pnlRigth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBooks)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlRigth;
        private System.Windows.Forms.NumericUpDown nudStockAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStockTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvgBooks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMainMenu;
    }
}