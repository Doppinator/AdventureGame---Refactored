using System.Threading.Channels;

namespace Adventure
{
    public static partial class Game
    {
        //Print welcome
        public static void StartGame()
        {
            Welcome("Welcome to DoppsWorld\n");
            Console.Write("There are some random things to do. Hit any key to continue... \n");
            Console.ReadKey();

        }

        public static void SetupGame()
        {
            playerObj player = new playerObj();
            Console.WriteLine("Enter your player name");
            player.playerName = Console.ReadLine();
            Console.WriteLine("Your name is  " +  player.playerName);
            LevelOne();
        }
        public static void LevelOne()
        {
            Console.WriteLine("You're awake. You don't have a toothbrush. Go to the shop.");

            if (Console.ReadLine() == "Go to the shop")
            {
                Console.WriteLine("You fumble around in the dark. You might want to turn the light on...");
                Console.ReadLine();
            }
            else if (Console.ReadLine() == "Turn the light on")
            {
                LevelTwo(); 
            }
        }

            public static void LevelTwo()
            {
                Console.WriteLine("The light is blinding. Player health is " + playerObj.health + ", brushing your teeth adds 20 health points. The shop is close.");
                if (Console.ReadLine() == "Go to the shop")
                {
                    Console.WriteLine("The cashier gives you a toothbrush. What do you do with it?");

                    if (Console.ReadLine() == "Brush teeth")
                    {
                        playerObj.health += 20;
                        Console.WriteLine("Health is now " + playerObj.health);
                    }
                }
            }

    
        

        

        static void Welcome(string welcomeMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(welcomeMessage);
            Console.ResetColor();
        }

    }
}
    