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
        static int health = 100;
        int changeWeapon = 1;
        int damage = 0;
        int heal = 0;
        static bool alive = true;
        static void Main(string[] args)
        {
            // strings
            string weaponName;

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


            string conditionName;

            if (health >= 100)
            {
                conditionName = "Stayin' Alive";
            }

            if (health <= 99)
            {
                conditionName = "Healthy";
            }

            if (health <= 75)
            {
                conditionName = "Not as Healthy";
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
                conditionName = "ded. not big soup rice";
                alive = false;
            }

            // the actual game

            Console.WriteLine("Carson Conditionals Project");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();

            ShowHUD();
            Console.WriteLine("Status: " + conditionName);
            Console.ReadKey(true);

        }
        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
        }

    }
}
