using System;
using System.Numerics;
using DanteGame;


namespace DanteGame
{
    public class Game
    {


        public bool Running { get; private set; }

        public List<Map> maps { get; } = new List<Map>
        {
            new Map(40, 20, "Treachery"),
            new Map(40, 20, "Fraud"),
            new Map(40, 20, "Violence"),
            new Map(40, 20, "Heresy"),
            new Map(40, 20, "Wrath"),
            new Map(40, 20, "Greed"),
            new Map(40, 20, "Gluttony"),
            new Map(40, 20, "Lust"),
            new Map(40, 20, "Limbo"),
        };



        //public Bridge Treachery = new Bridge("Treachery");
        public Player player = new Player(20, 5);
        public Goal goal = new Goal(3, 10);

        public void Load()
        {
            player.X = 20;
            player.Y = 18;
            goal.X = 1;
            goal.Y = 20;
        }

        public int[,] bridgeCoords = new int[,] {
        {18, 20}, {18, 19}, {17, 19}, {16, 19}, {16, 18}, {16, 17}, {16, 16}, {16, 15}, {15, 15}, {14, 15},
        {14, 14}, {14, 13}, {15, 13}, {16, 13}, {16, 12}, {16, 11}, {16, 10}, {15, 10}, {14, 10}, {13, 10},
        {13, 9}, {13, 8}, {13, 7}, {14, 7}, {15, 7}, {16, 7}, {17, 7}, {17, 6}, {17, 5}, {17, 4}, {16, 4},
        {15, 4}, {14, 4}, {13, 4}, {13, 3}, {13, 2}, {12, 2}, {11, 2}, {11, 1}, {10, 1}, {9, 1}, {9, 2}, {9, 3},
        {9, 4}, {8, 4}, {7, 4}, {7, 5}, {7, 6}, {6, 6}, {5, 6}, {5, 5}, {5, 4}, {4, 4}, {3, 4}, {2, 4},{2, 5},
        {2, 6}, {2, 7}, {2, 8}, {2, 9}, {2, 10},{3, 10},{4, 10}, {4, 11 }, {4, 12}, {4, 13}, {4, 14}, {4, 15},
        {4, 16},{4, 17},{4, 18}, {4, 19}, {4, 20}, {3, 20}, {2, 20}

        };



        public void Draw(Map map)
        {
            Console.Clear();
            Console.WriteLine($" --- {map.Name} --- ");

            for (var row = 0; row < map.Height; row++)
            {
                for (var col = 0; col < map.Width; col++)
                {


                    bool isBridge = false;
                    for (var i = 0; i < bridgeCoords.GetLength(0); i++)
                    {
                        if (row == bridgeCoords[i, 0] && col == bridgeCoords[i, 1])
                        {
                            isBridge = true;
                            break;
                        }
                    }
                    if (isBridge && row == player.Y && col == player.X)
                    {
                        Console.Write("◊"); // print character if it's on a bridge tile
                    }
                    else if (isBridge)
                    {
                        Console.Write(" ");
                    }
                    else if (row == goal.X && col == goal.Y && col == player.X && row == player.Y)
                    {
                        map.Completed = true;

                    }
                    else if (!isBridge && row == player.Y && col == player.X)
                    {
                        Console.Write("X");
                        Load();
                    }

                    else if (row == 0 || row == map.Height - 1 || col == 0 || col == map.Width - 1)
                    {
                        Console.Write(".");
                    }
                    else if (col == player.X && row == player.Y)
                    {
                        Console.Write("◊");

                    }
                    else if (row == goal.X && col == goal.Y)
                    {
                        Console.Write($"-");
                    }
                    else
                    {
                        Console.Write("o");

                    }
                }

                Console.WriteLine();
            }
        }

            public void Update(Map map)
            {


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

            public void StartLevel(Map map)
            {

                while (!map.Completed)
                {
                    Update(map);
                    Draw(map);
                }
                
            }

            public void Run()
            {
                Running = true;

                int level = 1;

            while (Running)
            {
                Console.WriteLine("Welcome to hell, Dante! Use the arrows to start climbing. Beware of the flames!");
                Console.WriteLine("Dante = '◊'");
                Console.WriteLine("Way out = '-'");

                while (level < 9)
                {
                    foreach (var map in maps)
                    {
                        Load();
                        StartLevel(map);
                        level++;
                    }
                }
                Console.Clear();
                Console.WriteLine("Congratulations, you beat hell!");
                Running = false;
                }
            }
    }
}
