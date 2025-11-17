using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Libi()
        {
            Console.WriteLine("enter your grade");
            int grade = int.Parse(Console.ReadLine());
            if (grade > 100 || grade < 0)
                Console.WriteLine("Error");
            else if (grade >= 90)
                Console.WriteLine("Excellent");
            else if (grade >= 80)
                Console.WriteLine("Very good");
            else if (grade >= 60)
            {
                Console.WriteLine("Passed");
                if (grade <= 70)
                    Console.WriteLine("You should work harder");
            }
            else
                Console.WriteLine("Failed"); 

        }

        static void Libi2()
        {
            Console.WriteLine("enter a num");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) {
                Console.WriteLine("Positiv");
                if (num % 2 == 0)
                    Console.WriteLine("even");
                else 
                    Console.WriteLine("odd");
             }
            else if (num < 0)
                Console.WriteLine("Negative");
            else 
                Console.WriteLine("Zero");

        }


        static void Libi3()
        {
            double total_money;
            Console.WriteLine("enter the amount of the kwh you want");
            int usage = int.Parse(Console.ReadLine());
            Console.WriteLine("you a Business?");
            bool isBusiness=bool.Parse(Console.ReadLine());
            if (usage <= 300)
                total_money = (usage * 0.5);
            else if (usage <= 600)
                total_money = (usage * 0.7);
            else
                total_money = (usage * 1);

            if (isBusiness == true)
                total_money = total_money + total_money * 15 / 100;
            else
                total_money = total_money + total_money * 5 / 100;
            Console.WriteLine("the bill came out:" + total_money);

        }
                 
       

        static void Main(string[] args)
        {
            //Libi();
            //Libi2();
            Libi3();
        }
    }
}
