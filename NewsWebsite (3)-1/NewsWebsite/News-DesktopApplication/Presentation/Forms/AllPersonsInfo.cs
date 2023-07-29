using News_ClassLibrary.Persistence;
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
    public partial class AllPersonsInfo : Form
    {
        PersonManager personManager;
        public AllPersonsInfo()
        {
            InitializeComponent();

            personManager = new PersonManager(new PersonRePository());
            ShowAllPersonList();
        }

        public void ShowAllPersonList()
        {
            try
            {
                dgvPersonsInfo.DataSource = personManager.GetAllPeople();
                //{
                //    MessageBox.Show("All Information Displayed ");
                //}
                //else
                //{
                //    MessageBox.Show("Something went wrong ");
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR ");
            }
        }
    }
}
