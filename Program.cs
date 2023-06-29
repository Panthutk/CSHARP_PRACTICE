using System;

namespace FutureSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            //lesson1
            int year = 1982;
            string name = "Aqua";
            float salary = 1603.5f;
            Console.WriteLine("his name is ;{0}", name);
            Console.WriteLine("Born in ;{0}", year);
            Console.WriteLine("his Salary ;{0}", salary);

            Console.WriteLine("Name {0},Year {1},Salary {2}", name, year, salary);

            //lesson2
            bool BreakingBad = true;
            bool NotBreakingBad = false;
            Console.WriteLine(BreakingBad);
            Console.WriteLine(NotBreakingBad);

            if (BreakingBad)
            {
                Console.WriteLine("Time to cook jessie");
            }
            else
            {
                Console.WriteLine("No more cook");
            }

        }


    }
}
