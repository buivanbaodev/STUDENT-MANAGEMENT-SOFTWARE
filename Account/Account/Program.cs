using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
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
            SignIn sin = new SignIn();
            while (true)
            {
             
    
            Application.Run(new SignIn());
                if (SignIn.flAdmin)
                {
                    admin a = new admin();
                    Application.Run(a);
                }
                else
                {
                    ChangeInFo ci = new ChangeInFo();
                    if (SignIn.flChangeInfo)
                    {

                    }
                }

                if (SignIn.flSignUp)
                {
                    SignUp su = new SignUp();
                    Application.Run(su);
                }
            }
        }
    }
}
