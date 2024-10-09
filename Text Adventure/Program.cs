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
            Console.WriteLine("Color meanings: gray = narrator, white = thoughts, blue = officers, red = for user");

            System.Threading.Thread.Sleep(3000);

            string shirtColor; //the color of the shirt is strictly for fun
            int shirtNum; //will decide the code needed to open the cabin door

            Console.WriteLine("Running through the forest has been a challenging task.\n" +
                "The dense leaves and sticks of bushes keep getting in the way of the objective ahead");

            System.Threading.Thread.Sleep(4000); //makes console wait before running further code

            Console.ForegroundColor = ConsoleColor.Blue; //blue is the color of other officers
            Console.WriteLine("Officer 'name', we send backup, but it'll take some time for them to reach you.\n" +
                "If possible, provide the description of the suspect");

            System.Threading.Thread.Sleep(3500);

            Console.ForegroundColor = ConsoleColor.White; //white is internal dialog
            Console.WriteLine("He is barely visible, but I can make out his shirt... I think");

            System.Threading.Thread.Sleep(3500);

            Console.ForegroundColor = ConsoleColor.Red; //red is the direction to the user
            Console.WriteLine("Choose the color of the shirt. Type EXACTLY what is written in the options\n" +
                "red | green | light blue");
            shirtColor = Console.ReadLine();

            Console.WriteLine("Now choose a number.\n" +
                "27 | 5 | 88");
            shirtNum = Convert.ToInt32(Console.ReadLine());

            System.Threading.Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Green; //green is the color of the main character
            Console.WriteLine("The shirt is " + shirtColor + " and I think it has a number on it.\n" +
                "It's..." + shirtNum + "!");

            System.Threading.Thread.Sleep(3000);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Roger that!");

            System.Threading.Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Okay, now hopefully we'll catch this guy");

            System.Threading.Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Everything was going well. Backup, 'name' is on his tail, and the forest is fairly small.\n " +
                "Nowhere to hide really.\n" +
                "Until something weird started happening, something that 'name' only just realized.\n" +
                "The forest went quiet. There is nothing but his gasping breaths.");


            Console.ReadKey();
        }

        static void colorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
