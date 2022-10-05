using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHud
{
    internal class Program
    {
            static int Chieftain = 80;
            static int score = 0;
            static int health = 100;
            static int shields = 100;
            static int lives = 3;
            static int kobolds = 8;
        static int koboldHealth = kobolds * 10; 
        static int level = 1; 
            static Random rnd = new Random();
            static int eightDie = rnd.Next(1, 9);
            static int tweleveDie = rnd.Next(1, 13);
            static int playerdamage = eightDie * 2;
           
            


        // when i moved the methods to the bottom I got an error I didn't know how to fix so they stay up top for now. 
        static void KoboldsAttack()
        {
             
            shields = shields - (kobolds * eightDie);
            Console.WriteLine("the kobolds charge you. their strikes are weak but numerous dealing   " + kobolds * eightDie + "  Damage");
            Console.ReadKey(true);
            if (lives < 0)
            {
                Console.WriteLine("YOU LOSE THE GAME");
                Environment.Exit(1);
            }

            if (shields < 1)
            {
                health = health + shields;
            }
            if (health < 0)
            {
                lives = lives - 1;
                Console.WriteLine("You lost a life");
            }
            Console.Clear();
        }



        static void cheiftainAttack()
        {

            shields = shields - tweleveDie * 2;
            Console.ReadKey(true);
            Console.WriteLine("The kobold Chieftain hits you with his mace");
            if (lives < 0)
            {
                Console.WriteLine("YOU LOSE THE GAME");
                Environment.Exit(1);
            }

            if (shields < 1)
            {
                health = health + shields;
            }
            if (health < 0)
            {
                lives = lives - 1;
                Console.WriteLine("You lost a life");
            Console.Clear();
            }
        }



        static void GameHud()
        {
            score = score + ((8 - kobolds) * 100);
            if (level < 2)
            {
                score = score + ((8 - kobolds) * 200);
            }
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine();
            Console.WriteLine("| Health " + health + "| Shields " + shields + "| Score " + score + "| Lives " + lives + "| Level " + level);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            
            Console.ReadKey(true);
            Console.Clear();     }



            static void playerAttack()
            {
           
                koboldHealth = koboldHealth - playerdamage;
                if (koboldHealth < 80)
            {
                koboldHealth = koboldHealth - playerdamage;
                 if   (koboldHealth < 0)
                {
                    kobolds = 0;
                    level = 2;
                    Chieftain = Chieftain - playerdamage;

                    Console.WriteLine("you swing your blade slashing your enemy dealing   " + playerdamage + "  Damage");
                    Console.WriteLine("There are none that remain");
                    Console.Clear(); }

            }


        }
        static void Main(string[] args)
        {
           

            


            
            
            Console.WriteLine("You've taken the initiative, 8 Kobolds stand before you.");
            Console.ReadKey(true);
            Console.Clear();
            while (kobolds > 0)
            {
                playerAttack();
                GameHud();
                KoboldsAttack();
                GameHud();
            }
           
           
          
            Console.WriteLine("                                                    Level 1: Burrows Complete, Score:");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Remaining Health");
            Console.WriteLine(health);
            Console.WriteLine("Remaining shields");
            Console.WriteLine(shields);
            Console.WriteLine("Remaining Lives");
            Console.WriteLine(lives);
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("                                                         WELCOME TO LEVEL 2                           ");
            health = health + 100;
            shields = 50;
            Console.WriteLine("That should be enough to survive");
            GameHud(); 
            Console.ReadKey(true);

            Console.WriteLine("                                                     Level 2: Chieftain's Lair");
            Console.WriteLine();
            

            Console.WriteLine("The kobold Chieftain stands towering over you, it strikes first.");
            while (Chieftain > 0)
            {
                playerAttack();
                GameHud();
                cheiftainAttack();
                GameHud();
            }


            if (Chieftain < 0) 
            {
                Console.WriteLine("///////////////////////////YOU WIN/////////////////////////////");
                Console.ReadKey(true);
                
            }
; 



























        }
    }
}
