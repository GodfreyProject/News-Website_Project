//using News_ClassLibrary.CustomerInterface;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace News_DesktopApplication.Forms
{
    public partial class CustomerProfile : Form
    {
        PersonManager personManager;
        EmailManager emailManager;
        Customer c;
        public CustomerProfile(Customer customer)
        {
            InitializeComponent();

            c = customer;
            //Control = customerControl;
            personManager = new PersonManager(new PersonRePository());
            this.emailManager = new EmailManager();
            CustomerDetails();
        }
        public void UpdateSendEmail()
        {
            string Firstname = txtFirstName.Text;
            string Lastname = txtLastName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string Zipcode = txtZipcode.Text;
            bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
            emailManager.UpdateAcountInfo(Firstname, Lastname, username, email,  Zipcode, c.ID);
        }
        public void CustomerDetails()
        {
            txtPersonId.Text = c.ID.ToString();
            txtFirstName.Text = c.FirstName;
            txtLastName.Text = c.LastName;
            txtUsername.Text = c.Username;
            txtEmail.Text = c.Email;
            txtPassword.Text = c.Password;
            txtZipcode.Text = c.Zipcode;
           // txtUserRole.Text = c.UserRole;
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int PersonId = Convert.ToInt32(txtPersonId.Text);
                string Firstname  = txtFirstName.Text;
                string Lastname = txtLastName.Text;
                string Username =  txtUsername.Text;
                string Email = txtEmail.Text;
                string Password = txtPassword.Text;
                string Zipcode = txtZipcode.Text;
                string Role = txtUserRole.Text;
                bool isEmail = Regex.IsMatch(Email, @"[a-z]*@gmail.com$");

                if (String.IsNullOrEmpty(PersonId.ToString()))
                {
                    MessageBox.Show("Enter Person ID");
                }
                if (!Regex.IsMatch(Firstname, @"^[A-Z][a-z]+$"))
                {
                    throw new FormatException("Invalid first name; please captilize only the first letter");
                }

                if (!Regex.IsMatch(Lastname, @"^[a-z \.A-Z]*[A-Z][a-z]+$"))
                {
                    throw new FormatException("Invalid last name; please captilize only the first letter");
                }
                if (!Regex.IsMatch(Username, @"^[^ ]{4,12}$"))
                {
                    throw new FormatException("UserName failed, make it's atleast 4 charecters long max:12.");
                }

                if (!Regex.IsMatch(Email, @"[a-z]*@gmail.com$"))
                {
                    throw new FormatException("Invalid Email Format Supplied");
                }
                //if (!Regex.IsMatch(Password, @"^(?=.*\d)([\w]{6,40})$"))
                //{
                //    throw new FormatException("Please include at least 1 number and 6 letter in your password");
                //}

                if (!Regex.IsMatch(Zipcode, @"^[0-9]{4}[A-Z]{2}$"))
                {
                    throw new FormatException("Invalid postal code, Include Four numbers and Capitalize 2 charaters(letters)");
                }
               
                if (this.personManager.UpdatePersons(PersonId, Firstname, Lastname, Username, Email,  Zipcode))
                {
                    MessageBox.Show("New Customer's Account has been Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateSendEmail();
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong!", "Infromation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        //private void label8_Click(object sender, EventArgs e)
        //{
        //    Login login = new Login();

        //    login.Show();
        //}
    }
}
