using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            string asciiTitle = @"
 _____     ______     ______   ______   ______     __     __     ______     ______     __         _____   
/\  __-.  /\  __ \   /\  == \ /\  == \ /\  ___\   /\ \  _ \ \   /\  __ \   /\  == \   /\ \       /\  __-. 
\ \ \/\ \ \ \ \/\ \  \ \  _-/ \ \  _-/ \ \___  \  \ \ \/ . \ \  \ \ \/\ \  \ \  __<   \ \ \____  \ \ \/\ \
 \ \____-  \ \_____\  \ \_\    \ \_\    \/\_____\  \ \__/ .~\_\  \ \_____\  \ \_\ \_\  \ \_____\  \ \____-
  \/____/   \/_____/   \/_/     \/_/     \/_____/   \/_/   \/_/   \/_____/   \/_/ /_/   \/_____/   \/____/                                                                                                                
                                                                                                                                                        
                                                                                                                                                        ";
            Console.WriteLine(asciiTitle);
            Game.StartGame();
            Game.SetupGame();
            Game.LevelOne();
            Console.ReadKey();
        }
    }
}
    