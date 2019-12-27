using System;
using System.Collections.Generic;

namespace udemyBasic.Sections.ArraysAndList
{
    public class ArrayAndListExercise
    {
        public static void FacebookMessagerLikes()
        {
            var names = new List<string>();

            do
            {
                var newName = Console.ReadLine();
                if (newName != "")
                    names.Add(newName);
                else
                    break;
            } while (true);

            if (names.Count < 1)
                Console.WriteLine();
            else if (names.Count < 2)
                Console.WriteLine(names[0] + " likes your post");
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count > 2)
                Console.WriteLine("{0},{1} and {2} others like your post ", names[0], names[1], names.Count - 2);

            Console.ReadKey();
        }
    }
}