namespace GroupWork1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int letterCount = 0;

            foreach (char c in sentence)
            {
                if (char.IsLetter(c)) // checks if character is a letter (A-Z or a-z)
                {
                    letterCount++;
                }
            }

            Console.WriteLine($"The number of letters in the sentence is: {letterCount}");
        }
    }
}
