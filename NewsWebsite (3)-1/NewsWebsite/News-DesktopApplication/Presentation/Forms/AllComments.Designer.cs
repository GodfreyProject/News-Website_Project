
namespace News_DesktopApplication.Forms
{
    partial class AllComments
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
            this.tbPersonID = new System.Windows.Forms.TextBox();
            this.tbxNewsID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxNewsType = new System.Windows.Forms.ComboBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.btnUpdateReview = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbComId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAllContants = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPersonID
            // 
            this.tbPersonID.Location = new System.Drawing.Point(132, 115);
            this.tbPersonID.Name = "tbPersonID";
            this.tbPersonID.ReadOnly = true;
            this.tbPersonID.Size = new System.Drawing.Size(218, 27);
            this.tbPersonID.TabIndex = 2;
            // 
            // tbxNewsID
            // 
            this.tbxNewsID.Location = new System.Drawing.Point(125, 246);
            this.tbxNewsID.Name = "tbxNewsID";
            this.tbxNewsID.ReadOnly = true;
            this.tbxNewsID.Size = new System.Drawing.Size(223, 27);
            this.tbxNewsID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ComID:";
            // 
            // cboxNewsType
            // 
            this.cboxNewsType.FormattingEnabled = true;
            this.cboxNewsType.Location = new System.Drawing.Point(125, 319);
            this.cboxNewsType.Name = "cboxNewsType";
            this.cboxNewsType.Size = new System.Drawing.Size(265, 28);
            this.cboxNewsType.TabIndex = 5;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(132, 178);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.ReadOnly = true;
            this.txbFirstName.Size = new System.Drawing.Size(218, 27);
            this.txbFirstName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PersonID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "FirstName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "NewsID:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(89, 391);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(605, 127);
            this.tbxMessage.TabIndex = 10;
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(533, 51);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(250, 27);
            this.dateText.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbComId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxMessage);
            this.panel1.Controls.Add(this.dateText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPersonID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxNewsID);
            this.panel1.Controls.Add(this.cboxNewsType);
            this.panel1.Controls.Add(this.txbFirstName);
            this.panel1.Location = new System.Drawing.Point(23, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 537);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "NewsType:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowAllContants);
            this.panel3.Controls.Add(this.btnDeleteReview);
            this.panel3.Controls.Add(this.btnUpdateReview);
            this.panel3.Location = new System.Drawing.Point(831, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 184);
            this.panel3.TabIndex = 14;
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Location = new System.Drawing.Point(3, 89);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(178, 41);
            this.btnDeleteReview.TabIndex = 1;
            this.btnDeleteReview.Text = "Delete Review";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // btnUpdateReview
            // 
            this.btnUpdateReview.Location = new System.Drawing.Point(3, 15);
            this.btnUpdateReview.Name = "btnUpdateReview";
            this.btnUpdateReview.Size = new System.Drawing.Size(178, 41);
            this.btnUpdateReview.TabIndex = 0;
            this.btnUpdateReview.Text = "Update Review";
            this.btnUpdateReview.UseVisualStyleBackColor = true;
            this.btnUpdateReview.Click += new System.EventHandler(this.btnUpdateReview_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Message:";
            // 
            // txbComId
            // 
            this.txbComId.Location = new System.Drawing.Point(132, 56);
            this.txbComId.Name = "txbComId";
            this.txbComId.ReadOnly = true;
            this.txbComId.Size = new System.Drawing.Size(212, 27);
            this.txbComId.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(170, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customer Management";
            // 
            // dgvComments
            // 
            this.dgvComments.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(3, 3);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 29;
            this.dgvComments.Size = new System.Drawing.Size(816, 339);
            this.dgvComments.TabIndex = 18;
            this.dgvComments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvComments);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(828, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 347);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // btnShowAllContants
            // 
            this.btnShowAllContants.Location = new System.Drawing.Point(246, 15);
            this.btnShowAllContants.Name = "btnShowAllContants";
            this.btnShowAllContants.Size = new System.Drawing.Size(178, 41);
            this.btnShowAllContants.TabIndex = 2;
            this.btnShowAllContants.Text = "Show Contents";
            this.btnShowAllContants.UseVisualStyleBackColor = true;
            this.btnShowAllContants.Click += new System.EventHandler(this.btnShowAllContants_Click);
            // 
            // AllComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1696, 624);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "AllComments";
            this.Text = "AllComments";
            this.Load += new System.EventHandler(this.AllComments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPersonID;
        private System.Windows.Forms.TextBox tbxNewsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxNewsType;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.DateTimePicker dateText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbComId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteReview;
        private System.Windows.Forms.Button btnUpdateReview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnShowAllContants;
    }
}