using System;
using System.Collections.Generic;

namespace Hacker
{
    // Initialize bank
    public class Bank
    {
        public int Health;
        public string Type;
        public Bank()
        {
            this.Health = 50;
            this.Type = "Bank";
        }
        // these are methods for attacking. actions determine how much damage they deal.
        public int Action1()
        {
            System.Console.WriteLine("***bank action 1*** Your broke bro");
            Random rand = new Random();
            int number = rand.Next(14, 22);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action2()
        {
            System.Console.WriteLine("***bank action 2*** Please wait 19-49 business days");
            Random rand = new Random();
            int number = rand.Next(3, 12);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action3()
        {
            System.Console.WriteLine("***bank action 3*** Our sign up bonus is a crockpot and a shotgun cuz we a red state #MAGA");
            Random rand = new Random();
            int number = rand.Next(1, 30);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action4()
        {
            System.Console.WriteLine("***bank action 4*** We saw some suspicious activity on your account");
            Random rand = new Random();
            int number = rand.Next(7, 18);
            System.Console.WriteLine(number);
            return number;
        }
    }

}