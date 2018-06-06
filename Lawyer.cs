using System;
using System.Collections.Generic;

namespace Hacker
{
    public class Lawyer
    {
        public int Health;
        public string Type;
        public Lawyer()
        {
            this.Health = 50;
            this.Type = "Lawyer";
        }
        public int Action1()
        {
            System.Console.WriteLine("#####Lawyer ATTACK1##### OBJECTION! I like turtle necks.");
            Random rand = new Random();
            int number = rand.Next(3, 7);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action2()
        {
            System.Console.WriteLine("#####Lawyer ATTACK2##### You Can't handle the truth! But damn you can handle those shakewieght workouts...");
            Random rand = new Random();
            int number = rand.Next(5, 23);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action3()
        {
            System.Console.WriteLine("#####Lawyer ATTACK3##### Pimping aint easy but it will get you 5-25years");
            Random rand = new Random();
            int number = rand.Next(12, 15);
            System.Console.WriteLine(number);
            return number;
        }
        public int Action4()
        {
            System.Console.WriteLine("#####Lawyer ATTACK4##### I was doing 55 in a FIFTY FOE");
            Random rand = new Random();
            int number = rand.Next(3, 18);
            System.Console.WriteLine(number);
            return number;
        }
    }
}