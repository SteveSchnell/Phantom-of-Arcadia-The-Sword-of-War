///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          CharacterCreator
///   Description:    The purpose of this class is to let the user create a character
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;
using System.Threading;
using System.Windows.Forms;

/* -- public -----------------------------------------------------------------
** constructor
** CharacterCreator()
**
** Description:This is the constructor for the character creator class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** bool
** TitleScreen()
**
** Description:This didplays the title screen, and returns true if the space 
**             bar is pressed
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CCBackground()
**
** Description:This displays the back ground story
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CCClasses()
**
** Description:Lets the user choose their class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CCGender()
**
** Description:Lets the user choose their gender
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CCName()
**
** Description:Lets the user choose their name
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CCRace()
**
** Description:Lets the user choose their race
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CCsummary()
**
** Description:Prints out a summary of their chosen traits
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** ClearKeyBuffer()
**
** Description:Clears the key buffer to prevent wrong user inputs
** -------------------------------------------------------------------------*/

namespace RPG
{
    class CharacterCreator
    {
        string Name,
                Class,
                Race,
                gender;
               
        TextMasterClass textM = new TextMasterClass();//
        Random rnd = new Random();//

        public CharacterCreator()
        {
            
        }

        public bool TitleScreen()//
        {
            int x = 0;
            ConsoleKeyInfo cki;

            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n          Steve Schnell");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("\n\n\n          Steve Schnell Presents");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("\n\n\n                        Presents");
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(1000);
  
            //Phantom of Arcadia: The Sword of War

            Console.Write("\n         ____  __                __                           ____   ___                        ___        ");
            Console.Write("\n        / __ \\/ /_  ____ _____  / /_____  ____ ___     ____  / __/  /   |  ______________ _____/ (_)___ __ ");
            Console.Write("\n       / /_/ / __ \\/ __ `/ __ \\/ __/ __ \\/ __ `__ \\   / __ \\/ /_   / /| | / ___/ ___/ __ `/ __  / / __ `(_)");
            Console.Write("\n      / ____/ / / / /_/ / / / / /_/ /_/ / / / / / /  / /_/ / __/  / ___ |/ /  / /__/ /_/ / /_/ / / /_/ /   ");
            Console.Write("\n     /_/   /_/ /_/\\__,_/_/ /_/\\__/\\____/_/ /_/ /_/   \\____/_/    /_/  |_/_/   \\___/\\__,_/\\__,_/_/\\__,_(_) ");

            Thread.Sleep(500);

            Console.Write("\n         ________            _____                        __         ____   _       __          ");
            Console.Write("\n        /_  __/ /_  ___     / ___/      ______  _________/ /  ____  / __/  | |     / /___ ______");
            Console.Write("\n         / / / __ \\/ _ \\    \\__ \\ | /| / / __ \\/ ___/ __  /  / __ \\/ /_    | | /| / / __ `/ ___/");
            Console.Write("\n        / / / / / /  __/   ___/ / |/ |/ / /_/ / /  / /_/ /  / /_/ / __/    | |/ |/ / /_/ / /    ");
            Console.Write("\n       /_/ /_/ /_/\\___/   /____/|__/|__/\\____/_/   \\__,_/   \\____/_/       |__/|__/\\__,_/_/  ");


            Console.Write("\n\n\n\n\n\n\n                                press the Spacebar to start");

            while (x != 1)//
            {
                ClearKeyBuffer();
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    x = 1;
                }
            }

            return true;//
        }

        public void CCBackground()//
        {
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     There is an ancient legend of a great kingdom that was lost to the sands of time.");
            ClearKeyBuffer();
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     this great kingdom was call Arcadia; the legend says that the people who lived there where the");
            Console.Write("\n     absolute masters over magic.");
            ClearKeyBuffer();
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     The citizens of Arcadia created beautiful thing with their mastery over magic, building wonderful");
            Console.Write("\n     building and spread peace across the known world. But not all were happy with the utopian society");
            Console.Write("\n     sum wanted to use the power to rule the whole world.");
            ClearKeyBuffer();
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     And so a bloody civil war erupted in the once peaceful city between those that believe that");
            Console.Write("\n     magic was for helping the world and those that wanted to rule the whole world white fear.");
            Console.Write("\n     In the treble war many powerful magical artifacts were made from both sides but no more ");
            Console.Write("\n     powerful than the sword of war, the weapon was a horrid creation, dewatering the souls of the ");
            Console.Write("\n     living to fuel it destructive fours.");
            ClearKeyBuffer();
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     After a long and violent war peace returned to Arcadia. Much had been lost, the city was in ruins");
            Console.Write("\n     and most of the population had persist. The foe survivors took the weapon and looked it away");
            Console.Write("\n     beneath the city hoping it would never be found. Soon any memory of Arcadia faded away, lost");
            Console.Write("\n     forever. ");
            ClearKeyBuffer();
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     But now 1,000 years after the city disappeared from the pages of history, rumors are spreading");
            Console.Write("\n     about a abandoned city in the east and a shadowy organization that is plotting to enslave the ");
            Console.Write("\n     world.");
            ClearKeyBuffer();
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n     This is where our story begins with a prisoner, forgotten by the world.");
            Console.Clear();
            Thread.Sleep(1000);
        }

        public void CCClasses()//
        {
            ConsoleKeyInfo cki,
                cki2;
            int x = 0,
                z = 0;

            Console.Clear();
            Console.Write("\n\n\n         how do you wish to select your class?\n");
            Console.Write("\n         press 1 to generate ");
            Console.Write("\n         press 2 to select");

            while (z != 1)//
            {
                ClearKeyBuffer();
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)
                {

                    int Random001 = rnd.Next(1, 9);//

                    switch (Random001)//
                    {
                        case 1:
                            {
                                Class = "Barbarian";
                                MessageBox.Show("You are a Barbarian", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 2:
                            {
                                Class = "Bard";
                                MessageBox.Show("You are a Bard", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 3:
                            {
                                Class = "Knight";
                                MessageBox.Show("You are a Knight", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 4:
                            {
                                Class = "Battle Mage";
                                MessageBox.Show("You are a Battle Mage", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 5:
                            {
                                Class = "Warrior";
                                MessageBox.Show("You are a Warrior", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 6:
                            {
                                Class = "Assassins";
                                MessageBox.Show("You are a Assassins", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 7:
                            {
                                Class = "Ranger";
                                MessageBox.Show("You are a Ranger", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 8:
                            {
                                Class = "Thief";
                                MessageBox.Show("You are a Thief", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 9:
                            {
                                Class = "Spellswords";
                                MessageBox.Show("You are a Spellswords", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                    }
                    z = 1;
                }
                if (cki.Key == ConsoleKey.D2)//
                {
                    Console.Clear();
                    Thread.Sleep(500);

                    Console.Write("\n\n\n         Choose the class...\n");
                    Console.Write("\n         press 1 for Barbarian,      press F1 for info");
                    Console.Write("\n         press 2 for Bard,           press F2 for info");
                    Console.Write("\n         press 3 for Knight,         press F3 for info");
                    Console.Write("\n         press 4 for Battle Mage,    press F4 for info");
                    Console.Write("\n         press 5 for Warrior,        press F5 for info");
                    Console.Write("\n         press 6 for Assassins,      press F6 for info");
                    Console.Write("\n         press 7 for Ranger,         press F7 for info");
                    Console.Write("\n         press 8 for Thief,          press F8 for info");
                    Console.Write("\n         press 9 for Spellswords,    press F9 for info");

                    //Class

                    while (x != 1)//
                    {
                        ClearKeyBuffer();
                        cki2 = Console.ReadKey(true);//

                        if (cki2.Key == ConsoleKey.D1)
                        {
                            Class = "Barbarian";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D2)
                        {
                            Class = "Bard";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D3)
                        {
                            Class = "Knight";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D4)
                        {
                            Class = "Battle Mage";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D5)
                        {
                            Class = "Warrior";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D6)
                        {
                            Class = "Assassins";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D7)
                        {
                            Class = "Ranger";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D8)
                        {
                            Class = "Thief";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D9)
                        {
                            Class = "Spellswords";
                            x = 1;
                        }

                        //Info

                        if (cki2.Key == ConsoleKey.F1)
                        {
                            MessageBox.Show(textM.InfoList(0), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F2)
                        {
                            MessageBox.Show(textM.InfoList(1), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F3)
                        {
                            MessageBox.Show(textM.InfoList(2), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F4)
                        {
                            MessageBox.Show(textM.InfoList(3), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F5)
                        {
                            MessageBox.Show(textM.InfoList(4), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F6)
                        {
                            MessageBox.Show(textM.InfoList(5), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F7)
                        {
                            MessageBox.Show(textM.InfoList(6), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F8)
                        {
                            MessageBox.Show(textM.InfoList(7), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F9)
                        {
                            MessageBox.Show(textM.InfoList(8), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    z = 1;
                }
            }
            Console.Clear();
        }

        public void CCGender()//
        {
             ConsoleKeyInfo cki;
            int x = 0;

            Console.Clear();
            Thread.Sleep(500);

            Console.Write("\n\n\n         Choose thy gender...\n");
            Console.Write("\n         press 1 for Male");
            Console.Write("\n         press 2 for Female");

            while (x != 1)//
            {
                ClearKeyBuffer();
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)
                {
                    gender = "Male";
                    x = 1;
                }
                if (cki.Key == ConsoleKey.D2)
                {
                    gender = "Female";
                    x = 1;
                }
            }

        }

        public void CCName()//
        {
            ConsoleKeyInfo cki;
            int x = 0;

            Console.Clear();
            Thread.Sleep(500);

            Console.Write("\n\n\n         how do you wish to select your name?\n");
            Console.Write("\n         press 1 to generate a name ");
            Console.Write("\n         press 2 to enter a name");

            while (x != 1)//
            {
                ClearKeyBuffer();
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)
                {

                    int Random002 = rnd.Next(0, 20);//

                    if(gender.CompareTo("Male") == 0)
                    {
                        Name = textM.NameList(0,Random002);
                        MessageBox.Show("Your name is " + Name + ", the " + Class + ".", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (gender.CompareTo("Female") == 0)
                    {
                        Name = textM.NameList(1, Random002);
                        MessageBox.Show("Your name is " + Name + ", the " + Class + ".", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    x = 1;
                }
                if (cki.Key == ConsoleKey.D2)//
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.Write("\n\n\n         What will be thy name, " + Class + "?\n\n          ");
                    Name = Console.ReadLine();
                    Console.Clear();

                    x = 1;
                }
            }
            Console.Clear();   
        }

        public void CCRace()//
        {

            ConsoleKeyInfo cki,
                cki2;
            int x = 0,
                z = 0;

            Console.Clear();
            Thread.Sleep(500);
            Console.Write("\n\n\n         how do you wish to select your Race?\n");
            Console.Write("\n         press 1 to generate ");
            Console.Write("\n         press 2 to select");

            while (z != 1)
            {
                ClearKeyBuffer();
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1)//
                {

                    int Random003 = rnd.Next(1, 9);

                    switch (Random003)
                    {
                        case 1:
                            {
                                Race = "Dark elf";
                                MessageBox.Show("You are a Dark elf", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 2:
                            {
                                Race = "Dwarf";
                                MessageBox.Show("You are a Dwarf", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 3:
                            {
                                Race = "Elf";
                                MessageBox.Show("You are a Elf", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 4:
                            {
                                Race = "Gnome";
                                MessageBox.Show("You are a Gnome", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 5:
                            {
                                Race = "Half-Elf";
                                MessageBox.Show("You are a Half-Elf", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 6:
                            {
                                Race = "Half-Orc";
                                MessageBox.Show("You are a Half-Orc", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 7:
                            {
                                Race = "Human";
                                MessageBox.Show("You are a Human", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 8:
                            {
                                Race = "Orc";
                                MessageBox.Show("You are a Orc", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        case 9:
                            {
                                Race = "Wood elf";
                                MessageBox.Show("You are a Wood elf", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                    }
                    z = 1;
                }
                if (cki.Key == ConsoleKey.D2)//
                {
                    Console.Clear();
                    Thread.Sleep(500);

                    Console.Write("\n\n\n         Choose a Race...\n");
                    Console.Write("\n         press 1 for Dark elf,    press F1 for info");
                    Console.Write("\n         press 2 for Dwarf,       press F2 for info");
                    Console.Write("\n         press 3 for Elf ,        press F3 for info");
                    Console.Write("\n         press 4 for Gnome ,      press F4 for info");
                    Console.Write("\n         press 5 for Half-Elf,    press F5 for info");
                    Console.Write("\n         press 6 for Half-Orc,    press F6 for info");
                    Console.Write("\n         press 7 for Human,       press F7 for info");
                    Console.Write("\n         press 8 for Orc,         press F8 for info");
                    Console.Write("\n         press 9 for Wood elf,    press F9 for info");

                    //Race

                    while (x != 1)//
                    {
                        ClearKeyBuffer();
                        cki2 = Console.ReadKey(true);

                        if (cki2.Key == ConsoleKey.D1)
                        {
                            Race = "Dark elf";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D2)
                        {
                            Race = "Dwarf";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D3)
                        {
                            Race = "Elf";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D4)
                        {
                            Race = "Gnome";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D5)
                        {
                            Race = "Half-Elf";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D6)
                        {
                            Race = "Half-Orc";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D7)
                        {
                            Race = "Human";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D8)
                        {
                            Race = "Orc";
                            x = 1;
                        }
                        if (cki2.Key == ConsoleKey.D9)
                        {
                            Race = "Wood elf";
                            x = 1;
                        }

                        //Info

                        if (cki2.Key == ConsoleKey.F1)
                        {
                            MessageBox.Show(textM.InfoList(9), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F2)
                        {
                            MessageBox.Show(textM.InfoList(10), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F3)
                        {
                            MessageBox.Show(textM.InfoList(11), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F4)
                        {
                            MessageBox.Show(textM.InfoList(12), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F5)
                        {
                            MessageBox.Show(textM.InfoList(13), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F6)
                        {
                            MessageBox.Show(textM.InfoList(14), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F7)
                        {
                            MessageBox.Show(textM.InfoList(15), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F8)
                        {
                            MessageBox.Show(textM.InfoList(16), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (cki2.Key == ConsoleKey.F9)
                        {
                            MessageBox.Show(textM.InfoList(17), "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    z = 1;
                }
            }
            Console.Clear();
        }

        public void CCsummary()//
        {
            Console.Clear();
            Thread.Sleep(500);
            MessageBox.Show("Thou wilt be known as the " + Race + " " + Class + " " + Name + ". Thy body and mind must be strong and willful if thou art to succeed as a " + Class + ". Go ye now in peace let thy fate be written.", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Console.Clear();
            Thread.Sleep(500);
        }

        public void ClearKeyBuffer()
        {
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }

        public string RName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
            
        }
        public string RClass
        {
             get
            {
                return Class;
            }
            set
            {
                Class = value;
            }
        }
        public string RRace
        {
             get
            {
                return Race;
            }
            set
            {
                Race = value;
            }
        }
        public string RGender
        {
             get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        
    }
}
