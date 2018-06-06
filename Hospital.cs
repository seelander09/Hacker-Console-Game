using System;
using System.Collections.Generic;

namespace Hacker
{
    public class Hospital
    {
        public int Health;
        public string Type;
        public Hospital()
        {
            this.Health = 50;
            this.Type = "Hospital";
        }
        public int Action1()
        {
            System.Console.WriteLine("***Hospital action 1*** According to hospital insurance codes, there are 9 different ways you can be injured by turtles... would you like some pre-life ruining herion addiction opiates?");
            Random rand = new Random();
            int number = rand.Next(1, 30);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action2()
        {
            System.Console.WriteLine("***Hospital action 2*** The doctor will be with you 19-49 business days");
            Random rand = new Random();
            int number = rand.Next(3, 12);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action3()
        {
            System.Console.WriteLine("***Hospital action 3*** We can fix that!");
            Random rand = new Random();
            int number = rand.Next(1, 30);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action4()
        {
            System.Console.WriteLine("***Hospital action 4*** My health insurance is cheap, but there are trade-offs. When I wanted to get a colonoscopy they sent me a chimney sweep.");
            Random rand = new Random();
            int number = rand.Next(7, 18);
            System.Console.WriteLine(number);
            return number;
        }
    }

}