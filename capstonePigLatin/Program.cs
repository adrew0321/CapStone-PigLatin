using System;

namespace capstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string userLine;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string constant;

            bool repeat1 = true;
            while (repeat1)
            {
                //***INPUT***
                Console.WriteLine($"Welcome to the Pig Latin Translator");
                Console.ReadLine();

                Console.Write($"Enter a line to be translated: ");
                userLine = Console.ReadLine();

                //***PROCESSING***

                for (int i = 0; i < userLine.Length; i++)
                {
                    if (userLine[i] == vowels[i])
                    {
                        Console.WriteLine(userLine + "way");
                        Console.ReadLine();
                        break;
                    }

                }












                //***OUTPUT***

                bool continueResponse = true;
                while (continueResponse)
                {
                    Console.WriteLine($"Translate another line? (y/n)");
                    string UserResponse = Console.ReadLine();

                    if (UserResponse.ToLower() == "y" || UserResponse.ToLower() == "yes")
                    {
                        repeat1 = true;
                        continueResponse = false;
                    }
                    else if (UserResponse.ToLower() == "n" || UserResponse.ToLower() == "no")
                    {
                        Console.WriteLine($"It's been a pleasure working with you. Until next time...Goodbye!");
                        repeat1 = false;
                        continueResponse = false;
                    }
                }
            }

        }

    }
}
