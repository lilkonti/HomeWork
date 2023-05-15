using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    namespace ConsoleApp1
    {
        public class Inhabitan
        {
            string kind;
            int iterator;
            public Inhabitan()
            {
                Console.WriteLine("Enter kind of animals: ");
                kind = Console.ReadLine();
                iterator = 0;
            }
            public void show()
            {
                Console.WriteLine(kind);
                ++iterator;
            }
        }
        public class Oceanarium
        {
            List<Inhabitan> inhabitans = new List<Inhabitan>();
            int iterator;
            int len;
            Random random = new Random();
            public Oceanarium()
            {
                iterator = 0;
                len = random.Next(1, 10);
                for (int i = 0; i < len; ++i)
                {
                    inhabitans.Add(new Inhabitan());
                }
            }
            public void show()
            {
                Console.WriteLine("in this inhabitan live " + len + " animals");
                foreach (var inhabitan in inhabitans)
                {
                    inhabitan.show();
                }
                ++iterator;
            }
        }
    }
}
