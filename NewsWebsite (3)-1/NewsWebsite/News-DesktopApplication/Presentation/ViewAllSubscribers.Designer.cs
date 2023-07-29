
namespace News_DesktopApplication.Presentation
{
    partial class ViewAllSubscribers
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
            this.dgvSubscribers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubscribers
            // 
            this.dgvSubscribers.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribers.Location = new System.Drawing.Point(29, 48);
            this.dgvSubscribers.Name = "dgvSubscribers";
            this.dgvSubscribers.RowHeadersWidth = 51;
            this.dgvSubscribers.RowTemplate.Height = 29;
            this.dgvSubscribers.Size = new System.Drawing.Size(776, 242);
            this.dgvSubscribers.TabIndex = 0;
            // 
            // ViewAllSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(840, 353);
            this.Controls.Add(this.dgvSubscribers);
            this.Name = "ViewAllSubscribers";
            this.Text = "ViewAllSubscribers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscribers;
    }
}