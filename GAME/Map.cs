using System;
namespace Game
{
    public class Map
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public Goal Goal { get; set; }
        public Player Player { get; set; }
        public bool Completed { get; set; }

        public Map(int width, int height, Goal goal, Player player)
        {
            Width = width;
            Height = height;
            Goal = goal;
            Player = player;
        }

        public void draw(Map map, Player player, Goal goal)
        {
            while (!goal.Completed)
            {
                Console.Clear(); // clear the console before drawing the character

                for (var row = 0; row < map.Height; row++)
                {
                    for (var col = 0; col < map.Width; col++)
                    {
                        if (row == goal.X && col == goal.Y && col == player.X && row == player.Y)
                        {
                            goal.Completed = true;
                        }


                        if (row == 0 || row == map.Height - 1 || col == 0 || col == map.Width - 1)
                        {
                            Console.Write(".");
                        }
                        else if (col == player.X && row == player.Y)
                        {
                            Console.Write("*");
                        }
                        else if (row == goal.X && col == goal.Y)
                        {
                            Console.Write($"{goal.Display}");
                        }

                        else
                        {
                            Console.Write(" ");

                        }

                    }

                     Console.WriteLine();
                }

                //    // read user input and update character position

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.LeftArrow:
                        if (player.X > 1) player.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (player.X < map.Width - 2) player.X++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (player.Y > 1) player.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (player.Y < map.Height - 2) player.Y++;
                        break;
                }

            }

        }
    }
}
