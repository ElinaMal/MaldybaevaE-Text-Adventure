using Microsoft.VisualBasic;
using System.Drawing;

namespace Text_Adventure
{
    internal class Program
    {
        struct Character
        {
            public string name;
            public Stats stats;
            public string[] items;
        }

        struct Stats
        {
            public int health;
            public int defense;
            public int damage;
        }

        enum Objects
        {
            Gun,
            Knife,
            Water,
            Vest,
            Paper,
            Files
        };

        static void Main(string[] args)
        {
            Character character = new()
            {
                name = "Kyle",
                stats = new()
                {
                    health = 20,
                    defense = 5,
                    damage = 5,

                },
                items = new string[] {Objects.Gun.ToString(), "", "", "", "", ""}
            };


            colorRed();
            Console.WriteLine("Instructions: gray = narrator, white = thoughts, blue = officers, red = for user, green = talking\n" +
                "Press any key to skip text, but whenever it says 'scene' you can't skip");
            
            Console.ReadKey(true);
            /*
            string shirtColor; //the color of the shirt is strictly for fun
            int shirtNum; //will decide the code needed to open the cabin door

            colorGray();
            Console.WriteLine("Running through the forest has been a challenging task.\n" +
                "The dense leaves and sticks of bushes keep getting in the way of the objective ahead");

            Console.ReadKey(true);

            colorBlue(); //blue is the color of other officers
            Console.WriteLine("'Officer " + character.name + ", we send backup, but it'll take some time for them to reach you.\n'" +
                "'If possible, provide the description of the suspect'");

            Thread.Sleep(200);

            colorWhite(); //white is internal dialog
            Console.WriteLine("He is barely visible, but I can make out his shirt... I think");

            Console.ReadKey(true);

            colorRed(); //red is the direction to the user
            Console.WriteLine("Choose the color of the shirt. Type EXACTLY what is written in the options\n" +
                "red | green | light blue");
            shirtColor = Console.ReadLine();

            if (shirtColor == "red")
            {

            }
            else if (shirtColor == "red")
            {

            }
            else if (shirtColor == "light blue")
            {

            }
            else
            {
                shirtColor = "yellow";
            }

                Console.WriteLine("Now choose a number.\n" +
                "27 | 5 | 88");
            try 
            { 
                shirtNum = Convert.ToInt32(Console.ReadLine()); 
            }
            catch
            {
                shirtNum = 64;
            }

            if (shirtNum == 27)
            {

            }
            else if (shirtNum == 5)
            {

            }
            else if (shirtNum == 88)
            {

            }
            else
            {
                shirtNum = 64;
            }


            Console.ReadKey(true);

            //start scene
            colorGray();
            Console.WriteLine("SCENE");

            colorGreen(); //green is the color of the main character
            Console.WriteLine("The shirt is " + shirtColor + " and I think it has a number on it.\n" +
                "It's..." + shirtNum + "!");

            Thread.Sleep(3500);

            colorBlue();
            Console.WriteLine("Roger that!");

            Thread.Sleep(1000);

            colorWhite();
            Console.WriteLine("Okay, now hopefully we'll catch this guy");

            Thread.Sleep(2500);

            colorGray();
            Console.WriteLine("Everything was going well. Backup, " + character.name + " is on his tail, and the forest is fairly small.\n" +
                "Nowhere to hide really.\n" +
                "Until something weird started happening, something that " + character.name + " only just realized.\n" +
                "The forest went quiet. There is nothing but his gasping breaths.");

            Thread.Sleep(11000);

            colorBlue();
            Console.WriteLine(character.name + " to base, what is going on I can't hear you?");

            Thread.Sleep(2200);

            colorGray();
            Console.WriteLine("But all that came through was a final beep, contact was lost.");
            Console.Beep(800, 300);

            //end the scene
            Thread.Sleep(3000);
            Console.Clear();

            colorRed();
            Console.WriteLine("Press any key to continue");

            Console.ReadKey(true);

            colorGreen();
            Console.WriteLine("Just great, awesome! I lost the suspect, and I don't have contact with the base!");

            Console.ReadKey(true);
            
            colorWhite();
            Console.WriteLine("But a choice had to be made, preferably now.");
            */
            colorRed();
            Console.WriteLine("Where should you go? Type the letter of choice you make(capitalize)\n " +
                "A) back to base | B) search for suspect | C) wander around aimlessly | D) yell");
            colorGray();


            // asks the user which of the 4 things will they do
            // back to base, search for suspect, wander around, yell
            whereToGo();

            Console.ReadKey(true);
        }

        static void colorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        //narrator color
        static void colorGray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void colorRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void colorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void colorBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void whereToGo()
        {
            char choice = Console.ReadKey(true).KeyChar;

            if (choice == 'A')
            {
                Character character = new()
                {
                    name = "Kyle",
                    stats = new()
                    {
                        health = 20,
                        defense = 5,
                        damage = 5,

                    },
                    items = new string[] { Objects.Gun.ToString(), "", "", "", "", "" }
                };

                Console.WriteLine("\nYou went back to try and leave the forest. There is no point in the mission with no contact to base");
                Console.ReadKey(true);

                Console.WriteLine("As you walk through the thickets, you notice the sun.");
                Console.ReadKey(true);

                colorWhite();
                Console.WriteLine("That thing is way too close to the horizon, I should have already been out of the forest");
                Console.ReadKey(true);

                colorGray();
                Console.WriteLine("But it only got darker, and the realization had dawned on you.\n" +
                    "You are lost in a forest, where the killer you were chasing is wandering around, with no contact to base.");
                Console.ReadKey(true);

                Console.WriteLine("And so you walk...");
                int number = 0;
                do
                {
                    Console.WriteLine("and walk...");
                    number++;
                } while (number <= 2);

                Console.WriteLine("And keep walking around in hopes that you find something, all while keeping your hand close to the " + character.items[0]);
                Console.ReadKey(true);

                Console.WriteLine("Eventully, after what felt like hours of aimless walking, with the sun almost reaching horizon, you stuble upon a cabin.\n" +
                    "It looks almost ancient, and sends shivers down your spine when you look at it, but it's more than the plain forest surrounding you");
                Console.ReadKey(true);

                Console.WriteLine("You start moving closer to it, and then you hear a peculiar sound");

                bool insideCabin = false;

                for (int boo = 7; insideCabin == false;)
                {
                    Console.Beep(500, 900);
                    Console.Beep(500, 400);
                    Console.Beep(500, 900);
                    Console.Beep(500, 400);
                    Thread.Sleep(900);

                    Console.Beep(500, 900);
                    Console.Beep(500, 900);
                    Console.Beep(500, 900);
                    Thread.Sleep(900);

                    Console.Beep(500, 400);
                    Console.Beep(500, 900);
                    Console.Beep(500, 900);
                    Thread.Sleep(900);

                    Console.Beep(500, 400);
                    Console.Beep(500, 900);
                    Thread.Sleep(900);

                    Console.Beep(500, 400);
                    Console.Beep(500, 900);
                    Console.Beep(500, 400);
                    Thread.Sleep(900);

                    Console.Beep(500, 900);
                    Console.Beep(500, 400);
                    Console.Beep(500, 400);
                    Thread.Sleep(4000);

                }



                Console.ReadKey();

                insideCabin = true;

            }

            else if (choice == 'B')
            {
                Console.WriteLine("\nYou decide to go forward deeper into the forest, suspect is on the lose and you won't give up that easily");
            }

            else if (choice == 'C')
            {
                Console.WriteLine("\nYou decide to just go on a stroll, not much can be done about the situation");
            }

            else if (choice == 'D')
            {
                Console.WriteLine("\nYou scream into the shadows of the forest, hoping to achieve the unknown\n" +
                    "But then, you see something jump out at you!\n" +
                    "As soon as it's on top of you, you feel agonizing pain erupt in your stomach.\n" +
                    "Then, it turns dark and cold...");
                colorGray();
                Console.WriteLine("You died");
                Console.ReadKey(true);
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("\nThat's not an option");
                whereToGo();
            }
        }
    }
}
