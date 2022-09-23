/*  
 Purpose:. Write a program lets the user guess whether the flip of a coin results in heads or tails. The program
randomly generates an integer 0 to 1, which represents head or tail. The program prompts the user
to enter a guess, and reports whether the guess is correct or incorrect.
Input: heads tails
Output: incorrect correct
 Author: Ilyas G
Date: Sept 23 2022
 */



namespace structureexc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables and menu
            Random random = new Random();
            int randomNum = 0;
            char option = ' ';
            randomNum = random.Next(0, 2);
            Console.WriteLine("Enter a guess heads(0) or tails?(1)");
            option = char.Parse(Console.ReadLine().Substring(0, 1));
            // switch structure
            switch (option)
            {
                case '0':
                    if (randomNum == 0)
                    {
                        Console.WriteLine("Correct, the coin landed on heads");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, the coin landed on tails");
                    }
                    break;
                case '1':
                    if (randomNum == 1)
                    {
                        Console.WriteLine("Correct, the coin landed on tails");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, the coin landed on heads");
                    }
                    break;
            }

        Console.ReadLine();
        }
    }
}