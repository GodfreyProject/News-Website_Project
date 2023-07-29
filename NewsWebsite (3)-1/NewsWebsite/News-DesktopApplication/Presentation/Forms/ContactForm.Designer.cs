
namespace News_DesktopApplication.Forms
{
    partial class ContactForm
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
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnContactSubmit = new System.Windows.Forms.Button();
            this.txtContactMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(200, 220);
            this.txtContactEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(265, 27);
            this.txtContactEmail.TabIndex = 19;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(200, 148);
            this.txtContactName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(265, 27);
            this.txtContactName.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(137, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(89, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "FirstName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Subject:";
            // 
            // btnContactSubmit
            // 
            this.btnContactSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContactSubmit.Location = new System.Drawing.Point(477, 419);
            this.btnContactSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContactSubmit.Name = "btnContactSubmit";
            this.btnContactSubmit.Size = new System.Drawing.Size(86, 37);
            this.btnContactSubmit.TabIndex = 14;
            this.btnContactSubmit.Text = "Submit";
            this.btnContactSubmit.UseVisualStyleBackColor = true;
            this.btnContactSubmit.Click += new System.EventHandler(this.btnContactSubmit_Click);
            // 
            // txtContactMessage
            // 
            this.txtContactMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactMessage.Location = new System.Drawing.Point(87, 299);
            this.txtContactMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactMessage.Multiline = true;
            this.txtContactMessage.Name = "txtContactMessage";
            this.txtContactMessage.Size = new System.Drawing.Size(475, 111);
            this.txtContactMessage.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer Contact Information";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(200, 74);
            this.txtPersonID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.ReadOnly = true;
            this.txtPersonID.Size = new System.Drawing.Size(265, 27);
            this.txtPersonID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "CustomerID:";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(591, 571);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnContactSubmit);
            this.Controls.Add(this.txtContactMessage);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnContactSubmit;
        private System.Windows.Forms.TextBox txtContactMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label label2;
    }
}