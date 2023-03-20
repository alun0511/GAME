using System;
namespace Game
{
	public class Map
	{

		public int Width { get; set;}
        public int Height { get; set; }
        public Goal Goal { get; set; }
        public Player Player { get; set; }
        public bool Running { get; set; }

        public Map(int width, int height, Goal goal, Player player)
		{
			Width = width;
			Height = height;
            Goal = goal;
            Player = player;
		}

		public void draw()
		{
            Console.Clear();


            //  for (var row = 0; row < Height; row++)
            //    {
            //        for (var col = 0; col < Width; col++)
            //        {
            //            if (row == 0 || row == Height - 1 || col == 0 || col == Width - 1)
            //            {
            //                Console.Write(".");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }

        }

    }
}

