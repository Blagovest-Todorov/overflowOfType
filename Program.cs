using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            byte count = 0;

            for (int i = 0; i < 260; i++)
            {
                count++;
            }

            Console.WriteLine(count);  // Overflow of the Type /

        }
    }
}
