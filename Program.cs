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
                ),
                new Question("10x10 is equals ?",
                new string[] { "120", "114", "100", "105" },
                3
                ),
                new Question("Capital of Austria is ?",
                new string[] { "vienna", "Paris", "Belgrade", "Bejing" },
                1
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.startQuiz();
            myQuiz.DisplayResults();
            Console.ReadKey();
        }
    }
}
