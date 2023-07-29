using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using SynthesisClassLibrary.ManagerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Presentation.Forms
{
    public partial class PremiumSubscription : Form
    {
        SubscribeManager subscribeManager;
        Customer cust;
        public PremiumSubscription(Customer customer)
        {
            InitializeComponent();

            cust = customer;
            subscribeManager = new SubscribeManager(new SubscriptionRepository());

            GetCustomerDetails();

            GetSubScribeByFirstName();
        }

        public void GetCustomerDetails()
        {
            txtPersonId.Text = cust.ID.ToString();
            txtFirstName.Text = cust.FirstName;
            txtLastName.Text = cust.LastName;
            txtEmail.Text = cust.Email;

        }

        public void SendEmailTOSubscriber()
        {
            EmailManager emailManager = new EmailManager();
            string Firstname = txtFirstName.Text;
            string Lastname = txtLastName.Text;
            string email = txtEmail.Text;
            string Payment = tbxSubFees.Text;
            string Month = cbbSubMonth.Text;
            string Payed = cbxPayed.Text;
           
            emailManager.NewSubScriber(Firstname, Lastname, email, Payment, Month, "Payed");
        }

        public void GetSubScribeByFirstName()
        {
            List<SubScription> subscribes = subscribeManager.GetAllSubsscription();
            foreach (SubScription sub in subscribes)
            {
                if (sub.FirstName == cust.FirstName)
                {
                    dgvSubscribes.DataSource = subscribeManager.GetSubsscription(cust.FirstName);
                }
               
            }
        }

        private void btnAddSubscribe_Click(object sender, EventArgs e)
        {
            try
            { 
            //int  txtPersonId.Text;
            String Firstname = txtFirstName.Text;
            String Lstname = txtLastName.Text;
            String email = txtEmail.Text;
            String paymentfees = tbxSubFees.Text;
            String Month = cbbSubMonth.Text;
            String Payed = cbxPayed.Text;
                List<SubScription> scription = subscribeManager.GetSubsscription(cust.FirstName);

            if (String.IsNullOrEmpty(paymentfees) || String.IsNullOrEmpty(Month) || String.IsNullOrEmpty(Payed))
            {
                MessageBox.Show("Please Input textboxes their Characters");
            }
            else if (cbxPayed.Checked == false)
            {
                MessageBox.Show("Pls Click the Payed checked box to pay for your Subscrition fees");
            }

            else if(scription != null)
                {
                    MessageBox.Show("Customer with firstname Already Exist");
                }

            else if (cbxPayed.Checked)
            {
                this.subscribeManager.Subscribe(Firstname, Lstname, email, paymentfees, Month, "Payed");

                  SendEmailTOSubscriber();
                MessageBox.Show("Payment has been Made Succesfully for your Premium Subscription");


            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
             }   

           catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Already Exist");

           }
        }

        private void dgvSubscribes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSubId.Text = dgvSubscribes.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvSubscribes.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvSubscribes.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvSubscribes.CurrentRow.Cells[3].Value.ToString();
            tbxSubFees.Text = dgvSubscribes.CurrentRow.Cells[4].Value.ToString();
            cbbSubMonth.Text = dgvSubscribes.CurrentRow.Cells[5].Value.ToString();
            cbxPayed.Text = dgvSubscribes.CurrentRow.Cells[6].Value.ToString();
        }
    }

}
    

