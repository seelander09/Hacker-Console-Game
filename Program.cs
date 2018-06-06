﻿using System;
using System.Collections.Generic;

namespace Hacker
{
    class Program
    {
        static void Main(string[] args)
        {
            // bank > lawyer > hospital
            // school > hacker > bank
            // hospital > athlete > school,
            // athlete Jim = new athlete();
            HackerMan hacker = new HackerMan();
            Athlete athlete = new Athlete();
            Lawyer lawyer = new Lawyer();
            Bank bank = new Bank();
            School school = new School();
            Hospital hospital = new Hospital();
            // System.Console.WriteLine(hacker.Health);
            //
            // hacker.Action1();
            // school.Action1();
            System.Console.WriteLine("Pick a target to go all hackivist on [1: Bank, 2: School, 3: Hospital]");
            string input1 = Console.ReadLine();
            if (input1 == "1")
            {

                Action_Pick(1, bank, school, hospital, hacker, athlete, lawyer);
            }
            if (input1 == "2")
            {

                Action_Pick(2, bank, school, hospital, hacker, athlete, lawyer);
            }
            if (input1 == "3")
            {
                System.Console.WriteLine("Can we hit this by typing 3????");
                Action_Pick(3, bank, school, hospital, hacker, athlete, lawyer);
            }


            System.Console.WriteLine();
            // PickActionBank();
            HitTargetBank(PickActionBank(bank), hacker, athlete, lawyer);
            bool hDeathFlag = false;
            if (hDeathFlag == false)
            {
                if (hacker.Health <= 0)
                {
                    System.Console.WriteLine("Your hacker has died");
                    hDeathFlag = true;
                }
            }
            bool aDeathFlag = false;
            if (aDeathFlag == false)
            {
                if (athlete.Health <= 0)
                {
                    System.Console.WriteLine("Your athlete has died");
                    aDeathFlag = true;
                }
            }
            bool lDeathFlag = false;
            if (lDeathFlag == false)
            {
                if (lawyer.Health <= 0)
                {
                    System.Console.WriteLine("Your lawyer has died");
                    lDeathFlag = true;
                }
            }
        }
        public static void Action_Pick(int target, Bank bank, School school, Hospital hospital, HackerMan hacker, Athlete athlete, Lawyer lawyer)
        {
            if (target == 1)
            {
                Bank tget = bank;
                System.Console.WriteLine("Please enter 1-5 to choose attack preference ----- 1 = Main Frame Hack, 2 = Call NSA, 3 = Hactivism, 4 = Logic Bomb 5 = Myster Booster");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    tget.Health -= hacker.Action1();
                }
                if (input2 == "2")
                {
                    tget.Health -= hacker.Action2();
                }
                if (input2 == "3")
                {
                    tget.Health -= hacker.Action3();
                }
                if (input2 == "4")
                {
                    tget.Health -= hacker.Action4();
                }
                if (input2 == "5")
                {
                    tget.Health += hacker.Action5();

                }
                if (input2.Length > 2)
                {
                    System.Console.WriteLine("Stop eating Scrubway and follow orders dummy");
                }
            }
            if (target == 2)
            {
                Hospital tget = hospital;
                System.Console.WriteLine("Pick an Action[1-4]");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    tget.Health -= hacker.Action1();
                }
                if (input2 == "2")
                {
                    tget.Health -= hacker.Action2();
                }
                if (input2 == "3")
                {
                    tget.Health -= hacker.Action3();
                }
                if (input2 == "4")
                {
                    tget.Health -= hacker.Action4();
                }
                // if (input2 > 4)
                // {
                //     System.Console.WriteLine("Follow orders ASS-HOLLLE-Poop head stupid face... also GET PITTED");
                // }
            }
            if (target == 3)
            {
                School tget = school;
                System.Console.WriteLine("Pick an Action[1-4]");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    tget.Health -= hacker.Action1();
                }
                if (input2 == "2")
                {
                    tget.Health -= hacker.Action2();
                }
                if (input2 == "3")
                {
                    tget.Health -= hacker.Action3();
                }
                if (input2 == "4")
                {
                    tget.Health -= hacker.Action4();
                }
                // if (input2 > 4)
                // {
                //     System.Console.WriteLine("Follow orders ASS-HOLLLE-Poop head stupid face... also GET PITTED");
                // }
            }
            // System.Console.WriteLine("Pick an Action[1-4]");
            // string input2 = Console.ReadLine();
            // if (input2 == "1")
            // {
            //     tget.Health -= hacker.Action1();
            // }
            // if (input2 == "2")
            // {
            //     tget.Health -= hacker.Action2();
            // }
            // if (input2 == "3")
            // {
            //     tget.Health -= hacker.Action3();
            // }
            // if (input2 == "4")
            // {
            //     tget.Health -= hacker.Action4();
            // }
            // if (input2 > 4)
            // {
            //     System.Console.WriteLine("Follow orders ASS-HOLLLE-Poop head stupid face... also GET PITTED");
            // }
        }
        static int PickActionBank(Bank bank)
        {
            Random rand = new Random();
            int picked = rand.Next(1, 5);
            if (picked == 1)
            {
                return bank.Action1();
            }
            if (picked == 2)
            {
                return bank.Action2();
            }
            if (picked == 3)
            {
                return bank.Action3();
            }
            if (picked == 4)
            {
                return bank.Action4();
            }
            return 0;
        }
        static void HitTargetBank(int attack, HackerMan hacker, Athlete athlete, Lawyer lawyer)
        {
            Random rand = new Random();
            int picked = rand.Next(1, 5);
            if (picked == 1)
            {
                if (hacker.Health > 0)
                {
                    hacker.Health -= attack;
                }
                else if (hacker.Health <= 0)
                {
                    HitTargetBank(attack, hacker, athlete, lawyer);
                }
            }
            if (picked == 2)
            {
                if (athlete.Health > 0)
                {
                    athlete.Health -= attack;
                }
                else if (hacker.Health <= 0)
                {
                    HitTargetBank(attack, hacker, athlete, lawyer);
                }
            }
            if (picked == 3)
            {
                if (lawyer.Health > 0)
                {
                    lawyer.Health -= attack;
                }
                else if (hacker.Health <= 0)
                {
                    HitTargetBank(attack, hacker, athlete, lawyer);
                }
            }
        }

        // static int PickActionSchool()
        // {
        //     Random rand = new Random();
        //     rand = rand.Next(1, 5);
        //     int picked = rand;
        //     if (picked == 1)
        //     {
        //         selected = School.Action1();
        //     }
        //     if (picked == 2)
        //     {
        //         selected = School.Action2();
        //     }
        //     if (picked == 3)
        //     {
        //         selected = School.Action3();
        //     }
        //     if (picked == 4)
        //     {
        //         selected = School.Action4();
        //     }
        //     return selected;
        // }
        // static int PickActionHospital()
        // {
        //     Random rand = new Random();
        //     rand = rand.Next(1, 5);
        //     int picked = rand;
        //     int selected;
        //     if (picked == 1)
        //     {
        //         selected = Hospital.Action1();
        //     }
        //     if (picked == 2)
        //     {
        //         selected = Hospital.Action2();
        //     }
        //     if (picked == 3)
        //     {
        //         selected = Hospital.Action3();
        //     }
        //     if (picked == 4)
        //     {
        //         selected = Hospital.Action4();
        //     }
        //     return selected;
        // }
    }
}
