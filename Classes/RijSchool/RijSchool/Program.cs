namespace RijSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Program program = new Program();
             program.Run();
        }

        internal void Run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            Student student1 = new Student()
            {
                naam = "John Pork",
                leeftijd = 20,
                //lesPakket = ,
                leraar = rijLeraar,
                //rijTest = 
            };

            Student student2 = new Student()
            {
                naam = "John Marston",
                leeftijd = 30,
                //lesPakket = ,
                leraar = rijLeraar,
                //rijTest = 
            };

            LesUur lesUur1 = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,
                student = student1,

                tijd = 1130
            };

            LesUur lesUur2 = new LesUur()
            {
                auto = auto2,
                rijLeraar = rijLeraar,
                student = student2,

                tijd = 1130
            };

            Dag dag = new Dag()
            {
                lesuren = [lesUur1, lesUur2]
            };

        }

    }

}
