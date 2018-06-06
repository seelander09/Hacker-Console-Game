using System;
using System.Collections.Generic;

namespace Hacker
{
    public class School
    {
        public int Health;
        public string Type;
        public School()
        {
            this.Health = 50;
            this.Type = "School";
        }
        public int Action1()
        {

            Random rand = new Random();
            int number = rand.Next(1, 40);
            System.Console.WriteLine(number);
            System.Console.WriteLine("***School action 1*** Stay in school and do drugs, kids!!! Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action2()
        {
            Random rand = new Random();
            int number = rand.Next(9, 25);
            System.Console.WriteLine("***School action 2*** They call me the Bus Driver ask me why? Because I'll take you to school!!!... Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action3()
        {
            Random rand = new Random();
            int number = rand.Next(2, 69);
            System.Console.WriteLine("***School action 3*** Yo this school is so lit its upping my clout and street credibility like U.A.E.N.O. how we be fleek flexin on'em... Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action4()
        {

            Random rand = new Random();
            int number = rand.Next(2, 18);
            System.Console.WriteLine(number);
            System.Console.WriteLine("***School action 4*** Reading is important because every book is a childrens book if the kid can read!!! Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
    }

}