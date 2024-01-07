using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project30_
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Window
    {
        GameLogica game= new GameLogica(1);

        public GamePage(string userName)
        {
            InitializeComponent();
            yourNameTxt.Text = userName;
            ActivateGame();
        }
        public void ActivateGame()
        {
            num1Txt.Text = game.GetNumber1().ToString();
            num2Txt.Text = game.GetNumber2().ToString();
        }

        public void GradeChange()
        {
            if (game.GetCorrectAnswer().ToString() == resultTxt.Text)
            {
                game.SetGrade(game.GetGrade() + 10);
            }
        }

        private void continueBtn_Click(object sender, RoutedEventArgs e)
        {
            GradeChange();
            counterTxt.Text = game.GetIndex().ToString();
            Random random = new Random();
            game.SetNumber1(random.Next(1, 51));
            game.SetNumber2(random.Next(1, 51));
            if (game.GetIndex() < 10)
            {
                if (game.GetMathOpetation() == 0)
                {
                    game.SetCorrectAnswer(game.GetNumber1() + game.GetNumber2());
                    signTxt.Text = "+";
                }
                else if (game.GetNumber2() > game.GetNumber1())
                {
                    game.SetNumber2(game.GetNumber1());
                    game.SetNumber1(game.GetNumber2());

                    game.SetCorrectAnswer(game.GetNumber1() - game.GetNumber2());
                    signTxt.Text = "-";
                }
                else
                {
                    game.SetCorrectAnswer(game.GetNumber1() - game.GetNumber2());
                    signTxt.Text = "-";
                }
                ActivateGame();
                resultTxt.Text = "";
                game.SetIndex(game.GetIndex() + 1);
                game.SetMathOperation(random.Next(0, 2));
            }
            else
            {
                gradeTxt.Text = "Final Grade:";
                answerTxt.Text = game.GetGrade().ToString();
                if (game.GetGrade() == 100)
                {
                    reflectionTxt.Text = "Perfect Score!";
                }
                else if (game.GetGrade() > 79 && game.GetGrade() < 99)
                {
                    reflectionTxt.Text = "Nice!";
                }
                else if (game.GetGrade() > 59 && game.GetGrade() < 79)
                {
                    reflectionTxt.Text = "Pretty Bad";
                }
                else
                {
                    reflectionTxt.Text = "You Have Failed";
                }
                closeBtn.Visibility = Visibility.Visible;
                continueBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }   
}
