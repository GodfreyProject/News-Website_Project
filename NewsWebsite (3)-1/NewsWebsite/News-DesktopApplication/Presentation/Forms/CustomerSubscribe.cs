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
    public partial class CustomerSubscribe : Form
    {
        Customer cust;
        public CustomerSubscribe(Customer customer)
        {
            InitializeComponent();

            cust = customer;
        }

        private void btnBasicSub_Click(object sender, EventArgs e)
        {
            BasicSubscription basicSubscription = new BasicSubscription(cust);

            basicSubscription.Show();

            this.Hide();
        }

        private void btnPremiumSub_Click(object sender, EventArgs e)
        {
            PremiumSubscription premium = new PremiumSubscription(cust);

            premium.Show();

            this.Hide();
        }
    }
}
