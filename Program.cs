namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[] 
            { 
                new Question("What is the capital of Germany",//questionText
                new string[] { "Paris", "Berlin", "London", "Madrid"},//answers
                1//correctAnswer
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.startQuiz();
            Console.ReadKey();
        }
    }
}
