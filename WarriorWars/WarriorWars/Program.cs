using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{

     /*This rolls a random number and uses it for attack order. The warriors then attack until
       one of them dies.*/
    class Program
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Joe", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                /*I THINK the (0,10) means a random number between 1 and 10, the rest
                  should be self explanatory by reading the code*/
                
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(200);
                
            }
        } 
    }
}
