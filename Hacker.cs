using System;
using System.Collections.Generic;

namespace Hacker
// Im here this is live share
{
    public class HackerMan
    {
        public int Health = 50;
        public string Type = "Hacker";
        // public void Hackerman()
        // {
        //     this.Health = 50;
        //     this.Type = "Hacker";
        // }
        public int Action1()
        {

            Random rand = new Random();
            int number = rand.Next(3, 7);
            System.Console.WriteLine("Well... technically under the hood Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action2()
        {

            Random rand = new Random();
            int number = rand.Next(2, 19);
            System.Console.WriteLine(".Drink() my GAMER GEARrrrrrrrrrr WATER mmmmm Pulsing with gamer energy Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action3()
        {

            Random rand = new Random();
            int number = rand.Next(9, 14);
            System.Console.WriteLine("Last night was a crazy lit lan party I'm still covered in Cheeto dust Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action4()
        {

            Random rand = new Random();
            int number = rand.Next(1, 50);
            System.Console.WriteLine("rm -rf Desktop *dont try this at home kids... Attack Dealt --->  {0}  <--- Damage", number);
            return number;
        }
        public int Action5()
        {

            Random rand = new Random();
            int number = rand.Next(50, 500);
            System.Console.WriteLine("Drank some Mountain Dew Brahhhhh so feeling good like Nina Simone  --->  {0}  <--- Reverse Damage", number);
            return number;

        }

    }

}
