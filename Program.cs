using System;

namespace FutureSkill
{

    //dude i just need to create functions to contain all method but why i don't do it i think im just 2 lazy bruh
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

            //lesson3 convert
            double value_double = 9998.365;
            int value_convert;
            value_convert = (int)value_double;
            Console.WriteLine("cast {0}", value_convert);
            Console.WriteLine("cast to string {0}", value_double.ToString());
            Console.ReadKey();

            //lesson4 loop foreach loop
            int i = 0;
            while (i < 15)
            {
                Console.WriteLine("i");
                i++;
            }

            //do while loop
            int n;
            Console.WriteLine("Enter 0 to end loop");
            do
            {
                Console.WriteLine("Enter your Number");
                int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("Your Number {0}", n);
            } while (n != 0);
            Console.WriteLine("This is done");

            //for loop
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine("Loop {0}", x);
            }

            //array and for each loop
            string[] models = { "Vios", "toyota", "honda", "fino" };
            foreach (string b in models)
            {
                Console.WriteLine("Models is {0}", b);
            }

            //break loop
            for (int z = 0; z <= 10; z++)
            {
                Console.WriteLine("Loop {0}", z);
                if (z == 5) break;

            }

            //continue
            for (int u = 0; u <= 10; u++)
            {

                if (u % 2 == 0) continue;
                Console.WriteLine("Loop {0}", u);

            }

            //lesson 5 if then else
            int a = 30;
            if (a < 20)
            {
                Console.WriteLine("A is lower than 20");
            }
            else
            {
                Console.WriteLine("A is more than 20");
            }
            Console.WriteLine("A is {0}", a);
            Console.ReadKey();
        }




    }
}




