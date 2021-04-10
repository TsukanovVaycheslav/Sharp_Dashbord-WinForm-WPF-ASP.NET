using System;
using System.Windows.Forms;

namespace Quiz_Game_in_WinForm_01
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 4; // Stack вопросов
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(

                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " question." + Environment.NewLine +
                    "Your total percetage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnam)
        {
            switch (qnam)
            {
                case 1:

                    pictureBox1.Image = Properties.Resources.sky; // Картинка

                    lblQuastion.Text = "What is color of the sky?";    // Вопрос

                    button1.Text = "Black";
                    button2.Text = "Yellow";
                    button3.Text = "Blue";
                    button4.Text = "Red";

                    correctAnswer = 3;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.titanic; // Картинка

                    lblQuastion.Text = "In what year did the Titanic sink in the Atlantic Ocean on April 15 during its maiden voyage from Southampton??"; // Вопрос

                    button1.Text = "1905 year";
                    button2.Text = "1900 year";
                    button3.Text = "1912 year";
                    button4.Text = "1010 year";

                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.company; // Картинка

                    lblQuastion.Text = "What is the name of the largest technology company in South Korea?"; // Вопрос

                    button1.Text = "LOTTE CHEMICAL";
                    button2.Text = "Wells Fargo";
                    button3.Text = "Hyundai Wia";
                    button4.Text = "Berkshire Hathaway";

                    correctAnswer = 1;

                    break;


                case 4:
                    pictureBox1.Image = Properties.Resources.state; // Картинка

                    lblQuastion.Text = "What is the capital of Portugal?"; // Вопрос

                    button1.Text = "Portuguese Republic";
                    button2.Text = "Spain";
                    button3.Text = "Madrid";
                    button4.Text = "Lisbon";

                    correctAnswer = 4;

                    break;
            }
        }
    }
}
