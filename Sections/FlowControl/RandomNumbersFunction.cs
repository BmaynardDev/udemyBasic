using System;

namespace udemyBasic.Sections.FlowControl
{
    public class RandomNumbersFunction
    {
        public static void RandomNumbers()
        {
            var random = new Random();

            const int passwordLength = 20;

            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
        }
    }
}