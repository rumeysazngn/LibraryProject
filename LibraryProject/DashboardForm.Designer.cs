namespace LibraryProject
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOverdueBook = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartBookStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthlyLoans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTopMembers = new System.Windows.Forms.DataGridView();
            this.dgvTopBooks = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyLoans)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMainMenu.Image = global::LibraryProject.Properties.Resources.icons8_menu_50;
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(979, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(155, 76);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Text = "Ana Sayfa";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel5.Controls.Add(this.lblTotalBooks);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(65, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 87);
            this.panel5.TabIndex = 4;
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBooks.Location = new System.Drawing.Point(106, 48);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(18, 20);
            this.lblTotalBooks.TabIndex = 1;
            this.lblTotalBooks.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kitap";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.lblTotalMembers);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(370, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 87);
            this.panel4.TabIndex = 3;
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMembers.Location = new System.Drawing.Point(112, 48);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(18, 20);
            this.lblTotalMembers.TabIndex = 2;
            this.lblTotalMembers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Üye";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel6.Controls.Add(this.lblOverdueBook);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel6.Location = new System.Drawing.Point(676, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 87);
            this.panel6.TabIndex = 2;
            // 
            // lblOverdueBook
            // 
            this.lblOverdueBook.AutoSize = true;
            this.lblOverdueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOverdueBook.Location = new System.Drawing.Point(107, 48);
            this.lblOverdueBook.Name = "lblOverdueBook";
            this.lblOverdueBook.Size = new System.Drawing.Size(18, 20);
            this.lblOverdueBook.TabIndex = 3;
            this.lblOverdueBook.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Geciken Kitaplar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartBookStatus);
            this.panel2.Controls.Add(this.chartMonthlyLoans);
            this.panel2.Location = new System.Drawing.Point(2, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 304);
            this.panel2.TabIndex = 1;
            // 
            // chartBookStatus
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBookStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBookStatus.Legends.Add(legend1);
            this.chartBookStatus.Location = new System.Drawing.Point(713, 19);
            this.chartBookStatus.Name = "chartBookStatus";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsXValueIndexed = true;
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBookStatus.Series.Add(series1);
            this.chartBookStatus.Size = new System.Drawing.Size(371, 266);
            this.chartBookStatus.TabIndex = 1;
            this.chartBookStatus.Text = "chart2";
            title1.Name = "Kitapların Genel Durumu";
            this.chartBookStatus.Titles.Add(title1);
            this.chartBookStatus.Click += new System.EventHandler(this.chartBookStatus_Click);
            // 
            // chartMonthlyLoans
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMonthlyLoans.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMonthlyLoans.Legends.Add(legend2);
            this.chartMonthlyLoans.Location = new System.Drawing.Point(173, 19);
            this.chartMonthlyLoans.Name = "chartMonthlyLoans";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.CornflowerBlue;
            series2.YValuesPerPoint = 2;
            this.chartMonthlyLoans.Series.Add(series2);
            this.chartMonthlyLoans.Size = new System.Drawing.Size(371, 266);
            this.chartMonthlyLoans.TabIndex = 0;
            this.chartMonthlyLoans.Text = "chart1";
            title2.Name = "Kategorilere Göre Kitap Sayısı";
            this.chartMonthlyLoans.Titles.Add(title2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTopMembers);
            this.panel3.Controls.Add(this.dgvTopBooks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 271);
            this.panel3.TabIndex = 2;
            // 
            // dgvTopMembers
            // 
            this.dgvTopMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvTopMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopMembers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTopMembers.Location = new System.Drawing.Point(571, 0);
            this.dgvTopMembers.Name = "dgvTopMembers";
            this.dgvTopMembers.ReadOnly = true;
            this.dgvTopMembers.RowHeadersVisible = false;
            this.dgvTopMembers.RowHeadersWidth = 51;
            this.dgvTopMembers.RowTemplate.Height = 24;
            this.dgvTopMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopMembers.Size = new System.Drawing.Size(611, 271);
            this.dgvTopMembers.TabIndex = 1;
            // 
            // dgvTopBooks
            // 
            this.dgvTopBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvTopBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTopBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvTopBooks.Name = "dgvTopBooks";
            this.dgvTopBooks.ReadOnly = true;
            this.dgvTopBooks.RowHeadersVisible = false;
            this.dgvTopBooks.RowHeadersWidth = 51;
            this.dgvTopBooks.RowTemplate.Height = 24;
            this.dgvTopBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopBooks.Size = new System.Drawing.Size(571, 271);
            this.dgvTopBooks.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(171, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "En Çok Okunan 5 Kitap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(771, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "En Çok Kitap Okuyan 5 Üye";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBookStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyLoans)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblOverdueBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyLoans;
        private System.Windows.Forms.DataGridView dgvTopMembers;
        private System.Windows.Forms.DataGridView dgvTopBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMainMenu;
    }
}