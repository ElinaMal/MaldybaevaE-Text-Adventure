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
            gun,
            Knife,
            water,
            Vest,
            paper,
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
                items = new string[] {Objects.gun.ToString(), "", "", "", "", ""}
            };

            backColorPurple();
            colorBlue();
            Console.WriteLine("Instructions: gray = narrator, white = character thoughts, blue = officers, red = for user, green = character talking\n" +
                "Press any key to skip text, but whenever it says 'SCENE' you can't skip. Also, please use headphones");
            
            Console.ReadKey(true);
            
            string shirtColor; //the color of the shirt is strictly for fun
            int shirtNum; //will decide the code needed to open the cabin door

            colorGray();
            backColorBlack();
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
            shirtColor = Console.ReadLine()!;

            if (shirtColor == "red")
            {
                
            }
            else if (shirtColor == "green")
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
            colorRed();
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
                "Until something weird started happening, something that he only just realized.\n" +
                "The forest went quiet. There is nothing but " + character.name + "'s gasping breaths.");

            Thread.Sleep(11000);

            colorBlue();
            Console.WriteLine(character.name + " to base, what is going on I can't hear you?");

            Thread.Sleep(2200);

            colorGray();
            Console.WriteLine("But all that came through was a final beep, contact was lost.");
            Console.Beep(900, 300);
            
            //end the scene
            colorRed();
            Console.WriteLine("Press 'enter' to continue");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadLine();
            Console.Clear();

            colorGreen();
            Console.WriteLine("Just great, awesome! I lost the suspect, and I don't have contact with the base!");

            Console.ReadKey(true);
            
            colorWhite();
            Console.WriteLine("But a choice had to be made, preferably now.");
            
            colorRed();
            Console.WriteLine("Where should " + character.name + " go? Type the letter of choice you make(capitalize)\n " +
                "A) back to base | B) search for suspect | C) wander around aimlessly | D) yell\n" +
                "Warning: only answer A and D have completed/progressing stories");
            colorGray();
            
            // asks the user which of the 4 things will they do
            // back to base, search for suspect, wander around, yell
            whereToGo(shirtNum);

            Console.WriteLine("That's it, sorry got too ambitious and couldn't finish it");
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

        static void backColorPurple()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }

        static void backColorBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void whereToGo(int correct)
        {
            char choice = Console.ReadKey(true).KeyChar;

            if (choice == 'A')
            {
                Character character = new()
                {
                    name = "User",
                    stats = new()
                    {
                        health = 20,
                        defense = 5,
                        damage = 5,

                    },
                    items = new string[] { Objects.gun.ToString(), "", "", "", "", "" }
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
                Console.ReadKey(true);
                
                bool insideCabin = false;

                CancellationTokenSource source = new();

                ThreadPool.QueueUserWorkItem(obj =>
                {
                    for (int boo = 1; insideCabin == false; boo++)
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

                }, source.Token);

                colorWhite();
                Console.WriteLine("Some sort of beeping...");
                Console.ReadKey(true);

                colorGreen();
                Console.WriteLine("*Sigh*");
                Console.ReadKey(true);
                
                colorGray();
                Console.WriteLine("Despite wanting that idea dead in your mind, you move closer to see whether you can get inside");
                Console.ReadKey(true);

                Console.WriteLine("As you step onto the porch, you hear it creak under your weight like a howl calling to the darkness for your soul.\n" +
                    "You get up and to the door where you see a set of numbers written on it");
                Console.ReadKey(true);

                Console.WriteLine("Ignoring them you try and open the door, but it's locked.\n" +
                    "In your exasperation you notice that numbers can be pressed");
                Console.ReadKey(true);

                colorWhite();
                Console.WriteLine("Maybe it needs a code... but that would be ridiculous");
                Console.ReadKey(true);
                
                colorGray();
                Console.WriteLine("Nevertheless, you still decide to try it.\n");
                
                backColorPurple();
                colorBlue();
                Console.WriteLine("Ignore the beeping ");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("it's not going to give you the answer ");
                Console.BackgroundColor = ConsoleColor.Red;
                colorGreen();
                Console.WriteLine("it's there for fun ");
                Console.BackgroundColor = ConsoleColor.Green;
                colorRed();
                Console.WriteLine("the actual input is 1-2 numbers long");

                Console.ReadKey(true);

                backColorBlack();
                Console.WriteLine("Type out the answer\n" +
                    "To get a hint, type this: 'help'\n" +
                    "To get the right answer, type this: 'answer' ");
                
                int fun = 5;

                while (fun == 5)
                {
                    string answer = Console.ReadLine()!;

                    if (answer == "help")
                    {
                        Console.WriteLine("Remember the number on the suspect's shirt");
                        answer = string.Empty;
                        continue;
                    }
                    else if (answer == "answer")
                    {
                        Console.WriteLine("The answer is: " + correct.ToString());
                        answer = string.Empty;
                        continue;
                    }
                    else if (answer == correct.ToString())
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Type the correct answer");
                        answer = string.Empty;
                        continue;
                    }
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);

                source.Cancel();
                insideCabin = true;

                colorWhite();
                Console.WriteLine("It worked... I can't believe it");
                Console.ReadKey(true);

                colorGray();
                Console.WriteLine("You slowly open the door and enter the building.\n" +
                    "With shadows lurking at every corner of your vision, you start feeling adrenaline pumping in your blood");
                Console.ReadKey(true);

                Console.WriteLine("You proceed further inside, thinking about how this is better than being alone in a forest full of carnivors.\n" +
                    "But you notice something...");
                Console.ReadKey(true);

                colorWhite();
                Console.WriteLine("The beeping, it stopped...");
                Console.ReadKey(true);

                colorGray();
                Console.WriteLine("That sends your adrenaline running. 'Why did it stop?' you think. 'WHAT made it stop?'");
                Console.ReadKey(true);

                colorRed();
                Console.WriteLine("SCENE");

                colorGray();
                Console.WriteLine("With your newfound anxiety, you keep walking forward");
                Thread.Sleep(1500);

                Console.WriteLine("Cobweds littering the building from inside out convince you that there hasn't been anyone here in years");
                Thread.Sleep(2000);

                Console.WriteLine("You managed to get to the middle of the cabin's first floor");
                Thread.Sleep(1000);

                Console.WriteLine("THUMP!");
                Thread.Sleep(1500);

                colorWhite();
                Console.WriteLine("What was that?");
                Thread.Sleep(1000);

                colorGray();
                Console.WriteLine("The sound came from the basement");
                Thread.Sleep(1000);

                Console.WriteLine("Press 'enter' to continue");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ReadLine();
                Console.Clear();

                colorRed();
                Console.WriteLine("Where should you go? Type out full answer! Make a choice, quick!\n" +
                    "go down | leave the building | hide in the closet");

                using CancellationTokenSource see = new();

                
                if (ThreadPool.QueueUserWorkItem(Death, see.Token))
                {
                    fun++;

                    while (fun == 6)
                    {
                        string input = Console.ReadLine()!;

                        if (input == "go down")
                        {

                        }
                        else if (input == "leave the building")
                        {

                        }
                        else if (input == "hide in the closet")
                        {

                        }
                        else
                        {

                        }
                    }
                }

                Console.WriteLine("Testing");
                
                return;
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
                whereToGo(correct);
            }

            static void QuickAction()
            {

            }

            static void Death(object? obj)
            {
                Thread.Sleep(5000);

                Console.WriteLine("You Died");
            }
        }
    }
}
