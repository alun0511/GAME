using System;
namespace Game
{
    public class Player
    {

        //var x = roomWidth / 2;
        //var y = roomHeight / 2;



        public int X { get; set; }
        public int Y { get; set; }
        //public Map Map { get; set; }


        public Player(int x, int y)
        {
            X = x;
            Y = y;
            //Map = map;
        }

        //public void getPos(Map map)
        //{
        //    X = map.Height / 2;
        //    Y = map.Width / 2;
        //}

        public void Move()
        {

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

        }

    }

}