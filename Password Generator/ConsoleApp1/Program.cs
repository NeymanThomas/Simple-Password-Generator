/// <summary>
/// This is a very simple application written in C# to generate a random password 
/// with command line inputs.
/// </summary>

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static bool condition;
        public static int responseNumber;

        public static List<string> Responses = new List<string>() {"Not valid kid wtf >:(", "That's not gonna work boy",
        "Y I K E S", "That's kinda cringe ngl...", "What are you even trying to say?",
        "All you have to do is enter a whole number that's not negative and not too big...", "This is liquid Cringe",
        "Alright I give up, you're hopeless"};

        public static List<char> CharacterList = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
        'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
        'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '!', '@', '#', '$', '%',
        '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', ';', ':', '<', '>', '?', '0', '1', '2', '3', '4',
        '5', '6', '7', '8', '9'};

        public static void generator()
        {
            Console.WriteLine("How long do you want this bad boy? =^_^=");
            responseNumber = 0;
            int result = 0;
            string length;
            condition = true;

            while (condition)
            {
                length = Console.ReadLine();
                try
                {
                    if (responseNumber == 8)
                    {
                        Environment.Exit(0);
                    }
                    result = Convert.ToInt32(length);
                    if (result < 1 || result > 10000)
                    {
                        Console.WriteLine(Responses[responseNumber]);
                        responseNumber++;
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(Responses[responseNumber]);
                    responseNumber++;
                }
            }

            char[] newPassword = new char[result];
            Random rnd = new Random();
            int listLength = 0;

            while (listLength != result)
            {
                newPassword[listLength] = CharacterList[rnd.Next(0, CharacterList.Count)];
                listLength++;
            }

            Console.Write("New Password: ");
            for (int i = 0; i < result; i++)
            {
                Console.Write(newPassword[i]);
            }
            Console.Write("\r\nIs that good enough for you? \\^o^/ \r\n");
            length = Console.ReadLine();
            if (length.ToLower() == "no" || length.ToLower() == "nope" || length.ToLower() == "nah" || length.ToLower() == "n"
                || length.ToLower() == "naw" || length.ToLower() == "not really")
            {
                Console.WriteLine("fine... We'll do this again \\>_</");
                generator();
            }
            else
            {
                Console.WriteLine("Perfect, as usual... =^w^=");
                Console.Read();
            }
        }

        static void Main(string[] args)
        {
            generator();
        }
    }
}
