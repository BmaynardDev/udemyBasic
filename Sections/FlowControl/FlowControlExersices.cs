using System;

namespace udemyBasic.Sections.FlowControl
{
    public class FlowControlExersices
    {
        public static void IsDevisableByThree()
        {
            var count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i / 3 != 0 && i % 3 == 0)
                    ++count;
            }
            Console.WriteLine(count);
        }
        public static void AddNumbers()
        {
            var number = 0;
            string entry;
            do
            {
                entry = Console.ReadLine();
                if (entry == "ok")
                    break;

                number += Int32.Parse(entry);
                Console.WriteLine("New total = {0}", number);
            } while (true);
        }
        public static void Factorial()
        {
            int factorial = 10;
            // int sum;
            for (int i = factorial; i == 0; i--)
            {
                Console.WriteLine("test");
            }
            Console.ReadKey();
        }
    }
}