using News_ClassLibrary.Business.Logic.Model;
using News_ClassLibrary.Business.ManagerClasses;
using News_ClassLibrary.Persistence;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace News_DesktopApplication.Presentation.Forms
{
    public partial class BasicSubscription : Form
    {
        private Customer c;

        private SubscribeManager subscribeManager;
        public BasicSubscription(Customer customer)
        {
            InitializeComponent();

            c = customer;

            subscribeManager = new SubscribeManager(new SubscriptionRepository());

            GetCustomerDetails();

            GetSubScribeByFirstName();
        }


        public void GetCustomerDetails()
        {
            txtPersonId.Text = c.ID.ToString();
            txtFirstName.Text = c.FirstName;
            txtLastName.Text = c.LastName;
            txtEmail.Text = c.Email;

        }

        public void GetSubScribeByFirstName()
        {
            List<SubScription> subscribes = subscribeManager.GetAllSubsscription();
            foreach(SubScription sub in subscribes)
            {
                if(sub.FirstName == c.FirstName)
                {
                    dgvSubscribes.DataSource = subscribeManager.GetSubsscription(c.FirstName);
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

                if(String.IsNullOrEmpty(paymentfees)|| String.IsNullOrEmpty(Month) || String.IsNullOrEmpty(Payed))
                {
                    MessageBox.Show("Please Input textboxes their Characters");
                }
               else if(cbxPayed.Checked == false)
                {
                    MessageBox.Show("Pls Click the Payed checked box to pay for your Subscrition fees");
                }

                else if (cbxPayed.Checked)
                {
                    this.subscribeManager.Subscribe(Firstname, Lstname, email, paymentfees, Month, "Payed");

                    MessageBox.Show("Payment has been Made Succesfully for your Basic Subscription");
                    GetSubScribeByFirstName();

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

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                int SubID = Convert.ToInt32(tbxSubId.Text);

                if (String.IsNullOrEmpty(SubID.ToString()))
                {
                    MessageBox.Show("Enter the Id to Unsubscribe");
                }

                else if (subscribeManager.UnSubscribe(SubID))
                {
                    MessageBox.Show("You have Successfully Unsubscribe To Basic Plan sub");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
