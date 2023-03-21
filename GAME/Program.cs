using Game;

//player and goal are assigned coordinates, map is assigned height and width as well as which objects to draw

var dante = new Player(20, 10);
var door = new Goal(3, 10, "Door", false);
var limbo = new Map(40, 20, door, dante);

limbo.draw(limbo, dante, door);




//var roomWidth = 40;
//var roomHeight = 20;
//var x = roomWidth / 2;
//var y = roomHeight / 2;
//var stopwatch = new Stopwatch();
//stopwatch.Start();
//bool goal = false;
//var intro = "You wake up in the burning flames of hell with no memory of what you have done previously to end up here.\nYou only know one thing, that you need to get out of here ";
//var map2 = "Sadly you find yourself at a another stage of hell!";

//while (true)
//{
//    Console.Clear(); // clear the console before drawing the character
//    if (goal == true)
//    {
//        Console.WriteLine(map2);
//        //roomWidth = 50;
//        //roomHeight = 40;
//        // Go to next level
//    }


//    if (goal == false)
//    {
//        Console.WriteLine(intro);
//    }

//    for (var row = 0; row < roomHeight; row++)
//    {
//        for (var col = 0; col < roomWidth; col++)
//        {
//            if (row == 3 && col == 10 && col == x && row == y)
//            {
//                //Console.WriteLine("You made the choice of A");
//                goal = true;
//            }



//            if (row == 0 || row == roomHeight - 1 || col == 0 || col == roomWidth - 1)
//            {
//                Console.Write(".");
//            }
//            else if (col == x && row == y)
//            {
//                Console.Write("*");
//            }
//            else if (row == 3 && col == 10)
//            {
//                Console.Write("GOAL");
//            }

//            else
//            {
//                Console.Write(" ");
//            }
//        }
//        Console.WriteLine();
//    }
//    var elapsed = stopwatch.Elapsed;
//    Console.WriteLine("Elapsed time: {0}:{1:D2}:{2:D2}",
//        elapsed.Hours, elapsed.Minutes, elapsed.Seconds);

//    // read user input and update character position
//    var input = Console.ReadKey(true).Key;
//    switch (input)
//    {
//        case ConsoleKey.LeftArrow:
//            if (x > 1) x--;
//            break;
//        case ConsoleKey.RightArrow:
//            if (x < roomWidth - 2) x++;
//            break;
//        case ConsoleKey.UpArrow:
//            if (y > 1) y--;
//            break;
//        case ConsoleKey.DownArrow:
//            if (y < roomHeight - 2) y++;
//            break;
//    }
//}