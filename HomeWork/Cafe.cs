using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Worker
    {
        string position;
        string name;
        int iterator;
        public Worker()
        {
            Console.WriteLine("Enter position of worker: ");
            position = Console.ReadLine();
            Console.WriteLine("Enter name of worker: ");
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
    internal class Cafe
    {
        List<Worker> workers = new List<Worker>();
        int iterator;
        int len = 5;
        public Cafe()
        {
            iterator = 0;
            for (int i = 0; i < len; ++i)
            {
                workers.Add(new Worker());
            }
        }
        public void show()
        {
            Console.WriteLine("in this cafe " + len + " workers");
            foreach (var worker in workers)
            {
                worker.show();
            }
            ++iterator;
        }
    }
}
}
