
namespace News_DesktopApplication.Presentation.Forms
{
    partial class ALL_CustomerComments
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
            this.dgvAllComments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllComments
            // 
            this.dgvAllComments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAllComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllComments.Location = new System.Drawing.Point(32, 95);
            this.dgvAllComments.Name = "dgvAllComments";
            this.dgvAllComments.RowHeadersWidth = 51;
            this.dgvAllComments.RowTemplate.Height = 29;
            this.dgvAllComments.Size = new System.Drawing.Size(763, 259);
            this.dgvAllComments.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL Comments By Customers";
            // 
            // ALL_CustomerComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(850, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllComments);
            this.Name = "ALL_CustomerComments";
            this.Text = "ALL_CustomerComments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllComments;
        private System.Windows.Forms.Label label1;
    }
}