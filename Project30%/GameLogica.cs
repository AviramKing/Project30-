using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project30_
{
    internal class GameLogica
    {
        private int number1;
        private int number2;
        private int answer;
        private int correctAnswer;
        private int index;
        private int grade;
        private int mathOperation;

        public GameLogica(int gameKind)
        {
            Random random = new Random();
            number1 = random.Next(1, 51);
            number2 = random.Next(1, 51);
            mathOperation = random.Next(0, 2);
            index = 1;
        }
        public bool CheckCorrectAnswer()
        {
            if (this.answer == this.correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetNumber1()
        {
            return number1;
        }

        public void SetNumber1(int number1)
        {
            this.number1 = number1;
        }

        public int GetNumber2()
        {
            return number2;
        }

        public void SetNumber2(int number2)
        {
            this.number2 = number2;
        }

        public int GetAnswer()
        {
            return answer;
        }

        public void SetAnswer(int answer)
        {
            this.answer = answer;
        }

        public int GetCorrectAnswer()
        {
            return correctAnswer;
        }

        public void SetCorrectAnswer(int correctAnswer)
        {
            this.correctAnswer = correctAnswer;
        }

        public int GetGrade()
        {
            return grade;
        }

        public void SetGrade(int grade)
        {
            this.grade = grade;
        }

        public int GetIndex()
        {
            return index;
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public int GetMathOpetation()
        {
            return mathOperation;
        }

        public void SetMathOperation(int mathOperation)
        {
            this.mathOperation = mathOperation;
        }

        public override string ToString()
        {
            return $"{this.number1}\n---\n{this.number2}\n---\n{this.answer}\n---\n{this.correctAnswer}";
        }
    }
}
