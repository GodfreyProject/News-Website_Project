using News_ClassLibrary.Logic.Classes;
using News_ClassLibrary.ManagerClasses;
using News_DesktopApplication.Forms;
using News_DesktopApplication.Presentation.Forms;
using SynthesisClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News_DesktopApplication
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // DatabaseSelector ds = new DatabaseSelector();
            Customer customer = new Customer();
            Review review = new Review();
             Application.Run(new Login(review));
            //Application.Run(new AdminSignUp());
           
            //Application.Run(new CustomerSubscribe(customer));
           // Customer customer = new Customer();
            //Application.Run(new CreateAccount());
        }
    }
}
