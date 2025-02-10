using System;

namespace Part_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            //Part 1 - ask user for a min and max and generate value values within the range.
            int min, max;
            Console.WriteLine("What is the minimum value?");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the maximum value?");
            max = Convert.ToInt32(Console.ReadLine());

            //check if max is less then min and if so user need to retry
            if (max < min)
            {
                Console.WriteLine("The maximum value cannot be less then the minimum value.");
                Console.WriteLine("Please try again.");
                Console.WriteLine("What is the minimum value?");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the maximum value?");
                max = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Here are 5 random numbers between " + min + " and " + max + ":");
            
            //loop for 5 random numbers between min and max
            for (int i = 0; i < 5; i++)
            {
                int random = generator.Next(min, max + 1);
                Console.WriteLine(random);
            }

            //press enter to clear
            Console.WriteLine("Press enter to clear.");
            Console.ReadLine();
            Console.Clear();

            //part 2 - Dice roller (roll dice twice and display rolls and the sums)
            int dice1, dice2, sum;

            dice1 = generator.Next(1, 7);
            dice2 = generator.Next(1, 7);
            sum = dice1 + dice2;
            Console.WriteLine("Dice 1: " + dice1);
            Console.WriteLine("Dice 2: " + dice2);
            Console.WriteLine("Sum: " + sum);

            //press enter to clear
            Console.WriteLine("Press enter to clear.");
            Console.ReadLine();
            Console.Clear();

            //Part 3 - Random decimal numbers (same max and min from part 1)
            Console.WriteLine("The old max is " + max);
            Console.WriteLine("The old min is " + min);

            //ask user to enter how many decimals
            Console.WriteLine("How many decimals would you like?");
            int decimals = Convert.ToInt32(Console.ReadLine());

            //generate 3 random decimals numbers between min and max
            for (int i = 0; i < 3; i++)
            {
                double random = Math.Round(generator.NextDouble() * (max - min) + min, decimals);
                Console.WriteLine(random);
            }
            
            




        }
    }
}
