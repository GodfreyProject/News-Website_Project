using ClassLibrary.Class;
using News_ClassLibrary.Business.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_ClassLibrary.Persistence;
using News_DesktopApplication.Forms;
using PersonManagerTest.Business;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News_DesktopApplication
{
    public partial class CreateAccount : Form
    {
        //DatabaseSelector ds;
        PersonManager Manager;
        public CreateAccount()
        {
            InitializeComponent();

            //ds = new DatabaseSelector(DatabaseType.Cloud);

            Manager = new PersonManager(new PersonRePository());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                String Role = "Admin";
                String Password = txbPassword.Text;
                Person person = Manager.GetPersonAdminRole(Role, Password);
                //Person person = Manager.GetUserRole(Role);

               
                if (person is Admin)
                {
                    AdminSignUp adminSignUp = new AdminSignUp();

                    adminSignUp.Show();

                    txbPassword.Clear();
                }

               else if (String.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Enter Your Password");
                }
                else
                {
                    MessageBox.Show("Sorry, this Section Belong To Admin Only");
                }
            }
            catch(LoginException)
            {
                MessageBox.Show($"Credential to create Account for Admin doesnt Exist");
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            String UserRole = "Customer";

            Person person = Manager.GetUserRole(UserRole);
            //Person person = Manager.GetUserRole(UserRole);

            if (person is Customer)
            {
                //Customer customer = new Customer();
                CustomerSignUp adminSign = new CustomerSignUp();

                adminSign.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry ! this Section is for Customer Only");
            }
        }
    }
}
