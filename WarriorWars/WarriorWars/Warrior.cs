using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        /*The starting health of the warriors, private so it cannot be changed by the user. Followed by
          the faction of the warrior which can only be read by the program and not changed. This may
          not be the case if I decide to mess with this program later.*/

        private const int GOOD_GUY_STARTING_HEALTH = 20;
        private const int BAD_GUY_STARTING_HEALTH = 20;

        private readonly Faction FACTION;
        
        private int health;
        private string name;
        private bool isAlive;

        //Self explanatory? Asks if the warrior is alive.
        
        public bool IsAlive 
        { 
            
            get
            {
                return isAlive;
            }
                
        }

        //This lets the creation of the warrior have its weapon and armor.
        
        private Weapon weapon;
        private Armor armor;
    
        /*This creates the warrior with its name, the faction its in, and also sets it to alive.
          It creates the weapon with base values set in the Armor.cs and Faction.cs files. The
          case and break basically make it so if one is set it cannot become the other. The code
          basically stops running through for this particular section.*/
        
        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:

                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;   
                    
                    break;


                case Faction.BadGuy:

                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;

                    break;

                default:
                    break;



            }
        }

        //Obviously the attack mechanic

        public void Attack(Warrior enemy) /*ME! -THIS- IS WHERE ENEMY IS DEFINED! IGNORE THE "Warrior" PART
                                            BECAUSE THAT JUST TELLS THE CODE WHERE TO PULL AN ENEMY FROM.
                                            "enemy" IS A VARIABLE ---NAME--- THE CODE SAVES SO IT KNOWS 
                                            WHAT TO PULL FROM. YOU ARE THINKING TOO LITERALLY. YOU SEE ENEMY
                                            BUT THE CODE SEES BADGUY OR GOODGUY, AND THEN INPUTS IT.
                                            LOOK BELOW AT INT DAMAGE. PRETEND YOU HAVE A GOODGUY. IT WOULD
                                            TRANSLATE AS weapon.Damage / BadGuy.armor.ArmorPoints. POSSIBLY
                                            ACTUALLY Faction.BadGuy.armor.ArmorPoints BUT THAT ISN'T IMPORTANT
                                            RIGHT NOW. */
        {
            /*The actual Damage of the attacks. The code is created with a base of 5 for armor and 5
              for damage. Damage is calculated as 5/5, so each warrior does 1 damage per round.*/ 
            
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            //Damage takes the enemies health down by the damage amount.
            
            enemy.health = enemy.health - damage;

             
            if(enemy.health <= 0)
            {
                /*If the enemy is dead, print the messages below and then wait for the user to
                  hit a key so the console program terminates. The else keeps the rounds going
                  until isAlive evaluates to false.*/
                
                enemy.isAlive = false;
                Tools.ColorfulWriteline($"{enemy.name} is dead!", System.ConsoleColor.DarkRed);
                Tools.ColorfulWriteline($"{name} is victorious!", System.ConsoleColor.Green);
                System.Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine($"{name} attacked {enemy.name} for {damage} point of damage.");
                System.Console.WriteLine($"{name} has {health}/20 health left!\n");
                System.Console.WriteLine($"{enemy.name} has {enemy.health}/20 health left!");
                System.Console.WriteLine("\n ------------------------------ \n");

            }
        
        }
    
    
    }
}
