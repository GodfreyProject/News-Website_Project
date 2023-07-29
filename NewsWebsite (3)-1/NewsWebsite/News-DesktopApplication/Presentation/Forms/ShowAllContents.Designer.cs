
namespace News_DesktopApplication.Forms
{
    partial class ShowAllContents
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
            this.dgvContents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContents
            // 
            this.dgvContents.AllowDrop = true;
            this.dgvContents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContents.Location = new System.Drawing.Point(12, 64);
            this.dgvContents.Name = "dgvContents";
            this.dgvContents.RowHeadersWidth = 51;
            this.dgvContents.RowTemplate.Height = 29;
            this.dgvContents.Size = new System.Drawing.Size(777, 326);
            this.dgvContents.TabIndex = 2;
            this.dgvContents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContents_CellDoubleClick);
            // 
            // ShowAllContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(815, 433);
            this.Controls.Add(this.dgvContents);
            this.Name = "ShowAllContents";
            this.Text = "ShowAllContents";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvContents;
    }
}