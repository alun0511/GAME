using System;
namespace Game
{
	public class Goal
	{

        public int X { get; set; }
        public int Y { get; set; }
        public string Display { get; set; }
        public bool Completed { get; set; }


        public Goal(int x, int y, string display, bool completed)
        {
            X = x;
            Y = y;
            Display = display;
            Completed = completed;
        }

        public Goal()
		{
            if (Completed)
            {
                Console.WriteLine($"You went through the {Display}");
            }
		}
	}
}

