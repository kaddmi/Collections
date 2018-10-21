using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker { Name = "A. Ivanov", WorkPosition = "Pos3" };
            Worker worker2 = new Worker { Name = "P. Sidorov", WorkPosition = "Pos1" };
            Worker worker3 = new Worker { Name = "L. Petrov", WorkPosition = "Pos2" };
            Crew crew = new Crew();
            crew.Add(worker1);
            crew.Add(worker2);
            crew.Add(worker3);
            crew.Sort();
            foreach(var worker in crew)
            {
                Console.WriteLine(worker.Name + " " + worker.WorkPosition);
            }
            Console.ReadLine();

        }
    }
}
