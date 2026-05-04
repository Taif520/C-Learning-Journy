using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                              /*User input and Operators*/
namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*User input*/
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("-------------------------------------------------");
            /*Operators*/
            int a = 5;
            int b = 7;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            Console.WriteLine("The sum of a and b is " + c);
            Console.WriteLine("The subtracting of a and b is " + d);
            Console.WriteLine("The multiplying a and b is " + e);
            /*anther way the do Operators*/
            Console.WriteLine("-------------------------------------------------");
            int num1 = 20;
            int num2=10;
            int num3=5;
            int num4=7;

            num1 += 2;
            num2 -= 2;
            num3 *= 2;
            num4 /= 2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine("-------------------------------------------------");
            /*Practices*/
            /*enario: A store sells a phone for $799.99 each. A customer buys 3 phones.
           Task:  
           Store the price in a double
           Store the quantity in an int
           Calculate the total
           Print: "Total: $xxxx"
           Then: Ask the user to enter the quantity instead of using a fixed number.*/
            double price = 799.99;
            //   int quantity = 3;
            Console.Write("Enter quantity: ");
            int quantity=Convert.ToInt32(Console.ReadLine());
            double total = price * quantity;
            Console.WriteLine("Total: $" + total);
            Console.WriteLine("-------------------------------------------------");
            /*Scenario: Gas station – calculate fuel price after discount.
           Ask the user for:
           Price per liter (double)
           Number of liters (double)
           Discount percentage (double – e.g., 10 means 10%)
           Calculate:
           Total price before discount
           Discount amount
           Final price after discount
           Print all three values neatly.*/
            Console.Write("Price per liter: ");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of liters: ");
            double liters = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Discount percentage: ");
            double Discount_percentage = Convert.ToDouble(Console.ReadLine());
            double total_before_discount = price1 * liters;
            double discount = total_before_discount *(Discount_percentage/100);
            double Final_price = total_before_discount - discount;
            Console.WriteLine(" price before discount: $" + total_before_discount);
            Console.WriteLine("discount amount: $" + discount);
            Console.WriteLine(" Final price: $" + Final_price);












        }
    }
}
