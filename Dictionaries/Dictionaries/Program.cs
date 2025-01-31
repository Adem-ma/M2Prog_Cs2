namespace Dictionary
{
    internal class Program
    {
        private Dictionary<string,  Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }


        internal void Run()
        {
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

            personeelOpNummer.Add(382942, "Jimmithy");
            personeelOpNummer.Add(789432, "Timmithy");

            string jim = personeelOpNummer[382942];
            string tim = personeelOpNummer[789432];


            //Console.WriteLine(tim);
            //Console.WriteLine(jim);
            

            foreach (KeyValuePair<int, string> it in personeelOpNummer)
            {
                Console.WriteLine(it.Key);
                Console.WriteLine(it.Value);
            }

            foreach (int key in personeelOpNummer.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in personeelOpNummer.Values)
            {
                Console.WriteLine(value);
            }


            Room start = new Room(0, 0, new string[]
            {
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
            });

            rooms.Add(start.GetRoomLocationKey(), start);
        }

        private void ShowRoom(int x, int y)
        {
            bool hasRoom = rooms.ContainsKey($"{x},{y}");

            Room room = rooms[$"{x},{y}"];
            Console.WriteLine($"You are in the room {x}, {y}");

            foreach (string r in room.lvl)
            {
                Console.WriteLine(r);
            }
        }
    }
    class Room
    {
        internal int x, y;
        internal string[] lvl;

        internal Room(int x, int y, string[] lvl)
        {
            this.x = x;
            this.y = y;
            this.lvl = lvl;
        }
        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }
    }
}
