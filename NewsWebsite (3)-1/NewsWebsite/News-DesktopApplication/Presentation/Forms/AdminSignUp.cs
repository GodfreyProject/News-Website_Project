using ClassLibrary.Class;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
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
    public partial class AdminSignUp : Form
    {
        // DatabaseSelector ds;
        PersonManager personManager;
     
        Customer customer = new Customer();

        Review r = new Review();
        public AdminSignUp()
        {
            InitializeComponent();

            //ds = new DatabaseSelector(DatabaseType.Cloud);

            personManager = new PersonManager(new PersonRePository());
        }
        public void SendEmail()
        {
            EmailManager emailManager = new EmailManager();
            string Firstname = txtFirstName.Text;
            string Lastname = txtLastName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string Zipcode = txtZipcode.Text;
            bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
            emailManager.NewAcountInfo(Firstname, Lastname, username, email, password, Zipcode, "Admin");
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            try
            {
                string Firstname = txtFirstName.Text;
                string Lastname = txtLastName.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string Zipcode = txtZipcode.Text;
                bool isEmail = Regex.IsMatch(email, @"[a-z]*@gmail.com$");
                
                  Person SelectedPerson = personManager.GetPerson(username, password);
                    //MessageBox.Show("Customer has been Succesfully Registered");
                    //SendEmail();
                    ////CustomerForm customerForm = new CustomerForm((Customer)ds.CustomerControl.GetPerson(username), ds.CustomerControl);
                    //Login login = new Login(r);
                    //login.Show();

                    //Close();
                    if (!Regex.IsMatch(Firstname, @"^[A-Z][a-z]+$"))
                    {
                        throw new FormatException("Invalid first name; please captilize only the first letter");
                    }

                    if (!Regex.IsMatch(Lastname, @"^[a-z \.A-Z]*[A-Z][a-z]+$"))
                    {
                        throw new FormatException("Invalid last name; please captilize only the first letter");
                    }
                    if (!Regex.IsMatch(username, @"^[^ ]{4,12}$"))
                    {
                        throw new FormatException("UserName failed, make it's atleast 4 charecters long max:12.");
                    }

                    if (!Regex.IsMatch(email, @"[a-z]*@gmail.com$"))
                    {
                        throw new FormatException("Invalid Email Format Supplied");
                    }
                    if (!Regex.IsMatch(password, @"^(?=.*\d)([\w]{6,40})$"))
                    {
                        throw new FormatException("Please include at least 1 number and 6 letter in your password");
                    }

                    if (!Regex.IsMatch(Zipcode, @"^[0-9]{4}[A-Z]{2}$"))
                    {
                        throw new FormatException("Invalid postal code, Include Four numbers and Capitalize 2 charaters(letters)");
                    }
                if (SelectedPerson != null)
                {
                    MessageBox.Show("Customer's Credentials Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    this.personManager.AddPerson(Firstname, Lastname, username, email, password, Zipcode, "Admin");//)
                    {
                        MessageBox.Show("Admin's  Account has been Successfully Created" ,"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SendEmail();
                        //CustomerForm customerForm = new CustomerForm((Customer)ds.CustomerControl.GetPerson(username), ds.CustomerControl);
                        Login login = new Login(r);
                        login.Show();
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

              
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login(r);

            login.Show();

            this.Hide();
        }

        private void btnBackToCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount account = new CreateAccount();

            //account.Show();

            //this.Hide();
        }
    }
}
