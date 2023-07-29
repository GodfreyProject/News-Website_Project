
namespace News_DesktopApplication.Forms
{
    partial class CustomerDashBoard
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
            this.lbCustomerFirstName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomerProfile = new System.Windows.Forms.Button();
            this.btnSearchContents = new System.Windows.Forms.Button();
            this.btnShowAllContents = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnViewCommentAndManage = new System.Windows.Forms.Button();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCustomerFirstName
            // 
            this.lbCustomerFirstName.AutoSize = true;
            this.lbCustomerFirstName.Location = new System.Drawing.Point(26, 27);
            this.lbCustomerFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerFirstName.Name = "lbCustomerFirstName";
            this.lbCustomerFirstName.Size = new System.Drawing.Size(70, 28);
            this.lbCustomerFirstName.TabIndex = 1;
            this.lbCustomerFirstName.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(338, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 43);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomerProfile
            // 
            this.btnCustomerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerProfile.Location = new System.Drawing.Point(20, 48);
            this.btnCustomerProfile.Name = "btnCustomerProfile";
            this.btnCustomerProfile.Size = new System.Drawing.Size(412, 53);
            this.btnCustomerProfile.TabIndex = 3;
            this.btnCustomerProfile.Text = "Customer-Profile";
            this.btnCustomerProfile.UseVisualStyleBackColor = true;
            this.btnCustomerProfile.Click += new System.EventHandler(this.btnCustomerProfile_Click);
            // 
            // btnSearchContents
            // 
            this.btnSearchContents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchContents.Location = new System.Drawing.Point(29, 285);
            this.btnSearchContents.Name = "btnSearchContents";
            this.btnSearchContents.Size = new System.Drawing.Size(412, 53);
            this.btnSearchContents.TabIndex = 5;
            this.btnSearchContents.Text = "Customer Search-Contents";
            this.btnSearchContents.UseVisualStyleBackColor = true;
            this.btnSearchContents.Click += new System.EventHandler(this.btnSearchContents_Click);
            // 
            // btnShowAllContents
            // 
            this.btnShowAllContents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllContents.Location = new System.Drawing.Point(29, 213);
            this.btnShowAllContents.Name = "btnShowAllContents";
            this.btnShowAllContents.Size = new System.Drawing.Size(412, 53);
            this.btnShowAllContents.TabIndex = 6;
            this.btnShowAllContents.Text = "Customer See-allContents";
            this.btnShowAllContents.UseVisualStyleBackColor = true;
            this.btnShowAllContents.Click += new System.EventHandler(this.btnShowAllContents_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Controls.Add(this.btnSubscribe);
            this.groupBox1.Controls.Add(this.btnAddContact);
            this.groupBox1.Controls.Add(this.btnUpdatePassword);
            this.groupBox1.Controls.Add(this.btnViewCommentAndManage);
            this.groupBox1.Controls.Add(this.btnAddComment);
            this.groupBox1.Controls.Add(this.btnSearchContents);
            this.groupBox1.Controls.Add(this.btnShowAllContents);
            this.groupBox1.Controls.Add(this.btnCustomerProfile);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 689);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer-Section";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubscribe.Location = new System.Drawing.Point(29, 588);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(421, 53);
            this.btnSubscribe.TabIndex = 11;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddContact.Location = new System.Drawing.Point(29, 508);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(412, 53);
            this.btnAddContact.TabIndex = 10;
            this.btnAddContact.Text = "Add-Contacts";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePassword.Location = new System.Drawing.Point(29, 132);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(412, 53);
            this.btnUpdatePassword.TabIndex = 9;
            this.btnUpdatePassword.Text = "Change-Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnViewCommentAndManage
            // 
            this.btnViewCommentAndManage.BackColor = System.Drawing.Color.MediumPurple;
            this.btnViewCommentAndManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCommentAndManage.Location = new System.Drawing.Point(29, 431);
            this.btnViewCommentAndManage.Name = "btnViewCommentAndManage";
            this.btnViewCommentAndManage.Size = new System.Drawing.Size(412, 59);
            this.btnViewCommentAndManage.TabIndex = 8;
            this.btnViewCommentAndManage.Text = "Customer View Personal-Comments And Manage\r\n";
            this.btnViewCommentAndManage.UseVisualStyleBackColor = false;
            this.btnViewCommentAndManage.Click += new System.EventHandler(this.btnViewCommentAndManage_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddComment.Location = new System.Drawing.Point(29, 357);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(412, 53);
            this.btnAddComment.TabIndex = 7;
            this.btnAddComment.Text = "Customer Add-Comments";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(521, 775);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbCustomerFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerDashBoard";
            this.Text = "CustomerDashBoard";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCustomerFirstName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomerProfile;
        private System.Windows.Forms.Button btnSearchContents;
        private System.Windows.Forms.Button btnShowAllContents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnViewCommentAndManage;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnSubscribe;
    }
}