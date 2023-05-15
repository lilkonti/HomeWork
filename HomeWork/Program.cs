using HomeWork.ConsoleApp1;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");

            Random rand = new Random();
            int len;
            len = rand.Next(1, 2);

            List<Oceanarium> oceanariums = new List<Oceanarium>();

            for (int i = 0; i < len; ++i)
            {
                oceanariums.Add(new Oceanarium());
            }

            Console.WriteLine("Oceanariums: " + len);

            foreach (var oceanarium in oceanariums)
            {
                oceanarium.show();
            }
            Console.ReadLine();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("task 2");

            List<FootbollTeam> footboll_teams = new List<FootbollTeam>();

            for (int i = 0; i < len; ++i)
            {
                footboll_teams.Add(new FootbollTeam());
            }

            Console.WriteLine("Footboll team: " + len);

            foreach (var footboll_team in footboll_teams)
            {
                footboll_team.show();
            }
            Console.ReadLine();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("task 3");

            List<Cafe> cafes = new List<Cafe>();

            for (int i = 0; i < len; ++i)
            {
                cafes.Add(new Cafe());
            }

            Console.WriteLine("Cafe in town : " + len);

            foreach (var cafe in cafes)
            {
                cafe.show();
            }
            Console.ReadLine();
        }
    }
}