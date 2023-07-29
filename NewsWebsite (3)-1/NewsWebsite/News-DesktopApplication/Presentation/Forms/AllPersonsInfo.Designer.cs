
namespace News_DesktopApplication.Presentation.Forms
{
    partial class AllPersonsInfo
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
            this.dgvPersonsInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonsInfo
            // 
            this.dgvPersonsInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPersonsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsInfo.Location = new System.Drawing.Point(21, 94);
            this.dgvPersonsInfo.Name = "dgvPersonsInfo";
            this.dgvPersonsInfo.RowHeadersWidth = 51;
            this.dgvPersonsInfo.RowTemplate.Height = 29;
            this.dgvPersonsInfo.Size = new System.Drawing.Size(801, 277);
            this.dgvPersonsInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL Person Information";
            // 
            // AllPersonsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(870, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersonsInfo);
            this.Name = "AllPersonsInfo";
            this.Text = "AllPersonsInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonsInfo;
        private System.Windows.Forms.Label label1;
    }
}