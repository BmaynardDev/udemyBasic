using System;

namespace udemyBasic.Sections.ArraysAndList
{
    public class ArraysSection
    {
        public static void ArrayExample()
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            //length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()

            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effects of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effects of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);


            Console.WriteLine("Effects of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);



            Console.ReadKey();
        }
    }
}