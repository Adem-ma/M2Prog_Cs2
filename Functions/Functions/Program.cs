namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            //program variable ig bro idk
           program.Run();
            //we gebruiken hier de function Run, dit laat het RUNNENNNN
        }
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
        }
        internal void Vraag1()
        {
            Console.WriteLine("How long would you survive in a zombie apocalypse (project zomboid style)");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag2()
        {
            Console.WriteLine("Can I borrow 5 bucks rq please");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("What is your favorite color");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Rlly doesn't matter does it, why would I care??");
        }
        internal void Vraag4()
        {
            Console.WriteLine("Ermmm idk I forgot, how about you ask me something");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Nvm i remember now");
        }
        internal void Vraag5()
        {
            Console.WriteLine("What do you do in your freetime (aka hobbies (if you even have those))");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Your freetime should be taken away tbh");
        }
        internal void Vraag6()
        {
            Console.WriteLine("Alr thats it bye");
            string antwoord = Console.ReadLine();

            Console.WriteLine("yeyeye bye now");
        }
    }
}
