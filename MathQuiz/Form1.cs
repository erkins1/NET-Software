using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            displayDate();
        }

        Random rando = new Random();

        int timeLeft;
        
        int addend1;
        int addend2;
        int subend1;
        int subend2;
        int multend1;
        int multend2;
        int divend1;
        int divend2;

        private SoundPlayer playJeopardy;

        //Adds the current date
        private void displayDate()
        {
            DateTime currDate = DateTime.Now;
            dateLabel.Text = currDate.ToString("dd MMMM yyyy");
        }

        public void StartTheQuiz()
        {
            //Get random numbers
            addend1 = rando.Next(51);
            addend2 = rando.Next(51);
            subend1 = rando.Next(1, 101);
            subend2 = rando.Next(1, subend1);
            multend1 = rando.Next(2, 11);
            multend2 = rando.Next(2, 11);
            divend2 = rando.Next(2, 11);
            int tempDiv = rando.Next(2, 11);
            divend1 = divend2 * tempDiv;
            
            //Put those numbers on the form
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            minusLeftLabel.Text = subend1.ToString();
            minusRightLabel.Text = subend2.ToString();
            timesLeftLabel.Text = multend1.ToString();
            timesRightLabel.Text = multend2.ToString();
            dividedLeftLabel.Text = divend1.ToString();
            dividedRightLabel.Text = divend2.ToString();


            //Starts the answers off at 0
            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;

            //Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            playJeopardy = new SoundPlayer("JeopardySong.wav");
            playJeopardy.Play();
            StartTheQuiz();
            startButton.Enabled = false;
            timeLabel.BackColor = default(Color);
        }

        //Controls the timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAns())
            {
                timer1.Stop();
                playJeopardy.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            } 
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                
                //Auto completes the answers
                sum.Value = addend1 + addend2;
                difference.Value = subend1 - subend2;
                product.Value = multend1 * multend2;
                quotient.Value = divend1 / divend2;

                startButton.Enabled = true;
            }

            if (timeLeft == 5)
            {
                timeLabel.BackColor = Color.Red;
            }
        }

        //Checks the answer
        private bool CheckTheAns()
        {
            if ((addend1 + addend2 == sum.Value) &&
                (subend1 - subend2 == difference.Value) &&
                (multend1 * multend2 == product.Value) &&
                (divend1 / divend2 == quotient.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
