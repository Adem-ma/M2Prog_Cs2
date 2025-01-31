namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

            for (int i = 0; 1 < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen.Length); i++;
            }
        }

        internal void Run()
        {
            double[] prijzen = new double[] {0.99, 5.60, 10, 10.11};
            string[] artiekelen = {"snoepjes", "ermmm","luxe broodje?", "lunchmenu"};
            Formulier[] formulieren = new Formulier[2];
        }
        Formulier formulieren[0] = new Formulier()
        {
            Feedback = "prijzig en shit",
            Sterren = 1
        };

        Formulier formulieren[1] = new Formulier()
        {
            Feedback = "prijzig en ook shit, maar ik moet een ander antwoord geven",
            Sterren = 2
        };

        
    }
}
