// Josh Blad
//Assignment 2
using System;

namespace Assignment2
{
    class DiceRolls
    {
        static void Main(string[] args)
        {
            //declare and initialize the rollsTotal variable
            int rollsTotal = 0;
            //Hey there dalilah

            //get number of rolls from user
            Console.WriteLine("Welcome to the simulator!" + '\n');
            Console.Write("How many dice rolls would you like to simulate? ");
            rollsTotal = Convert.ToInt32(Console.ReadLine());

            //create an array based on number of rolls
            int[] rollsArray = new int[rollsTotal];

            Random random = new Random();

            //declare and initialize the variables for each number
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;
            int sevens = 0;
            int eights = 0;
            int nines = 0;
            int tens = 0;
            int elevens = 0;
            int twelves = 0;

            //declare and initialize the variables for each number's string of asterisks
            string twosString = "";
            string threesString = "";
            string foursString = "";
            string fivesString = "";
            string sixesString = "";
            string sevensString = "";
            string eightsString = "";
            string ninesString = "";
            string tensString = "";
            string elevensString = "";
            string twelvesString = "";

            //loop for each roll in the array
            for (int i = 0; i < rollsTotal; i++)
            {
                //two dice are set to random numbers, totalled up, and loaded into the array
                int dice1 = random.Next(1,7);
                int dice2 = random.Next(1, 7);
                int diceTotal = dice1 + dice2;
                rollsArray[i] = diceTotal;

                //number totals are incremented accordingly
                if (rollsArray[i] == 2)
                {
                   twos++;
                }
                else if (rollsArray[i] == 3)
                {
                    threes++;
                }
                else if (rollsArray[i] == 4)
                {
                    fours++;
                }
                else if (rollsArray[i] == 5)
                {
                    fives++;
                }
                else if (rollsArray[i] == 6)
                {
                    sixes++;
                }
                else if (rollsArray[i] == 7)
                {
                    sevens++;
                }
                else if (rollsArray[i] == 8)
                {
                    eights++;
                }
                else if (rollsArray[i] == 9)
                {
                    nines++;
                }
                else if (rollsArray[i] == 10)
                {
                    tens++;
                }
                else if (rollsArray[i] == 11)
                {
                    elevens++;
                }
                else if (rollsArray[i] == 12)
                {
                    twelves++;
                }
            }

            //each number total is converted to a percent of the total and multiplied by 100. An asterisk is generated in a for loop for each percent
            twos = twos * 100;
            int twosPercent = twos / rollsTotal;

            for (int i = 0; i < twosPercent; i++)
            {
                twosString = twosString + '*';
            }

            threes = threes * 100;
            int threesPercent = threes / rollsTotal;

            for (int i = 0; i < threesPercent; i++)
            {
                threesString = threesString + '*';
            }

            fours = fours * 100;
            int foursPercent = fours / rollsTotal;

            for (int i = 0; i < foursPercent; i++)
            {
                foursString = foursString + '*';
            }

            fives = fives * 100;
            int fivesPercent = fives / rollsTotal;

            for (int i = 0; i < fivesPercent; i++)
            {
                fivesString = fivesString + '*';
            }

            sixes = sixes * 100;
            int sixesPercent = sixes / rollsTotal;

            for (int i = 0; i < sixesPercent; i++)
            {
                sixesString = sixesString + '*';
            }

            sevens = sevens * 100;
            int sevensPercent = sevens / rollsTotal;

            for (int i = 0; i < sevensPercent; i++)
            {
                sevensString = sevensString + '*';
            }

            eights = eights * 100;
            int eightsPercent = eights / rollsTotal;

            for (int i = 0; i < eightsPercent; i++)
            {
                eightsString = eightsString + '*';
            }

            nines = nines * 100;
            int ninesPercent = nines / rollsTotal;

            for (int i = 0; i < ninesPercent; i++)
            {
                ninesString = ninesString + '*';
            }

            tens = tens * 100;
            int tensPercent = tens / rollsTotal;

            for (int i = 0; i < tensPercent; i++)
            {
                tensString = tensString + '*';
            }

            elevens = elevens * 100;
            int elevensPercent = elevens / rollsTotal;

            for (int i = 0; i < elevensPercent; i++)
            {
                elevensString = elevensString + '*';
            }

            twelves = twelves * 100;
            int twelvesPercent = twelves / rollsTotal;

            for (int i = 0; i < twelvesPercent; i++)
            {
                twelvesString = twelvesString + '*';
            }

            //results are sent back with * indicating 1% of results
            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollsArray.Length + "." + "\n");

            Console.WriteLine("2: " + twosString);
            Console.WriteLine("3: " + threesString);
            Console.WriteLine("4: " + foursString);
            Console.WriteLine("5: " + fivesString);
            Console.WriteLine("6: " + sixesString);
            Console.WriteLine("7: " + sevensString);
            Console.WriteLine("8: " + eightsString);
            Console.WriteLine("9: " + ninesString);
            Console.WriteLine("10: " + tensString);
            Console.WriteLine("11: " + elevensString);
            Console.WriteLine("12: " + twelvesString + "\n");

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
