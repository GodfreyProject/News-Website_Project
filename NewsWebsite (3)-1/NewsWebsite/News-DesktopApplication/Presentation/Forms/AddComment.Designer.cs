
namespace News_DesktopApplication.Forms
{
    partial class AddComment
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
            this.txbPersonId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txbMesg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbbNewsID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPersonId
            // 
            this.txbPersonId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPersonId.Location = new System.Drawing.Point(145, 121);
            this.txbPersonId.Name = "txbPersonId";
            this.txbPersonId.ReadOnly = true;
            this.txbPersonId.Size = new System.Drawing.Size(419, 30);
            this.txbPersonId.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "PersonID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(626, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "Date:";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(704, 64);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(286, 30);
            this.date.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(25, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 9;
            this.label15.Text = "NewsID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(11, 342);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Message";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(145, 261);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(422, 31);
            this.cmbType.TabIndex = 3;
            // 
            // txbMesg
            // 
            this.txbMesg.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbMesg.Location = new System.Drawing.Point(95, 315);
            this.txbMesg.Multiline = true;
            this.txbMesg.Name = "txbMesg";
            this.txbMesg.Size = new System.Drawing.Size(534, 94);
            this.txbMesg.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(16, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 23);
            this.label18.TabIndex = 1;
            this.label18.Text = "NewsType:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(351, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(169, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "Add Comment";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbbNewsID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.txbFirstName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnAddReview);
            this.panel2.Controls.Add(this.txbPersonId);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.cmbType);
            this.panel2.Controls.Add(this.txbMesg);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 513);
            this.panel2.TabIndex = 2;
            // 
            // CbbNewsID
            // 
            this.CbbNewsID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbbNewsID.FormattingEnabled = true;
            this.CbbNewsID.Location = new System.Drawing.Point(145, 204);
            this.CbbNewsID.Name = "CbbNewsID";
            this.CbbNewsID.Size = new System.Drawing.Size(422, 31);
            this.CbbNewsID.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(22, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.Location = new System.Drawing.Point(154, 68);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(410, 30);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbFirstName.Location = new System.Drawing.Point(145, 162);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.ReadOnly = true;
            this.txbFirstName.Size = new System.Drawing.Size(419, 30);
            this.txbFirstName.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "FirstName:";
            // 
            // btnAddReview
            // 
            this.btnAddReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReview.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddReview.ForeColor = System.Drawing.Color.White;
            this.btnAddReview.Location = new System.Drawing.Point(84, 434);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(511, 47);
            this.btnAddReview.TabIndex = 18;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Add Comment To News-Content";
            // 
            // AddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1049, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "AddComment";
            this.Text = "AddComment";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbPersonId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txbMesg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox CbbNewsID;
        private System.Windows.Forms.Label label1;
    }
}