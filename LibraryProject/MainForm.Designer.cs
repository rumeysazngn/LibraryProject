namespace LibraryProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btngecikenler = new System.Windows.Forms.Button();
            this.btnNoals = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btngecikenler);
            this.panel1.Controls.Add(this.btnNoals);
            this.panel1.Controls.Add(this.btnMembers);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 553);
            this.panel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.Image = global::LibraryProject.Properties.Resources.icons8_dashboard_100;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(64, 352);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(368, 126);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "                 DashBoard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Image = global::LibraryProject.Properties.Resources._out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(566, 363);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(233, 104);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "      Çıkış";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btngecikenler
            // 
            this.btngecikenler.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngecikenler.Image = global::LibraryProject.Properties.Resources.icons8_orange_hourglass_100;
            this.btngecikenler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngecikenler.Location = new System.Drawing.Point(524, 186);
            this.btngecikenler.Name = "btngecikenler";
            this.btngecikenler.Size = new System.Drawing.Size(372, 130);
            this.btngecikenler.TabIndex = 2;
            this.btngecikenler.Text = "              Gecikenler";
            this.btngecikenler.UseVisualStyleBackColor = true;
            this.btngecikenler.Click += new System.EventHandler(this.btngecikenler_Click);
            // 
            // btnNoals
            // 
            this.btnNoals.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNoals.Image = global::LibraryProject.Properties.Resources.icons8_load_100;
            this.btnNoals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoals.Location = new System.Drawing.Point(64, 186);
            this.btnNoals.Name = "btnNoals";
            this.btnNoals.Size = new System.Drawing.Size(368, 130);
            this.btnNoals.TabIndex = 2;
            this.btnNoals.Text = "          Ödünç";
            this.btnNoals.UseVisualStyleBackColor = true;
            this.btnNoals.Click += new System.EventHandler(this.btnNoals_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMembers.Image = global::LibraryProject.Properties.Resources.icons8_team_leadership_and_community_membership_100;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(524, 30);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(372, 126);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "           Üyeler";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::LibraryProject.Properties.Resources.icons8_books_100;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(64, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 126);
            this.button1.TabIndex = 1;
            this.button1.Text = "        Kitaplar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngecikenler;
        private System.Windows.Forms.Button btnNoals;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
    }
}