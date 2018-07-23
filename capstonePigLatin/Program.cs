using System;

namespace capstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string userLine;
            string vowels = "AEIOUaeiou";
            string firstLetter;
            string restOfWord;

            bool repeat1 = true;
            while (repeat1)
            {
                //***INPUT***
                Console.WriteLine($"Welcome to the Pig Latin Translator");
                Console.ReadLine();

                Console.Write($"Enter a line to be translated: ");
                userLine = Console.ReadLine();

                //***PROCESSING***

                int index = userLine.IndexOfAny(vowels.ToCharArray());
                string endOfWord = userLine.Substring(index);
                string startOfWord = userLine.Substring(0, index);

                if (index == 0)
                {
                    Console.WriteLine(endOfWord + startOfWord + "way");
                }
                else
                {
                    Console.WriteLine(endOfWord + startOfWord + "ay");
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
