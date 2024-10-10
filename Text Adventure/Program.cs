using System.Drawing;

namespace Text_Adventure
{
    internal class Program
    {
        struct Character
        {
            public string name;
            public Stats stats;
        }

        struct Stats
        {
            public int health;
            public int defense;
            public int damage;
        }

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
                }
            };
            colorRed();
            Console.WriteLine("Instructions: gray = narrator, white = thoughts, blue = officers, red = for user, green = talking\n" +
                "Press 'space' to skip text, but whenever it says 'scene' you can't skip");
            
            Console.ReadKey();

            string shirtColor; //the color of the shirt is strictly for fun
            int shirtNum; //will decide the code needed to open the cabin door

            colorGray();
            Console.WriteLine("Running through the forest has been a challenging task.\n" +
                "The dense leaves and sticks of bushes keep getting in the way of the objective ahead");

            Console.ReadKey();

            colorBlue(); //blue is the color of other officers
            Console.WriteLine("'Officer " + character.name + ", we send backup, but it'll take some time for them to reach you.\n'" +
                "'If possible, provide the description of the suspect'");

            Thread.Sleep(200);

            colorWhite(); //white is internal dialog
            Console.WriteLine("He is barely visible, but I can make out his shirt... I think");

            Console.ReadKey();

            colorRed(); //red is the direction to the user
            Console.WriteLine("Choose the color of the shirt. Type EXACTLY what is written in the options\n" +
                "red | green | light blue");
            shirtColor = Console.ReadLine();

            Console.WriteLine("Now choose a number.\n" +
                "27 | 5 | 88");
            shirtNum = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();

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

            Console.ReadKey();

            colorGreen();
            Console.WriteLine("Just great, awesome! I lost the suspect and I don't have contact with the base!");

            Console.ReadKey();

            colorWhite();
            Console.WriteLine("But a choice had to be made, preferably now.");
            
            colorRed();
            Console.WriteLine("Where should you go? Type the letter of choice you make(capitalize)\n " +
                "A) back to base | B) search for suspect | C) wander around aimlessly | D) yell");
            char choice = Console.ReadKey().KeyChar;
            colorGray();

            if (choice == 'A')
            {
                Console.WriteLine("\nYou went back to try and leave the forest. There is no point in the mission with no contact to base");
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
                    "Then, it's darkness and cold.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("\nWhat are you doing?");
            }

            Console.WriteLine("doesn't work");

            Console.ReadKey();
        }

        static void colorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
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
    }
}
