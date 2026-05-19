using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                       /*If statment and switch*/

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
            /*The operate that we can use with if statment is {==, >, <, >=, <=, !=, &&, ||}*/
        {
            /*simple question:
             * check if the age of user is 18 or above 18.*/
            Console.Write("Enter your age: ");
            int age=Convert.ToInt32(Console.ReadLine());

            if ( age == 18)
            {
                Console.WriteLine("Greate! you are 18");
            }
            else
            {
                Console.WriteLine("Your age is above 18");

            }

            Console.WriteLine("---------------------------------");
            /*The Question: 🎮 Video Game Level Up System
            Scenario: You are writing a simple RPG game. The player gains experience points 
            (XP) and levels up based on their score.
            Write a program that:
            Asks the player for their score (int)
            Uses if / else if / else to determine their rank based on this table:
            Score	Rank
            1000 or more	Legend
            500 – 999	Master
            100 – 499	Warrior
            1 – 99	Rookie
            0 or less	Unranked
            Prints: "Your rank is: [Rank]"*/
            Console.Write("Enter your score: ");
            int score=Convert.ToInt32(Console.ReadLine());
            string rank;
            if (score >= 1000)
            {
                rank = "Legend";
            }
            else if (score >= 500)
            {
                rank = "Master";
            }
            else if (score >= 100)
            {
                rank = "Warrior";
            }
            else if (score >= 1)
            {
                rank = "Rookie";
            }
            else
            {
                rank = "Unranked";
            }
            Console.WriteLine("Your rank is: " + rank);
            Console.WriteLine("--------------------------------------");
            /*Scenario: You're building a coffee shop ordering system. The user selects a drink by number,
             and the program displays the price and preparation time.
            Write a program that:
            Displays a menu:
            text
            --- Coffee Shop Menu ---
            1. Espresso
            2. Latte
            3. Cappuccino
            4. Americano
            5. Tea
            Asks the user to enter a number (1–5)
            Uses a switch statement to display:
            Choice	Drink	Price	Time
            1	Espresso	$2.50	2 minutes
            2	Latte	    $4.00	3 minutes
            3	Cappuccino	$4.50	3 minutes
            4	Americano	$3.00	2 minutes
            5	Tea	        $2.00	1 minute
            Prints:
            text
            You ordered: [Drink]
            Price: $[Price]
            Ready in: [Time]
            Thank you!
            If the user enters an invalid number (not 1–5), print: "Invalid choice. Please select 1-5."*/

            Console.WriteLine(" --- Coffee Shop Menu ---");
            Console.WriteLine(" 1. Espresso");
            Console.WriteLine(" 2. Latte");
            Console.WriteLine(" 3. Cappuccino");
            Console.WriteLine(" 4. Americano");
            Console.WriteLine(" 5. Tea");
            Console.WriteLine("Enter your choice (1-5): ");
            int userchoice = Convert.ToInt32(Console.ReadLine());

            int time=0;
            string Drink = "";
            double price =0;
            switch (userchoice)
            {
                case 1:
                     Drink = "Espresso";
                     price = 2.50;
                     time = 2 ;
                     break;// exits the switch statement
                case 2:
                    Drink = "Latte";
                    price = 4.00;
                    time = 3;
                    break;
                case 3:
                    Drink = "Cappuccino";
                    price = 4.50;
                    time = 3;
                    break;
                case 4:
                    Drink = "Americano";
                    price = 3.00;
                    time = 2;
                    break;
                case 5:
                    Drink = "Tea";
                    price = 2.50;
                    time = 1;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    return;//Exits the program here
            }
            Console.WriteLine("Your order: " + Drink);
            Console.WriteLine("price: $" + price);
            Console.WriteLine("Time: "+ time+  "minutes" );
            Console.WriteLine("Thank you!");

        }
    }
}
