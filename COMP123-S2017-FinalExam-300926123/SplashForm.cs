using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Rajandeep Kaur Dhaliwal
 * Date:August 17, 2017
 * StudentID: 300926123
 * Description: Final Test COMP123 SEC002
 * Version:Final Version of SplashForm.cs
 */
namespace COMP123_S2017_FinalExam_300926123
{
    public partial class SplashForm : Form
    {
        // PUBLIC PROPERTIES
        public PickHighestCardForm pickHighestCard
        {

            get
            {
                return Program.pickHighestCard;
            }

        }
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the main constructor for the SplashForm
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.pickHighestCard.Show();
            this.Hide();
            SplashTimer.Enabled = false; //turn off timer
        }
    }
}
