using System;

namespace udemyBasic.Functions
{
    public class randomNumbersFunction
    {
        public static void RandomNumbers()
        {
            // var random = new Random();

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write((char)('a' + random.Next(26,26)));
            // }

            var random = new Random();
            char result;
            int randomNumber;

            do
            {
                randomNumber = random.Next(25, 26);
                result = (char)('a' + randomNumber);
                Console.WriteLine("{1} = {0}", result, randomNumber);

                if (result == '{' || randomNumber == 6)
                    break;

            } while (true);
        }
    }
}