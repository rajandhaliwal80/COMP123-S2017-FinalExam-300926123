using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Rajandeep Kaur Dhaliwal
/// 300926123
/// COMP123 SC002
/// Final Exam
/// </summary>
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
