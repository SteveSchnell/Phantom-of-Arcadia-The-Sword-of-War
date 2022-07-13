///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          TextMasterClass : MonsterList
///   Description:    This class contains the most of the text the user will see in the program
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;

/* -- public -----------------------------------------------------------------
** constructor
** TextMasterClass()
**
** Description:Constructor of the class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** string
** InfoList(int X)
**
** Description:Returns information about either race or class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** string
** NameList(int X, int Y)
**
** Description:Returns a name
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** string
** TextMaster(int X,int Y)
**
** Description:Returns the text of a given stage in the name
** -------------------------------------------------------------------------*/

namespace RPG
{
    class TextMasterClass : MonsterList//
    {

        string[,] MasterTextList = {{ "          You wake up in a dark prison cell, you don't remember why you are in here there is a old door \n          on the outer side of the room.", "", "", "Go to the door.", "Look around in the cell." ,"" ,"",""},//
                                   { "          The door is locked you need a key to open it.", "          You open the door using the key that you found.", "          The door is open", "Look around the cell.", "", "", "", "Go through the door.",},
                                   { "          You decide to go and look around in the cell. The cell is dark and damp with Cold Stone floors \n          walls and ceilings.The door is the only way out of here. You notice a shiny object near the wall.", "          You decide to go and look around in the cell. The cell is dark and damp with Cold Stone floors\n          walls and ceilings.The door is the only way out of here.", "", "Go to the door.", "", "", "", "Go and investigate this shiny object.",},
                                   { "          You investigate the shiny object near the wall, to your surprise it is a old key,  hopefully it\n          will open the door.", "", "", "Go to the door", "Look around the cell ", "", "", "",},
                                   { "          You stepped out of the damp Dark Cells into a small dark hallway. The hallway is dimly lit and \n          goes on till it disappears in darkness.", "", "", "Go down the north hallway.", "Go down the south hallway.", "Look around the hallway.", "", "",},
                                   { "          About ten meters down the hallway, you come upon a turn. You are unable to see what lies beyond\n          the darkness in the hallway. ", "", "", "Continue down the hallway. ", "Go back to the beginning.", "", "", "",},
                                   { "          You walk down the hallway for a couple of meters, the air is starting to get fresher but there is\n          still no exit in sight.", "", "", "Go back.", "Continue through the hallway.", "", "", "",},
                                   { "          The hallway is dark and empty the walls ceilings and floors are all made out of a dark cold stone,\n          it looks like no one has been here in a long time.", "", "", "Go down the north hallway.", "Go down the south hallway.", "", "", "",},
                                   { "          You continue to explore the hallway when you come upon a turn.", "", "", "Go back.", "Continue down the hallway.", "", "", "",},
                                   { "          After a couple of meters you come up on the T- intersection in front. The hallway in front of you\n          looks like it is going upwards while the side hallway seems to disappear in darkness.", "", "", "Continue with the up words hallway.", "Go down the dark hallway.", "Go back.", "", "",},
                                   { "          You walk for a couple of meter, when the hallways suddenly comes to a dead end. There seems to have\n          been a cave-in around here, the pass is a blocked by large boulders.", "", "", "Go back.", "", "", "", "",},
                                   { "          After just a couple of steps you come upon another T-intersection. This time both hallways look the\n          same.", "", "", "Go down the hallway to your right.", "Go down the hallway to your left.", "Go back.", "", "",},
                                   { "          You went down the hallway to your right after a couple of meters the hallway comes to an dead-end. \n          There seem to have been another cave-in around here, the pass is blocked.", "", "", "Go back.", "", "", "", "",},
                                   { "          You walk for a couple of meters, when you suddenly feel the air getting fresher around you. You \n          definitely must be getting closer to the exit.", "", "", "Continue down the hallway.", "Go back. ", "", "", "",},
                                   { "          After walking for a couple of minutes you come up on another T intersection. One hallway is dark\n          and the air is stale while the other hallway has a faint light shining at the end of it", "", "", "Go down the dark hallway. ", "Go down the hallway with the light.", "Go back to the turn.", "", "",},
                                   { "          You investigate the hallway with the light shining at the end of it. When you finally arrived you\n          find that your pass is blocked by a large wooden door. There is light shining underneath it, this\n          must be the exit, but there's a problem - the door is locked.", "", "", "Go back.", "Try to open the door", "", "", "",},
                                   { "          After a couple of meters you come up on another turn. The air is starting to get fresher, and you\n          can feel a light breeze. You must be getting close to the exit.", "", "", "Continue down the hallway.", "Go back to the other turn.", "", "", "",},
                                   { "          As you continue to explore the hallways you come upon another turn. ", "", "", "Continue down the hallway", "Go back to the t-intersection", "", "", "",},
                                   { "          As you continue to explore the hallways you come upon a T-intersection. The hallway continues to\n          your left and to your right, you are unable to see what lies beyond the shadows, the air is starting \n          to get fresher.", "", "", "Go down the hallway to your right.", "Go down the hallway to your left.", "Go back to the turn.", "", "",},
                                   { "          As you continue walking you suddenly come to a dead end. The hallway doesn't go any further, it \n          looks like there was a cave-in here.", "", "", "Go back to the t-intersection.", "", "", "", "",},
                                   { "          You try to force the door open when you hear suddenly a loud bellow voice saying “I am the guardian\n          of this prison answer my riddle and you shall be free If you fail you will face the consequences!”", "", "", "Go back.", "Try to solve the riddle.", "", "", "",},
                                   { "          You except to answer to riddles The Guardian says, “If you fail you will be sent back into your \n          cell, are you ready to begin.”", "", "", "Yes!", "No!", "", "", "",},
                                   { "22riddle ", "", "", "", "", "", "", "",},
                                   { "          As you answer the last riddle The Guardian says in its booming voice, “You have answered all of \n          the riddles and may now leave the prison”", "", "", "Go through the door.", "", "", "", "",},
                                   { "          As you step out through the door you find yourself standing on the side of a grassy hill. The\n          prison where you were was part of the old ruined Fort which towers up behind. You see in the  \n          mountains, and forests in the distance, it seems to be morning.", "", "", "Go to the mountains.", "Go to the forest.", "Explore the hills surrounding the fort. ", "", "",},
                                   { "          End of episode 1", "", "", "", "", "", "", "",},
                                   { "          End of episode 1", "", "", "", "", "", "", "",},
                                   { "          End of episode 1", "", "", "", "", "", "", "",}};


        string[,] NameMasterList = {{ "Suhlam Nohlu", "Ril Shekriz", "Delvarvad Nadzogiko", "Jedjoc Vilzaldi", "Qo Jaoy", "Ebrer Vav", "Kar Shurkarsk", "Oman Misttalon", "Zath Richflaw", "Thion Tuay", "Som Rolez", "Lien Niang", "Ardar Rile", "Reldel Faldemo", "Trdan Woodlance", "Frer Rockvigor", "Men Cha", "Fasif Grersk", "Zeh Ji", "Strordon Whisperflare" },//
            { "Kosre Dragonmight", "Calahe Lelivrihr", "Thahoh Honkhild", "Zhna Shosk", "Aneh Bhoshi", "Mua Sing", "Dinrurlu Mugyedudzi", "Linna Dug", "Linna Dug", "Jilo Gloomsprinter", "Yasnasheh Jakhe", "Vlms Riveldel", "Xo Paon", "Chitha Duejehd", "Chitha Duejehd", "Muzzu Cloudthorn", "Falm Piloro", "Lali Stormoak", "Creh Zeku", "Irs Cisqorar" }};


        string[,] InfoMasterList = {{"Barbarians are Warriors who have learned to fight in order to survive the harsh life of their homeland. Barbarians begin with the most hit points of any character class. Because of their hardy upbringing, Barbarians have a natural immunity to poison. Barbarians, because of their incredible physique, heal additional health points based upon their endurance.","",},//
            {"A Bard is the proverbial 'Jack of all Trades'. They are able to perform many tasks, including but not limited to critical strikes, weapons skill, picking locks/pockets, and magic. They are a very versatile class, able to take up slack in almost any situation. Bards receive an amount equal to their Intelligence in spell points. A Bard's critical strike capability is useful when cornered by stronger opponents.","",},
            {"Knights are the fighters of the noble class. They are well schooled in the ways of chivalry and conduct themselves with honor and dignity. Because of a Knight's innate strength of character, he or she is immune to paralyzation, whether they be carried by spells or poison. They also have the ability to repair damaged weapons or armor. This ability is done automatically to any weapons or armor in their inventory.","",},
            {"Battle Mages are trained and bred to manipulating the essence of magic in battle. They are highly skilled at delivering offensive spells at their targets. They have 1.75 times their Intelligence in spell points. In combat, a trained Battle Mage has few equals.","",},
            {"Warriors are the basic stock of the world of Arcadia. They are a versatile character, able to employ their skill at arms in almost any situation. Warriors are the second fastest to rise in experience, thieves being the fastest.","",},
            {"Assassins are the dark hand of the night, their skills honed to the killing of others. They are very adept at this, able to find weak points or areas to strike, often felling opponents much more powerful than themselves. Assassins have the greatest chance per level to score a critical hit (triple damage) when attacking.","",},
            {"Rangers are woodsmen and hunters, adept at tracking, survival, and pathfinding. Rangers, because of their skills at tracking and survival, automatically decrease their traveling time between cities. In addition, Rangers do extra damage equivalent to their level to their opponent.","",},
            {"Quick, agile, and cunning, Thieves use agility and speed to steal for a living. They are useful in combat to surprise the enemy, scout, or try for critical hits. Thieves have a chance per level of experience to score a critical hit when attacking an opponent. A critical hit is defined as triple the damage the weapon normally does. Thieves are the fastest to rise in experience levels.","",},
            {"Spellswords are those few Mages who have found that they have a unique ability to cast spells while in armor or using weapons. They are warrior-mages, dedicating their lives to learning not only the arts of war, but the ethereal ways of power. Spellswords, because of their dedication to learning both arts, receive only 1.5 times their Intelligence in spell points.","",},
            {"Dark elves are a depraved and evil subterranean offshoot. White is the most common hair color among dark elves, but almost any pale shade is possible. dark elves tend to be smaller and thinner than other sorts of elves, and their eyes are often a vivid red.","",},
            {"Dwarves favor earth tones in their clothing and prefer simple and functional garb. The skin can be very dark, but it is always some shade of tan or brown. Hair color can be black, gray, or brown. Dwarves average 4 feet tall and weigh as much as adult humans.","",},
            {"Elves average 5 feet tall and typically weigh just over 100 pounds. They live on fruits and grains, though they occasionally hunt for fresh meat. Elves prefer colorful clothes, usually with a green-and-gray cloak that blends well with the colors of the forest.","",},
            {"Gnomes stand 3 to 3-1/2 feet tall and weigh 40 to 45 pounds. Their skin color ranges from dark tan to woody brown, their hair is fair, and their eyes can be any shade of blue. Gnome males prefer short, carefully trimmed beards. Gnomes generally wear leather or earth tones, though they decorate their clothes with intricate stitching or fine jewelry.","",},
            {"Half-elves are not truly an elf subrace, but they are often mistaken for elves. Half-elves usually inherit a good blend of their parents’ physical characteristics","",},
            {"These orc–human crossbreeds can be found in either orc or human society, or in communities of their own. Half-orcs usually inherit a good blend of the physical characteristics of their parents. They are as tall as humans and a little heavier, thanks to their muscle. They have greenish pigmentation, sloping foreheads, jutting jaws, prominent teeth, and coarse body hair. ","",},
            {"Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds.","",},
            {"An orc’s hair usually is black. It has lupine ears and reddish eyes. Orcs prefer wearing vivid colors that many humans would consider unpleasant, such as blood red, mustard yellow, yellow-green, and deep purple. Their equipment is dirty and unkempt. An adult male orc is a little over 6 feet tall and weighs about 210 pounds. ","",},
            {"Their hair color ranges from yellow to a coppery red, and they are more muscular than other elves. Their clothing is in dark shades of green and earth tones to better blend in with their natural surroundings. ","",}};



        public TextMasterClass()//
        {
        }

        public string InfoList(int X)//
        {
            return InfoMasterList[X, 0];
        }

        public string NameList(int X, int Y)//
        {
            return NameMasterList[X, Y];
        }

        public string TextMaster(int X,int Y)//
        {
            return MasterTextList[X,Y];
        }

        
    }
}
