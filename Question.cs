using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answer { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string questionText, string[] answers, int correctAnswer) 
        { 
         QuestionText = questionText;
            Answer = answers;
            CorrectAnswerIndex = correctAnswer;
        }

        public bool isCorrectAnwer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
