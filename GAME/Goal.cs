using System;
namespace Game
{
	public class Goal
	{

        public int X { get; set; }
        public int Y { get; set; }
        public string Display { get; set; }



        public Goal(int x, int y, string display)
        {
            X = x;
            Y = y;
            Display = display;

        }

	}
}

