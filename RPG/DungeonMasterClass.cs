///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          DungeonMasterClass
///   Description:    This class is in charge of calculating and displaying the game and combat
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;
using System.Threading;

/* -- public -----------------------------------------------------------------
** constructor
** DungeonMasterClass()
**
** Description:The constructor of the class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** int
** DungeonMaster(int stag, int TextNum, int NumOfchoices, int choices01, int choices02, int choices03, int choices04, int specal)
**
** Description:This function takes values from the master list and creates the user interface for the current stage of the game
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** int
** Combat(int Lv, int stag, ref int Health, ref int SpellPoints, string Name, int Strength, int Wisdom, int Intelligence, int Agility, int CriticalStrike)
**
** Description:This function is in charge of performing all the necessary calculations, and displaying to let the user fight
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** int
** CLASSQ(int Strength, int Agility, int Intelligence)
**
** Description:This function calculates the strongest of the three traits for combat
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** GG()
**
** Description:Displays the game over screen
** -------------------------------------------------------------------------*/
/* -- public -----------------------------------------------------------------
** int
** Riddle001()
**
** Description:This function is in charge of the first riddle in the game
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** ClearKeyBuffer()
**
** Description:Clears the key buffer to prevent wrong inputs
** -------------------------------------------------------------------------*/

namespace RPG
{
    class DungeonMasterClass
    {
        TextMasterClass textM = new TextMasterClass();//
        Random rnd = new Random();//

        public DungeonMasterClass()//
        {   
        }

        public int DungeonMaster(int stag, int TextNum, int NumOfchoices, int choices01, int choices02, int choices03, int choices04, int specal)//
        {
            ConsoleKeyInfo cki;
            int x = 0;

            Console.Clear();
            Thread.Sleep(500);

            Console.Write("\n" + textM.TextMaster(stag, TextNum) + "\n\n\n");//

                if (NumOfchoices >= 1)
                {
                    Console.Write("\n               \"Press 1\" " + textM.TextMaster(stag, 3) + "\n");
                }
                if (NumOfchoices >= 2)
                {
                    Console.Write("\n               \"Press 2\" " + textM.TextMaster(stag, 4) + "\n");
                }
                if (NumOfchoices >= 3)
                {
                    Console.Write("\n               \"Press 3\" " + textM.TextMaster(stag, 5) + "\n");
                }
                if (NumOfchoices >= 4)
                {
                    Console.Write("\n               \"Press 4\" " + textM.TextMaster(stag, 6) + "\n");
                }
                if (specal > 0)
                {
                    Console.Write("\n               \"Press " + (NumOfchoices + 1) + "\" " + textM.TextMaster(stag, 7) + "\n");
                }

                Console.Write("\n               \"Press 9\" Character Stats\n");
                Console.Write("\n               \"press 0\" Save & Exit\n");

                while (x != 1)//
                {
                    ClearKeyBuffer();
                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.D1 && NumOfchoices >= 1)
                    {
                        return choices01;
                    }
                    if (cki.Key == ConsoleKey.D2 && NumOfchoices >= 2)
                    {
                        return choices02;
                    }
                    if (cki.Key == ConsoleKey.D3 && NumOfchoices >= 3)
                    {
                        return choices03;
                    }
                    if (cki.Key == ConsoleKey.D4 && NumOfchoices >= 4)
                    {
                        return choices04;
                    }

                    if (specal > 0 && cki.Key == ConsoleKey.D2 && NumOfchoices == 1)
                    {
                        return specal;
                    }
                    if (specal > 0 && cki.Key == ConsoleKey.D3 && NumOfchoices == 2)
                    {
                        return specal;
                    }
                    if (specal > 0 && cki.Key == ConsoleKey.D4 && NumOfchoices == 3)
                    {
                        return specal;
                    }
                    if (specal > 0 && cki.Key == ConsoleKey.D5 && NumOfchoices == 4)
                    {
                        return specal;
                    }
 
                    if (cki.Key == ConsoleKey.D9)
                    {
                        return 998;
                    }
                    if (cki.Key == ConsoleKey.D0)
                    {
                        return 999;
                    }
                }

            return 0;//
        }

        public int Combat(int Lv, int stag, ref int Health, ref int SpellPoints, string Name, int Strength, int Wisdom, int Intelligence, int Agility, int CriticalStrike)//
        {
            
            
            int Random001 = 0,
                Random002 = 0,
                Random003 = 0,
                EnemyD,
                EnemyHP,
                Class = CLASSQ(Strength,Agility,Intelligence);

            


            Console.Clear();
            Thread.Sleep(1000);

            if(Lv == 1 )
                Random001 = rnd.Next(0, 3);

            if (Lv == 2)
                Random001 = rnd.Next(0, 4);

            if (Lv == 3)
                Random001 = rnd.Next(2, 6);

            if (Lv == 4)
                Random001 = rnd.Next(4, 8);

            if (Lv == 5)
                Random001 = rnd.Next(6, 10);

            if (Lv == 6)
                Random001 = rnd.Next(8, 12);

            if (Lv == 7)
                Random001 = rnd.Next(11, 14);

            if (Lv == 8)
                Random001 = rnd.Next(11, 14);

            if (Lv >= 9)
                Random001 = rnd.Next(11, 14);

            EnemyHP = textM.MonsterNumberMaster(Random001,1);//
            EnemyD = textM.MonsterNumberMaster(Random001, 2);

            Console.Write("\n\n          A " + textM.MonsterMaster(Random001, 0) + " attacked you!!!   ");
            Thread.Sleep(3000);

            while(EnemyHP > 0 && Health > 0)//
            {
                int x = 0,
                    z = 0;
                ConsoleKeyInfo cki;
                ConsoleKeyInfo cki2;

                Console.Clear();

                Console.Write("\n     " + textM.MonsterMaster(Random001, 0) + "   Lv" + textM.MonsterNumberMaster(Random001, 0));
                Console.Write("\n         HP" + EnemyHP + "   ");

                Console.Write("\n\n\n\n\n                    " + Name + "   Lv" + Lv);
                Console.Write("\n                        HP" + Health + "      Spell Points" + SpellPoints);

                Console.Write("\n\n                    What will you do?   ");
                Console.Write("\n\n                    \"Press 1\" Fight  \n");
                Console.Write("\n                    \"Press 2\" Run    \n");

                while (x != 1)//
                {
                    ClearKeyBuffer();
                    cki2 = Console.ReadKey(true);

                    if (cki2.Key == ConsoleKey.D1)//
                    {
                        Console.Clear();

                        Console.Write("\n     " + textM.MonsterMaster(Random001, 0) + "   Lv" + textM.MonsterNumberMaster(Random001, 0));
                        Console.Write("\n         HP" + EnemyHP + "   ");

                        Console.Write("\n\n\n\n\n                    " + Name + "   Lv" + Lv);
                        Console.Write("\n                        HP" + Health + "      Spell Points" + SpellPoints);

                        Console.Write("\n\n                    What attack will you use?   ");

                        if (Class == 1)//
                        {
                            Console.Write("\n                    \"Press 1\" Attack  " + Strength / 2 + " damage\n");
                            if(Lv >= 3)
                                Console.Write("\n                    \"Press 2\" Healing 10 SpellPoints    " + Intelligence + " hp\n");
                            if (Lv >= 5)
                                Console.Write("\n                    \"Press 3\" Uppercut  " + Strength + " damage\n");
                            if (Lv >= 10)
                                Console.Write("\n                    \"Press 4\" Heavy Attack    " + Strength * 2 + " damage\n");
                            if (Lv >= 15)
                                Console.Write("\n                    \"Press 5\" Double Attack  " + Strength * 3 + " damage\n");
                            if (Lv >= 20)
                                Console.Write("\n                    \"Press 6\" Executioner     " + Strength * 4 + " damage\n");
                        }
                        if (Class == 2)//
                        {
                            Console.Write("\n                    \"Press 1\" Assassin Attack  " + Agility / 2 + " damage\n");
                            if (Lv >= 3)
                                Console.Write("\n                    \"Press 2\" Healing 10 SpellPoints    " + Intelligence + " hp\n");
                            if (Lv >= 5)
                                Console.Write("\n                    \"Press 3\" Assassin Heavy Attack   " + Agility + " damage\n");
                            if (Lv >= 10)
                                Console.Write("\n                    \"Press 4\" Hidden Dagger    " + Agility * 2 + " damage\n");
                            if (Lv >= 15)
                                Console.Write("\n                    \"Press 5\" Sneak Attack  " + Agility * 3 + " damage\n");
                            if (Lv >= 3)
                                Console.Write("\n                    \"Press 6\" Assassinate    " + Agility * 4 + " damage\n");
                        }
                        if (Class == 3)//
                        {
                            Console.Write("\n                    \"Press 1\" Firebolt  5 SpellPoints    " + Intelligence / 2 + " damage\n");
                            if (Lv >= 3)
                                Console.Write("\n                    \"Press 2\" Healing 10 SpellPoints    " + Intelligence + " hp\n");
                            if (Lv >= 5)
                                Console.Write("\n                    \"Press 3\" Fireball 20 SpellPoints   " + Intelligence + " damage\n"); ;
                            if (Lv >= 10)
                                Console.Write("\n                    \"Press 4\" Icy Spear 40 SpellPoints    " + Intelligence * 2 + " damage\n"); ;
                            if (Lv >= 15)
                                Console.Write("\n                     \"Press 5\" Lightning Storm 80 SpellPoints  " + Intelligence * 3 + " damage\n"); ;
                            if (Lv >= 20)
                                Console.Write("\n                     \"Press 6\" Incinerate 160 SpellPoints    " + Intelligence * 4 + " damage\n"); ;
                        }
                        while (z != 1)//
                        {
                            if (Class == 1)//
                            {
                                ClearKeyBuffer();
                                cki = Console.ReadKey(true);

                                if (cki.Key == ConsoleKey.D1)
                                {
                                    Console.Write("\n               you did " + Strength / 2 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Strength / 2;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D2 && Lv >= 3 && SpellPoints > 9)
                                {
                                    Console.Write("\n               you heald your self for " + Intelligence + " hp   \n");
                                    Health += Intelligence;
                                    SpellPoints -= 10;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D3 && Lv >= 5)
                                {
                                    Console.Write("\n               you did " + Strength + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Strength;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D4 && Lv >= 10)
                                {
                                    Console.Write("\n               you did " + Strength * 2 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Strength * 2;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D5 && Lv >= 15)
                                {
                                    Console.Write("\n               you did " + Strength * 3 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Strength * 3;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D6 && Lv >= 20)
                                {
                                    Console.Write("\n               you did " + Strength * 4 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Strength * 4;
                                    x = 1;
                                    z = 1;
                                }
                            }
                            if (Class == 2)//
                            {
                                ClearKeyBuffer();
                                cki = Console.ReadKey(true);

                                if (cki.Key == ConsoleKey.D1)
                                {
                                    Console.Write("\n               you did " + Agility / 2 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Agility / 2;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D2 && Lv >= 3 && SpellPoints > 9)
                                {
                                    Console.Write("\n               you heald your self for " + Intelligence + " hp   \n");
                                    Health += Intelligence;
                                    SpellPoints -= 10;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D3 && Lv >= 5)
                                {
                                    Console.Write("\n               you did " + Agility + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Agility;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D4 && Lv >= 10)
                                {
                                    Console.Write("\n               you did " + Agility * 2 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Agility * 2;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D5 && Lv >= 15)
                                {
                                    Console.Write("\n               you did " + Agility * 3 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Agility * 3;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D6 && Lv >= 20)
                                {
                                    Console.Write("\n               you did " + Agility * 4 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Agility * 4;
                                    x = 1;
                                    z = 1;
                                }
                            }
                            if (Class == 3)//
                            {
                                ClearKeyBuffer();
                                cki = Console.ReadKey(true);

                                if (cki.Key == ConsoleKey.D1 && SpellPoints > 4)
                                {
                                    Console.Write("\n               you did " + Intelligence / 2 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Intelligence / 2;
                                    SpellPoints -= 5;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D2 && Lv >= 3 && SpellPoints > 9)
                                {
                                    Console.Write("\n               you heald your self for " + Intelligence + " hp   \n");
                                    Health += Intelligence;
                                    SpellPoints -= 10;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D3 && Lv >= 5 && SpellPoints > 19)
                                {
                                    Console.Write("\n               you did " + Intelligence  + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Intelligence;
                                    SpellPoints -= 20;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D4 && Lv >= 10 && SpellPoints > 39)
                                {
                                    Console.Write("\n               you did " + Intelligence * 2 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Intelligence * 2;
                                    SpellPoints -= 40;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D5 && Lv >= 15 && SpellPoints > 79)
                                {
                                    Console.Write("\n               you did " + Intelligence * 3 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Intelligence * 3;
                                    SpellPoints -= 80;
                                    x = 1;
                                    z = 1;
                                }
                                if (cki.Key == ConsoleKey.D6 && Lv >= 20 && SpellPoints > 159)
                                {
                                    Console.Write("\n               you did " + Intelligence * 4 + " damage to the " + textM.MonsterMaster(Random001, 0) + "   \n");
                                    EnemyHP -= Intelligence * 4;
                                    SpellPoints -= 160;
                                    x = 1;
                                    z = 1;
                                }
                            }
                        }
                    }
                    if (cki2.Key == ConsoleKey.D2)//
                    {
                        Random002 = rnd.Next(1, 50);//

                        if(Random002 <= Agility)
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\n\n                    You got away safely!!!");
                            Thread.Sleep(3000);
                            return 0;
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\n\n                    The " + textM.MonsterMaster(Random001, 0) + " blocked your escape!!!");
                            Thread.Sleep(2000);
                            x = 1;
                        }

                    }
                }

                Thread.Sleep(3000);

                if (EnemyHP > 0)//
                {
                    Random003 = rnd.Next(1, 3);
                    Console.Clear();

                    Console.Write("\n     " + textM.MonsterMaster(Random001, 0) + "   Lv" + textM.MonsterNumberMaster(Random001, 0));
                    Console.Write("\n         HP" + EnemyHP + "   ");

                    Console.Write("\n\n\n\n\n                    " + Name + "   Lv" + Lv);
                    Console.Write("\n                        HP" + Health + "      Spell Points" + SpellPoints);

                    Console.Write("\n\n               The " + textM.MonsterMaster(Random001, 0) + " uses " + textM.MonsterMaster(Random001, Random003) + "   \n");

                    Console.Write("\n               You take " + textM.MonsterNumberMaster(Random001, 2) + " damage    \n");

                    Health -= textM.MonsterNumberMaster(Random001, 2);

                    Thread.Sleep(3000);
                }

            }

            if(Health <= 0)//
            {
                Console.Clear();
                Console.Write("\n     " + textM.MonsterMaster(Random001, 0) + "   Lv" + textM.MonsterNumberMaster(Random001, 0));
                Console.Write("\n         HP" + EnemyHP + "   ");

                Console.Write("\n\n\n\n\n                    " + Name + "   Lv" + Lv);
                Console.Write("\n                        HP" + 0 + "      Spell Points" + SpellPoints);
                Console.Write("\n\n\n               You wer defeted by the " + textM.MonsterMaster(Random001, 0) + ".   \n");
                Thread.Sleep(3000);
                return 99999999;
            }



            Console.Clear();
            Console.Write("\n     " + textM.MonsterMaster(Random001, 0) + "   Lv" + textM.MonsterNumberMaster(Random001, 0));
            Console.Write("\n         HP" + 0 + "   ");

            Console.Write("\n\n\n\n\n                    " + Name + "   Lv" + Lv);
            Console.Write("\n                        HP" + Health + "      Spell Points" + SpellPoints);
            Console.Write("\n\n\n               You defeted the  " + textM.MonsterMaster(Random001, 0) + " and received " + textM.MonsterNumberMaster(Random001, 0) * 48 + "Exp.   \n");
            Thread.Sleep(3000);

            return textM.MonsterNumberMaster(Random001, 0) * 48;//
        }

        public int CLASSQ(int Strength, int Agility, int Intelligence)//
        {
            if (Strength > Agility)//
            {
                if (Strength > Intelligence)//
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                if (Agility > Intelligence)//
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        public void GG()//
        {
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n");
            Console.Write("\n             _________    __  _________   ____ _    ____________ ");
            Console.Write("\n            / ____/   |  /  |/  / ____/  / __ \\ |  / / ____/ __ \\");
            Console.Write("\n           / / __/ /| | / /|_/ / __/    / / / / | / / __/ / /_/ /");
            Console.Write("\n          / /_/ / ___ |/ /  / / /___   / /_/ /| |/ / /___/ _, _/ ");
            Console.Write("\n          \\____/_/  |_/_/  /_/_____/   \\____/ |___/_____/_/ |_|  ");
            Console.Write("\n          ");
            
            Thread.Sleep(500);
            Console.Write("\n\n\n\n");
        }

        public int Riddle001()//
        {
            ConsoleKeyInfo cki;
            int x = 0,
                z = 0,
                y = 3;

            while (y > 0)//
            {
                Console.Clear();
                Thread.Sleep(500);
                if (y == 3)//
                {
                    Console.Write("\n\n          You feed it, it lives,\n          You give it something to drink, it dies. \n\n\n");

                    Console.Write("\n               \"Press 1\" Nothing \n");
                    Console.Write("\n               \"Press 2\" Fire \n");//correct
                    Console.Write("\n               \"Press 3\" A cat\n");
                    Console.Write("\n               \"Press 4\" Dust\n");
                }
                if (y == 2)//
                {
                    Console.Write("\n\n          My life can be measured in hours,\n          I serve by being devoured.\n          Thin, I am quick\n          Fat, I am slow\n          Wind is my foe.\n\n\n");

                    Console.Write("\n               \"Press 1\" A day\n");
                    Console.Write("\n               \"Press 2\" A bird\n");
                    Console.Write("\n               \"Press 3\" A candle \n");//correct
                    Console.Write("\n               \"Press 4\" Ice cream \n");
                }
                if (y == 1)//
                {
                    Console.Write("\n\n          It cannot be seen, cannot be felt,\n          Cannot be heard, cannot be smelt.\n          And empty holes it fills.\n          It comes first and follows after,\n          Ends life, kills laughter.\n\n\n");

                    Console.Write("\n               \"Press 1\" Gas\n");
                    Console.Write("\n               \"Press 2\" Air\n");
                    Console.Write("\n               \"Press 3\" Water\n");
                    Console.Write("\n               \"Press 4\" Darkness  \n");//correct
                }

                while (x != 1)//
                {
                    ClearKeyBuffer();
                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.D1)
                    {
                        x = 1;
                        z = 1;
                    }
                    if (cki.Key == ConsoleKey.D2)
                    {
                        x = 1;
                        z = 2;
                    }
                    if (cki.Key == ConsoleKey.D3)
                    {
                        x = 1;
                        z = 3;
                    }
                    if (cki.Key == ConsoleKey.D4)
                    {
                        x = 1;
                        z = 4;
                    }
                }

                if (z != 2 && y == 3)//
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.Write("\n\n          You have failed my test, I hereby banish you!!! \n\n\n");
                    Thread.Sleep(1000);
                    return 0;
                }
                if (z != 3 && y == 2)//
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.Write("\n\n          You have failed my test, I hereby banish you!!! \n\n\n");
                    Thread.Sleep(1000);
                    return 0;
                }
                if (z != 4 && y == 1)//
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.Write("\n\n          You have failed my test, I hereby banish you!!! \n\n\n");
                    Thread.Sleep(1000);
                    return 0;
                }
                x = 0;
                z = 0;
                y -= 1;
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("\n\n          You are correct! \n\n\n");//
                Thread.Sleep(1000);
            }
            return 23;//

        }
        public void ClearKeyBuffer()//
        {
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }
    
    
    }
}
