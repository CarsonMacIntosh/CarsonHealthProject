using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonHealthProject
{
    class Program
    {
        static int weapon = 0;
        static int health = 999;
        static int changeWeapon = 1;
        static int damage = 0;
        static int heal = 0;
        static bool alive = true;
        static string weaponName;
        static string conditionName;
        static void Main(string[] args)
        {
            Console.WriteLine("Carson Conditionals Project");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();

            ShowHUD();
            Console.WriteLine("You enter the depths of hell, you have only a wee little baby's gun with you.");
            Console.ReadKey(true);

            int damage = 25;
            Console.Clear();
            ShowHUD();
            Console.WriteLine("This is where this project ends, I'm sorry for not being good enough for this course, I want to succeed but all of this coding stuff is way over my head.");
            Console.ReadKey(true);

        }
        static void ShowHUD()
        {

            if (weapon == 0)
            {
                weaponName = "Gun";
            }

            if (weapon == 1)
            {
                weaponName = "Bigger Gun";
            }

            if (weapon == 2)
            {
                weaponName = "Biggest Gun";
            }

            if (weapon == 3)
            {
                weaponName = "Big Sephiroth Sword";
            }

            if (weapon == 4)
            {
                weaponName = "Love-Colored Master Spark";
            }

            if (weapon == 5)
            {
                weaponName = "The Simpsons Season 4 on DVD";
            }

            if (weapon == 6)
            {
                weaponName = "Nuke";
            }

            if (health >= 100)
            {
                health = 100;
                conditionName = "Stayin' Alive";
            }

            if (health <= 99)
            {
                conditionName = "Stayin' Alive";
            }

            if (health <= 75)
            {
                conditionName = "Not so Healthy";
            }

            if (health <= 50)
            {
                conditionName = "In Pain";
            }

            if (health <= 10)
            {
                conditionName = "Dying";
            }

            if (health <= 0)
            {
                health = 0;
                conditionName = "ded. not big soup rice";
                alive = false;
            }

            Console.WriteLine("Health: " + health);
            Console.WriteLine("Weapon: " + weaponName);
            Console.WriteLine("Status: " + conditionName);
            Console.WriteLine("");
        }

    }
}
