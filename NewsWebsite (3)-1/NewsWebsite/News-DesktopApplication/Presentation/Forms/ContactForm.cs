using ClassLibrary.Class;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Forms
{
    public partial class ContactForm : Form
    {
        ContactManager ContactManager;
        Customer c;
        public ContactForm(Customer customer)
        {
            InitializeComponent();

            //ds = new DatabaseSelector(DatabaseType.Cloud);

            this.ContactManager = new ContactManager(new ContactRePository());
            c = customer;

            UserDetails();
        }

        public void UserDetails()
        {
            ClassLibrary.Class.Contact contact = new ClassLibrary.Class.Contact();
            txtPersonID.Text = c.ID.ToString();
            txtContactName.Text = c.FirstName;
            txtContactEmail.Text = c.Email;
           
            
         
        }
        private void btnContactSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtContactMessage.Text;
                string Firstname = txtContactName.Text;
                string Email = txtContactEmail.Text;
                int PerosnID = Convert.ToInt32(txtPersonID.Text);
                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Enter message!");
                }
                else
                {
                    if (string.IsNullOrEmpty(Firstname))
                    {
                        MessageBox.Show("Enter name!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Email))
                        {
                            MessageBox.Show("Enter email!");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(PerosnID.ToString()))
                            {
                                MessageBox.Show("Enter Your ID!!");
                            }
                            else
                            {

                                ContactManager.AddNewContact(PerosnID, Firstname, Email, message);

                                MessageBox.Show("Your Contact Message Has been Created");
                                txtContactMessage.Clear();
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
