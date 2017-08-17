using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Rajandeep Kaur Dhaliwal
/// 300926123
/// COMP123 SEC002
/// Final Exam
/// </summary>
namespace COMP123_S2017_FinalExam_300926123
{
    public class ScoreBoard
    {
        //Fields
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
                ScoreTextBox.Text = _score.ToString();
                FinalScoreTextBox.Text = _score.ToString();
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }

        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimeTextBox.Text = _time.ToString();
            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //Methods

        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {

        }

        public void UpdateTime()
        {
           Time= int.Parse(TimeTextBox.Text)-1;
            TimeTextBox.Text = Time.ToString();
        }
    }
}
