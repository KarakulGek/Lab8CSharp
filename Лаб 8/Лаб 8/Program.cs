namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Изменение №2
            Console.Write("Введите количество команд: ");
            int n = int.Parse(Console.ReadLine());
            Team[] teams = new Team[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Команда " + (i + 1));
                Console.Write("Введите название команды, город, количество игроков и количество очков: ");
                string a = Console.ReadLine();
                Console.Write("Введите город: ");
                string b = Console.ReadLine();
                Console.Write("Введите количество игроков: ");
                int c = int.Parse(Console.ReadLine());
                Console.Write("Введите количество очков: ");
                int d = int.Parse(Console.ReadLine());
                teams[i] = new Team(a,b,c,d);
            }
            foreach (Team t in teams)
            {
                t.Info();
            }
        }
    }

    struct Team
    {

        public string name;
        public string city;
        public int players;
        public int points;
        public Team(string n, string c, int pl, int p)
        {
            name = n;
            city = c;
            players = pl;
            points = p;
        }
        public void Info()
        {
            Console.WriteLine("Команда {0} из города {1} в составе из {2} игроков имеет {3} очков", name, city, players, points);
        }
    }
}