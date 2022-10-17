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
           
       
        static void KoboldsAttack()
        {          
             shields = shields - (kobolds * eightDie);
            Console.WriteLine("they smack you   " + (kobolds * eightDie) + "  Damage");
            Console.ReadKey(true);
            Death();
            if (shields <= 0)
            {
                health += shields;
                shields = 0;
            }
            
            Console.Clear();
        }
        static void Death()
        {
            if (lives >= 0)
                Console.WriteLine("YOU LOSE THE GAME");
            Environment.Exit(1);
        }


      


        static void cheiftainAttack()
        {

            shields = shields - tweleveDie * 2;
            Console.ReadKey(true);
            Console.WriteLine("you get hit again by big boi");
            Death();
            if (shields <= 0)
            {
                health += shields;
                shields = 0;
            }
            {
                lives = lives - 1;
                health = 100;
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
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~                                                                             ~~~~~~~~~~~~~~~~~");
            Console.WriteLine("              | Health " + health + "    | Shields " + shields + "    | Score " + score + "    | Lives " + lives + "    | Level " + level + "      ");
            Console.WriteLine("~~~~~~~~~~~                                                                             ~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
            
            Console.ReadKey(true);
            Console.Clear();     }



            static void playerAttack()
            {
                if (koboldHealth > 0)
            {
                koboldHealth = koboldHealth - playerdamage;
              
        
                    level = 2;
                    Chieftain = Chieftain - playerdamage;

                    Console.WriteLine("whack for   " + playerdamage + "  Damage");
                    Console.Clear(); }

            


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







            // let's review, static void = method (a method is an enclosed system which can optionally take input and store a series of commands 
            //within one string that can be called upon at a later point rather than retyping everything 



















        }
    }
}
