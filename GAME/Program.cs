using DanteGame;

//player and goal are assigned coordinates, map is assigned height and width as well as which objects to draw

var dante = new Player(20, 10);
var door = new Goal(3, 10, "_");
//var limbo = new Map(40, 20, door, dante);
//var lust = new Map(60, 30, door, dante);





//public void draw(Map map, Player player, Goal goal)
//{
//    while (true)
//    {
//        Console.Clear(); // clear the console before drawing the character

//        for (var row = 0; row < map.Height; row++)
//        {
//            for (var col = 0; col < map.Width; col++)
//            {
//                if (row == goal.X && col == goal.Y && col == player.X && row == player.Y)
//                {
//                    map.Completed = true;

//                }


//                if (row == 0 || row == map.Height - 1 || col == 0 || col == map.Width - 1)
//                {
//                    Console.Write(".");
//                }
//                else if (col == player.X && row == player.Y)
//                {
//                    Console.Write("*");
//                }
//                else if (row == goal.X && col == goal.Y)
//                {
//                    Console.Write($"{goal.Display}");
//                }

//                else
//                {
//                    Console.Write(" ");

//                }

//            }

//            Console.WriteLine();
//        }

//        // read user input and update character position

//        var input = Console.ReadKey(true).Key;
//        switch (input)
//        {
//            case ConsoleKey.LeftArrow:
//                if (player.X > 1) player.X--;
//                break;
//            case ConsoleKey.RightArrow:
//                if (player.X < map.Width - 2) player.X++;
//                break;
//            case ConsoleKey.UpArrow:
//                if (player.Y > 1) player.Y--;
//                break;
//            case ConsoleKey.DownArrow:
//                if (player.Y < map.Height - 2) player.Y++;
//                break;
//        }

//    }

//}