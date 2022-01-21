using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.LoginForm);
        }
    }
}
