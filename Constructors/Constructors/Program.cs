namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        private void Run()
        {
            //QuizVraag quizVraag = new QuizVraag("wa 9 plu 10", "21?");
            //Quiz quiz = new Quiz(10);

            Quiz.VoegVraagToeOpIndex(0, QuizVraag);
        }
    }
}
