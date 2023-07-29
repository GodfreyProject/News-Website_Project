
namespace News_DesktopApplication.Forms
{
    partial class ADDContents
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.btnAddContent = new System.Windows.Forms.Button();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.cbbNewsType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAllContents = new System.Windows.Forms.DataGridView();
            this.btnUpdateContent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNewsID = new System.Windows.Forms.TextBox();
            this.btnDeleteContent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NewsType:";
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(135, 252);
            this.txbTitle.Multiline = true;
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(304, 72);
            this.txbTitle.TabIndex = 1;
            // 
            // btnAddContent
            // 
            this.btnAddContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddContent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddContent.ForeColor = System.Drawing.Color.White;
            this.btnAddContent.Location = new System.Drawing.Point(958, 466);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(215, 47);
            this.btnAddContent.TabIndex = 2;
            this.btnAddContent.Text = "Add Content";
            this.btnAddContent.UseVisualStyleBackColor = true;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(126, 365);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(313, 27);
            this.txbAuthor.TabIndex = 3;
            // 
            // cbbNewsType
            // 
            this.cbbNewsType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbNewsType.FormattingEnabled = true;
            this.cbbNewsType.Items.AddRange(new object[] {
            "SPORT",
            "INTERNATIONAL-NEWS",
            "REGIONAL-NEWS",
            "WORLD",
            "POLITICS",
            "BUSINESS"});
            this.cbbNewsType.Location = new System.Drawing.Point(135, 165);
            this.cbbNewsType.Name = "cbbNewsType";
            this.cbbNewsType.Size = new System.Drawing.Size(304, 33);
            this.cbbNewsType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image:";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(754, 262);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(313, 72);
            this.txbDescription.TabIndex = 7;
            this.txbDescription.TextChanged += new System.EventHandler(this.txbDescription_TextChanged);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(754, 404);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(313, 27);
            this.dateText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add News Contents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Author:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date:";
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.picImage.Location = new System.Drawing.Point(694, 36);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(304, 142);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 16;
            this.picImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLoadImage.Location = new System.Drawing.Point(694, 184);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(304, 39);
            this.btnLoadImage.TabIndex = 17;
            this.btnLoadImage.Text = "Load Images";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAllContents);
            this.panel1.Location = new System.Drawing.Point(33, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 347);
            this.panel1.TabIndex = 18;
            // 
            // dgvAllContents
            // 
            this.dgvAllContents.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllContents.Location = new System.Drawing.Point(12, 15);
            this.dgvAllContents.Name = "dgvAllContents";
            this.dgvAllContents.RowHeadersWidth = 51;
            this.dgvAllContents.RowTemplate.Height = 29;
            this.dgvAllContents.Size = new System.Drawing.Size(844, 315);
            this.dgvAllContents.TabIndex = 0;
            this.dgvAllContents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllContents_CellContentClick);
            // 
            // btnUpdateContent
            // 
            this.btnUpdateContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateContent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateContent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateContent.Location = new System.Drawing.Point(958, 551);
            this.btnUpdateContent.Name = "btnUpdateContent";
            this.btnUpdateContent.Size = new System.Drawing.Size(215, 47);
            this.btnUpdateContent.TabIndex = 19;
            this.btnUpdateContent.Text = "Update Content";
            this.btnUpdateContent.UseVisualStyleBackColor = true;
            this.btnUpdateContent.Click += new System.EventHandler(this.btnUpdateContent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID:";
            // 
            // txbNewsID
            // 
            this.txbNewsID.Location = new System.Drawing.Point(126, 78);
            this.txbNewsID.Name = "txbNewsID";
            this.txbNewsID.ReadOnly = true;
            this.txbNewsID.Size = new System.Drawing.Size(313, 27);
            this.txbNewsID.TabIndex = 20;
            // 
            // btnDeleteContent
            // 
            this.btnDeleteContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteContent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteContent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteContent.Location = new System.Drawing.Point(958, 622);
            this.btnDeleteContent.Name = "btnDeleteContent";
            this.btnDeleteContent.Size = new System.Drawing.Size(215, 47);
            this.btnDeleteContent.TabIndex = 22;
            this.btnDeleteContent.Text = "Delete  Content";
            this.btnDeleteContent.UseVisualStyleBackColor = true;
            this.btnDeleteContent.Click += new System.EventHandler(this.btnDeleteContent_Click);
            // 
            // ADDContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1245, 825);
            this.Controls.Add(this.btnDeleteContent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbNewsID);
            this.Controls.Add(this.btnUpdateContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbNewsType);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.btnAddContent);
            this.Controls.Add(this.txbTitle);
            this.Controls.Add(this.label1);
            this.Name = "ADDContents";
            this.Text = "ADDContents";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Button btnAddContent;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.ComboBox cbbNewsType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.DateTimePicker dateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAllContents;
        private System.Windows.Forms.Button btnUpdateContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNewsID;
        private System.Windows.Forms.Button btnDeleteContent;
    }
}