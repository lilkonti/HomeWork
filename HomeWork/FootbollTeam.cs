using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class FootbollPlayer
    {
        string position;
        string name;
        int iterator;
        public FootbollPlayer()
        {
            Console.WriteLine("Enter position of player: ");
            position = Console.ReadLine();
            Console.WriteLine("Enter name of player: ");
            name = Console.ReadLine();
            iterator = 0;
        }
        public void show()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("position " + position);
            ++iterator;
        }
    }
    class FootbollTeam
    {
        List<FootbollPlayer> footbol_players = new List<FootbollPlayer>();
        int iterator;
        int len = 11;
        public FootbollTeam()
        {
            iterator = 0;
            for (int i = 0; i < len; ++i)
            {
                footbol_players.Add(new FootbollPlayer());
            }
        }
        public void show()
        {
            Console.WriteLine("in this fotboll team " + len + " players");
            foreach (var footboll_player in footbol_players)
            {
                footboll_player.show();
            }
            ++iterator;
        }
    }
}
