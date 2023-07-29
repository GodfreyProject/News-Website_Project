﻿using News_ClassLibrary.Persistence;
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

namespace News_DesktopApplication.Presentation.Forms
{
    public partial class AdminChangePassword : Form
    {
        PersonManager personManager;
        Admin a;

        public AdminChangePassword(Admin admin)
        {
            InitializeComponent();

            a = admin;
            personManager = new PersonManager(new PersonRePository());

            ChangeDetail();
        }
        public void ChangeDetail()
        {
            txtPersonID.Text = a.ID.ToString();
            txtPassword.Text = a.Password;
        }
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int PersonID = Convert.ToInt32(txtPersonID.Text);

                String Password = txtPassword.Text;
                if (String.IsNullOrEmpty(PersonID.ToString()))
                {
                    MessageBox.Show("Pls Enter your Personal Id");
                }

                if (String.IsNullOrEmpty(Password))
                {
                    throw new FormatException("Pls Enter your Password to change");
                }

                if (!Regex.IsMatch(Password, @"^(?=.*\d)([\w]{6,40})$"))
                {
                    throw new FormatException("Please include at least 1 number and 6 letter in your password");
                }

                if (personManager.UpdatePassword(PersonID, Password))
                {
                    MessageBox.Show("Congratulations!! Your Password has been Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new FormatException("Something went Wrong");
                }
                //if (String.IsNullOrEmpty(PersonID.ToString()))
                //{
                //    MessageBox.Show("Pls Enter your Personal Id");
                //}
                //else
                //{
                //    if (String.IsNullOrEmpty(Password))
                //    {
                //        MessageBox.Show("Pls Enter your Password to change");
                //    }
                //    else
                //    {
                //        if(personManager.UpdatePassword(PersonID, Password))
                //        {
                //            MessageBox.Show("Congratulations!! Your Password has been Changed Successfully");
                //        }
                //    }
                //}
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Please include at least 1 number and 6 letter in your password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }

        }
    }
}
