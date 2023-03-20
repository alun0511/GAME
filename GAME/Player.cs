using System;
namespace Game
{
    public class Player
    {

        //var x = roomWidth / 2;
        //var y = roomHeight / 2;



        public int X { get; set; }
        public int Y { get; set; }


        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public void getPos(Map map)
        //{
        //    X = map.Height / 2;
        //    Y = map.Width / 2;
        //}


    }

}