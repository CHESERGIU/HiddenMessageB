using System;

namespace HiddenMessageB
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedMessage = Console.ReadLine();
            string message = "";
            for (int i = 0; i < encodedMessage.Length; i++)
            {
                if (encodedMessage[i] == ' ')
                {
                    message += ' ';
                    continue;
                }

                if (i % 2 == 0)
                {
                    message += (char)(encodedMessage[i] + 1);
                }
                else
                {
                    message += (char)(encodedMessage[i] - 1);
                }
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
