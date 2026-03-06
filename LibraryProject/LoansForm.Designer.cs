namespace LibraryProject
{
    partial class LoansForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnReturnLoad = new System.Windows.Forms.Button();
            this.btnGiveLoan = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnSearchLoan = new System.Windows.Forms.Button();
            this.txtSearchLoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLeft.Controls.Add(this.btnReturnLoad);
            this.pnlLeft.Controls.Add(this.btnGiveLoan);
            this.pnlLeft.Controls.Add(this.dtpDueDate);
            this.pnlLeft.Controls.Add(this.dtpLoanDate);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.cmbBook);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.cmbMember);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 553);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnReturnLoad
            // 
            this.btnReturnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturnLoad.Location = new System.Drawing.Point(60, 329);
            this.btnReturnLoad.Name = "btnReturnLoad";
            this.btnReturnLoad.Size = new System.Drawing.Size(133, 32);
            this.btnReturnLoad.TabIndex = 5;
            this.btnReturnLoad.Text = "İade Al";
            this.btnReturnLoad.UseVisualStyleBackColor = true;
            this.btnReturnLoad.Click += new System.EventHandler(this.btnReturnLoad_Click);
            // 
            // btnGiveLoan
            // 
            this.btnGiveLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiveLoan.Location = new System.Drawing.Point(60, 274);
            this.btnGiveLoan.Name = "btnGiveLoan";
            this.btnGiveLoan.Size = new System.Drawing.Size(133, 32);
            this.btnGiveLoan.TabIndex = 0;
            this.btnGiveLoan.Text = "Ödünç Ver";
            this.btnGiveLoan.UseVisualStyleBackColor = true;
            this.btnGiveLoan.Click += new System.EventHandler(this.btnGiveLoan_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(110, 211);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(120, 22);
            this.dtpDueDate.TabIndex = 4;
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(110, 160);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(120, 22);
            this.dtpLoanDate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teslim Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alış Tarihi:";
            // 
            // cmbBook
            // 
            this.cmbBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(93, 116);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(137, 24);
            this.cmbBook.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap:";
            // 
            // cmbMember
            // 
            this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(93, 54);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(137, 24);
            this.cmbMember.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödünç İşlemleri";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvLoans);
            this.pnlRight.Controls.Add(this.pnlTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(250, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(732, 553);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoans.Location = new System.Drawing.Point(0, 136);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowHeadersWidth = 51;
            this.dgvLoans.RowTemplate.Height = 24;
            this.dgvLoans.Size = new System.Drawing.Size(732, 417);
            this.dgvLoans.TabIndex = 1;
            this.dgvLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellContentClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMainMenu);
            this.pnlTop.Controls.Add(this.btnSearchLoan);
            this.pnlTop.Controls.Add(this.txtSearchLoan);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(732, 136);
            this.pnlTop.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMainMenu.Image = global::LibraryProject.Properties.Resources.icons8_menu_50;
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(526, 35);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(159, 71);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Ana Sayfa";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSearchLoan
            // 
            this.btnSearchLoan.Image = global::LibraryProject.Properties.Resources.icons8_search_50;
            this.btnSearchLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchLoan.Location = new System.Drawing.Point(155, 69);
            this.btnSearchLoan.Name = "btnSearchLoan";
            this.btnSearchLoan.Size = new System.Drawing.Size(130, 61);
            this.btnSearchLoan.TabIndex = 2;
            this.btnSearchLoan.Text = "ARA";
            this.btnSearchLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchLoan.UseVisualStyleBackColor = true;
            // 
            // txtSearchLoan
            // 
            this.txtSearchLoan.Location = new System.Drawing.Point(143, 29);
            this.txtSearchLoan.Name = "txtSearchLoan";
            this.txtSearchLoan.Size = new System.Drawing.Size(183, 22);
            this.txtSearchLoan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ara (Üye/Kitap)";
            // 
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "LoansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoansForm";
            this.Load += new System.EventHandler(this.LoansForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnReturnLoad;
        private System.Windows.Forms.Button btnGiveLoan;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSearchLoan;
        private System.Windows.Forms.TextBox txtSearchLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMainMenu;
    }
}