
namespace News_DesktopApplication.Forms
{
    partial class AdminDashBoard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllComments = new System.Windows.Forms.Button();
            this.btnAllPersonsInfo = new System.Windows.Forms.Button();
            this.btnShowAllNews = new System.Windows.Forms.Button();
            this.btnAddNewsContent = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.lbCustomerFirstName = new System.Windows.Forms.Label();
            this.btnViewSubscribers = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(366, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(396, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewSubscribers);
            this.groupBox2.Controls.Add(this.btnAllComments);
            this.groupBox2.Controls.Add(this.btnAllPersonsInfo);
            this.groupBox2.Controls.Add(this.btnShowAllNews);
            this.groupBox2.Controls.Add(this.btnAddNewsContent);
            this.groupBox2.Controls.Add(this.btnChangePassword);
            this.groupBox2.Controls.Add(this.btnAdminProfile);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(28, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 631);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin Section";
            // 
            // btnAllComments
            // 
            this.btnAllComments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllComments.ForeColor = System.Drawing.Color.White;
            this.btnAllComments.Location = new System.Drawing.Point(18, 457);
            this.btnAllComments.Name = "btnAllComments";
            this.btnAllComments.Size = new System.Drawing.Size(374, 76);
            this.btnAllComments.TabIndex = 6;
            this.btnAllComments.Text = "All- Customers Comments";
            this.btnAllComments.UseVisualStyleBackColor = true;
            this.btnAllComments.Click += new System.EventHandler(this.btnAllComments_Click);
            // 
            // btnAllPersonsInfo
            // 
            this.btnAllPersonsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllPersonsInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllPersonsInfo.ForeColor = System.Drawing.Color.White;
            this.btnAllPersonsInfo.Location = new System.Drawing.Point(18, 375);
            this.btnAllPersonsInfo.Name = "btnAllPersonsInfo";
            this.btnAllPersonsInfo.Size = new System.Drawing.Size(374, 76);
            this.btnAllPersonsInfo.TabIndex = 4;
            this.btnAllPersonsInfo.Text = "All- Persons Info";
            this.btnAllPersonsInfo.UseVisualStyleBackColor = true;
            this.btnAllPersonsInfo.Click += new System.EventHandler(this.btnAllPersonsInfo_Click);
            // 
            // btnShowAllNews
            // 
            this.btnShowAllNews.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllNews.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllNews.ForeColor = System.Drawing.Color.White;
            this.btnShowAllNews.Location = new System.Drawing.Point(18, 293);
            this.btnShowAllNews.Name = "btnShowAllNews";
            this.btnShowAllNews.Size = new System.Drawing.Size(374, 76);
            this.btnShowAllNews.TabIndex = 3;
            this.btnShowAllNews.Text = "Display News-Contents";
            this.btnShowAllNews.UseVisualStyleBackColor = true;
            this.btnShowAllNews.Click += new System.EventHandler(this.btnShowAllNews_Click);
            // 
            // btnAddNewsContent
            // 
            this.btnAddNewsContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewsContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewsContent.ForeColor = System.Drawing.Color.White;
            this.btnAddNewsContent.Location = new System.Drawing.Point(18, 211);
            this.btnAddNewsContent.Name = "btnAddNewsContent";
            this.btnAddNewsContent.Size = new System.Drawing.Size(374, 76);
            this.btnAddNewsContent.TabIndex = 2;
            this.btnAddNewsContent.Text = "Manage News-Contents";
            this.btnAddNewsContent.UseVisualStyleBackColor = true;
            this.btnAddNewsContent.Click += new System.EventHandler(this.btnAddNewsContent_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(18, 129);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(374, 76);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Admin Change-Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminProfile.ForeColor = System.Drawing.Color.White;
            this.btnAdminProfile.Location = new System.Drawing.Point(18, 47);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(374, 76);
            this.btnAdminProfile.TabIndex = 0;
            this.btnAdminProfile.Text = "Admin Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // lbCustomerFirstName
            // 
            this.lbCustomerFirstName.AutoSize = true;
            this.lbCustomerFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerFirstName.Location = new System.Drawing.Point(28, 23);
            this.lbCustomerFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerFirstName.Name = "lbCustomerFirstName";
            this.lbCustomerFirstName.Size = new System.Drawing.Size(64, 23);
            this.lbCustomerFirstName.TabIndex = 4;
            this.lbCustomerFirstName.Text = "label1:";
            // 
            // btnViewSubscribers
            // 
            this.btnViewSubscribers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewSubscribers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewSubscribers.ForeColor = System.Drawing.Color.White;
            this.btnViewSubscribers.Location = new System.Drawing.Point(18, 539);
            this.btnViewSubscribers.Name = "btnViewSubscribers";
            this.btnViewSubscribers.Size = new System.Drawing.Size(374, 76);
            this.btnViewSubscribers.TabIndex = 7;
            this.btnViewSubscribers.Text = "View All-Subscribers";
            this.btnViewSubscribers.UseVisualStyleBackColor = true;
            this.btnViewSubscribers.Click += new System.EventHandler(this.btnViewSubscribers_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(540, 759);
            this.Controls.Add(this.lbCustomerFirstName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCustomerFirstName;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAddNewsContent;
        private System.Windows.Forms.Button btnShowAllNews;
        private System.Windows.Forms.Button btnAllPersonsInfo;
        private System.Windows.Forms.Button btnAllComments;
        private System.Windows.Forms.Button btnViewSubscribers;
    }
}