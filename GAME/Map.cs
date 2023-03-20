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

        public void draw()
        {
            Console.Clear();

            while (true)
            {
                Console.Clear(); // clear the console before drawing the character
                Completed = false;

                for (var row = 0; row < Height; row++)
                {
                    for (var col = 0; col < Width; col++)
                    {
                        if (row == Goal.X && col == Goal.Y && col == Player.X && row == Player.Y)
                        {
                            Console.WriteLine($"You went through the {Goal.Display}");
                            Completed = true;
                        }



                        if (row == 0 || row == Height - 1 || col == 0 || col == Width - 1)
                        {
                            Console.Write(".");
                        }
                        else if (col == Player.X && row == Player.Y)
                        {
                            Console.Write("*");
                        }
                        else if (row == Goal.X && col == Goal.Y)
                        {
                            Console.Write($"{Goal.Display}");
                        }

                        else
                        {
                            Console.Write(" ");
                        }

                            //    // read user input and update character position
                            var input = Console.ReadKey(true).Key;
                            switch (input)
                            {
                                case ConsoleKey.LeftArrow:
                                    if (Player.X > 1) Player.X--;
                                    break;
                                case ConsoleKey.RightArrow:
                                    if (Player.X < Width - 2) Player.X++;
                                    break;
                                case ConsoleKey.UpArrow:
                                    if (Player.Y > 1) Player.Y--;
                                    break;
                                case ConsoleKey.DownArrow:
                                    if (Player.Y < Height - 2) Player.Y++;
                                    break;
                            }

                    }
                    Console.WriteLine();
                }

            }

        }
    }
}
