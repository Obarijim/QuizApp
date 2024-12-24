using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions) 
        { 
        this.questions = questions;
        }

        public void startQuiz()
        {
            Console.WriteLine("welcome to the quiz");
            int questionNumber = 1;

            foreach (Question question in questions) 
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = getUserChoice();
                if (question.isCorrectAnwer(userChoice))
                {
                    Console.WriteLine("Correct");
                }
                else 
                {
                    Console.WriteLine($"Wrong. The correct answer was {question.Answer[question.CorrectAnswerIndex]}");
                }
            }
        }
        
        private void DisplayQuestion(Question question) 
        {
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answer.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answer[i]}");
            }

        }
        private int getUserChoice()
        {
            Console.WriteLine("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4) 
            { 
             Console.WriteLine("Invalid choice, enter a number between 1 and 4");
                input = Console.ReadLine();
            }
            return choice-1;//adjusting to user indexing array
        }
    }
}
