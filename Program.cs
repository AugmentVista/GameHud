using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHud
{
    internal class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("                                              Gaslight Studios                            ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("////////////////////////////////////////// Get hit. //////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey(true);

            int score = 0;
            int health = 100;
            int shields = 100;
            int lives = 3;
            int kobolds = 8;
            Random rnd = new Random();
            int eightDie = rnd.Next(1, 9);
            int tweleveDie = rnd.Next(1, 12);



            // so i want the score mult to increase with the number of kobolds slain, with 8 i could go for a quad multiplier so then I'd need to increment the score mult by 1 + 1 per 2 kobolds dead? 


            if (health < 0)
            {
                lives = lives - 1;
                Console.WriteLine("You lost a life");
                health = 100;
            }


            if (lives < 0)
            {
                Console.WriteLine("YOU LOSE THE GAME");
            }

            while (shields < 0)
            {
                health = shields + health;

            }



            Console.WriteLine("You've taken the initiative, 8 Kobolds stand before you.");
            Console.WriteLine();
            Console.WriteLine("Your blade comes down hard agianst the neck of the first to approach you, it crumbles onto the ground.");
            Console.WriteLine("                                + 100 points! , 7 kobolds remain.                     ");
            Console.ReadKey(true);
            kobolds = kobolds - 1;
            score = score + 100;





            Console.WriteLine("The remaining kobolds charge you. their strikes are weak but numerous");
            Console.WriteLine();
            Console.WriteLine("They stab any claw at you dealing damage to your shields");
            Console.WriteLine();
            Console.WriteLine("                                     ALERT, ALERT, ALERT. SHIELDS DAMAGED");
            shields = shields - (kobolds * eightDie);
            Console.WriteLine("Shields:");
            Console.WriteLine(shields);
            Console.WriteLine("Health:");
            Console.WriteLine(health);
            Console.ReadKey(true);



            Console.WriteLine("The remaining kobolds charge you. their strikes are weak but numerous");
            Console.WriteLine();
            Console.WriteLine("With clever tactics they all attack you at once");
            Console.WriteLine();
            Console.WriteLine("                                     ALERT, ALERT, ALERT. SHIELDS DAMAGED");
            shields = shields - (kobolds * eightDie);

            while (shields < 0)
            {
                health = shields + health;
                Console.WriteLine("Zero Shields Remaining:");

            }

            Console.WriteLine("Health:");
            Console.WriteLine(health);
            Console.ReadKey(true);
            kobolds = kobolds - 1;
            score = score + 100;





            Console.WriteLine("  With a heavy swing of your blade you catch two kobolds by their waists, cleaving them in half");
            kobolds = kobolds - 2;
            score = score + 200;
            Console.WriteLine("Multikill!                        + 200 points! ");
            Console.WriteLine();
            Console.WriteLine("Enraged by their fallen breathen, all 5 kobolds wildly swing thier blades at you");
            shields = shields - (kobolds * eightDie);
            Console.WriteLine("                                     ALERT, ALERT, ALERT. SHIELDS DAMAGED");
            Console.WriteLine();
            Console.WriteLine("Shields:");
            Console.WriteLine(shields);
            Console.WriteLine("Health:");
            Console.WriteLine(health);
            Console.ReadKey(true);

            Console.WriteLine("As their numbers dwindle, they begin to scatter in several directions, the least fortunate of them runs right into you, it's actions rewarded with a blade through it's back. + 100 points!");
            Console.WriteLine("The remaining Kobolds escape");
            kobolds = kobolds - 1;
            score = score + 100;
            int fallenKobolds = 8 - kobolds;
            int bonusScore = fallenKobolds + (shields / 10) * 200;
            int levelScore = score + bonusScore;
            Console.WriteLine("                                                    Level 1: Burrows Complete, Score:");
            Console.WriteLine(levelScore);
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Remaining Health");
            Console.WriteLine(health);
            Console.WriteLine("Remaining shields");
            Console.WriteLine(shields);
            Console.WriteLine("Remaining Lives");
            Console.WriteLine(lives);
            Console.ReadKey(true);

            Console.WriteLine("                                                     Level 2: Chieftain's Lair");
            Console.WriteLine();
            Console.WriteLine("                                                            Shields restored ");
            shields = 100;

            Console.WriteLine("The kobold Chieftain stands towering over you, equipped with a mace the size of your person");
            Console.WriteLine("The kobold Chieftain swings his mace crashing against your chest");
            shields = shields - tweleveDie * 15;
            Console.WriteLine("                                     ALERT, ALERT, ALERT. SHIELDS DAMAGED");
            Console.WriteLine("Remaining shields");
            Console.WriteLine(shields);
            Console.WriteLine("Not yet finished, the Chieftain hurls a bolt of fire engulfing your head with momentary flames bypassing your shields");
            health = health - tweleveDie * 5;
            Console.WriteLine("Remaining health");
            Console.WriteLine(health);
            Console.ReadKey(true);



            Console.WriteLine(" Recovering from the assault, your blade finds it's way across it's neck leaving a large wound");
            Console.WriteLine();

            Console.ReadKey(true);
            int Chieftain = 80;

            Chieftain = Chieftain - tweleveDie * 6;
            Console.WriteLine("Chieftain health Remaining");
            Console.WriteLine(Chieftain);
            Console.ReadKey(true);


            Console.WriteLine("The kobold Chieftain swings his mace over your head");
            shields = shields - tweleveDie * 15;
            Console.WriteLine("                                     ALERT, ALERT, ALERT. SHIELDS DAMAGED");
            Console.WriteLine("Remaining shields");
            Console.WriteLine(shields);
            Console.WriteLine(health);
            Console.ReadKey(true);

            Console.WriteLine(" You slash at the creature for a killing blow");
            Console.WriteLine();

            Console.ReadKey(true);

            Chieftain = Chieftain - 80;
            Console.WriteLine("Chieftain health Remaining");
            Console.WriteLine(Chieftain);
            Console.ReadKey(true);

            if (Chieftain < 0) 
            {
                Console.WriteLine("YOU WIN"); 
            }
; 



























        }
    }
}
