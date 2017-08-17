using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Rajandeep Kaur Dhaliwal
 * Date:August 17, 2017
 * StudentID: 300926123
 * Description: Final Test COMP123 SEC002
 * Version:Final Version of Driver Class
 */

namespace COMP123_S2017_FinalExam_300926123
{
    public static class Program
    {

        // Create Reference to Forms
        public static PickHighestCardForm pickHighestCard;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate a new object of type CalculatorForm
            pickHighestCard = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
