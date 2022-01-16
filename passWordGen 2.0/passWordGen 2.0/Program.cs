using System;

namespace passWordGen_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DoubaCorp";
            Console.WriteLine("[DoubaCorp]");

            var random = new Random();

            Console.Write("[DoubaCorp]: Choose characters >");
            var charChoise = Console.ReadLine();
            Console.Clear();

            Console.Write("[DoubaCorp]: Choose PassWords length >");
            var lengthChoise = Console.ReadLine();
            Console.Clear();

            Console.Write("[DoubaCorp]: How many passWords you want? >");
            var howManyChoise = Console.ReadLine();
            int howMany = Convert.ToInt32(howManyChoise);
            Console.Clear();

            int currentHM = 0;
            while(currentHM != howMany)
            {
                var characters = charChoise;
                var passwordLength = new char[Convert.ToInt32(lengthChoise)];


                for (int i = 0; i < passwordLength.Length; i++)
                {
                    passwordLength[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(passwordLength);
                Console.Title = resultString;
                Console.WriteLine(resultString);

                currentHM++;
            }
            Console.ReadKey();
        }
    }
}
