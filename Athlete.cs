using System;
using System.Collections.Generic;

namespace Hacker
{
    public class Athlete
    {
        public int Health;
        public string Type;
        public Athlete()
        {
            this.Health = 50;
            this.Type = "Athlete";
        }
        public int Action1()
        {
            System.Console.WriteLine("Suck it NERD!");
            Random rand = new Random();
            int number = rand.Next(7, 14);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action2()
        {
            System.Console.WriteLine("You like swirlies?");
            Random rand = new Random();
            int number = rand.Next(15, 15);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action3()
        {
            System.Console.WriteLine("Touchdown!");
            Random rand = new Random();
            int number = rand.Next(13, 22);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action4()
        {
            System.Console.WriteLine("DO you even lift, brah?");
            Random rand = new Random();
            int number = rand.Next(12, 19);
            System.Console.WriteLine(number);
            return number;
        }
    }
}