using System;
using System.Diagnostics;
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
            //new Map(40, 20, "Wrath"),
            //new Map(40, 20, "Greed"),
            //new Map(40, 20, "Gluttony"),
            //new Map(40, 20, "Lust"),
            //new Map(40, 20, "Limbo"),
        };

        public Player player = new Player(20, 5);
        public Goal goal = new Goal(3, 10);


        public void Load()
        {
            player.X = 20;
            player.Y = 18;
            goal.X = 1;
            goal.Y = 20;
        }

        int deathCount = 0;

        public void Draw(Map map)
        {
            
            var bridgeCoords = map.Coordinates(map.Name);

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
                        Console.Write("◊"); // Prints character if it's on a bridge tile.
                    }
                    else if (isBridge)
                    {
                        Console.Write(" "); // Prints bridge
                    }
                    else if (row == goal.X && col == goal.Y && col == player.X && row == player.Y)
                    {
                        map.Completed = true; // Evaluates if player has reached goal and completes map if true.

                    }
                    else if (!isBridge && row == player.Y && col == player.X)
                    {
                        Console.Write("X"); // Marks the where the player died, increments deathcounter and resets coordinates to start.
                        deathCount++;       
                        Load();
                    }

                    else if (row == 0 || row == map.Height - 1 || col == 0 || col == map.Width - 1)
                    {
                        Console.Write("."); // Prints borders.
                    }
                    else if (col == player.X && row == player.Y)
                    {
                        Console.Write("◊"); // Prints the player (Dante).

                    }
                    else if (row == goal.X && col == goal.Y)
                    {
                        Console.Write($"-"); // Prints the goal.
                    }
                    else
                    {
                        Console.Write("o"); // Prints "flames" of death.

                    }
                }
                Console.WriteLine();
                
            }
            Console.WriteLine($"Deathcount: {deathCount}");
        }

            public void Update(Map map)
            {
                // Update() is called on each level as long as the map isnt completed.
                // It updates the state of the map with the new player position given by the input of the player.

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
                // Starts the level, updates and draws the map.
                while (!map.Completed)
                {
                    Draw(map);
                    Update(map);
                }
                
            }

            public void Run()
            {
                // Final command to start the game.
                // Running is true until all maps have been completed.
                Running = true;

                DateTime TimeAtStart = DateTime.Now;

                int level = 1;

                while (Running)
                {

                    

                    while (level < 9)
                    {

                        foreach (var map in maps)
                        {
                            Load();
                            StartLevel(map);
                            level++;
                        }


                    }

                    DateTime TimeAtEnd = DateTime.Now;
                    TimeSpan GameTime = TimeAtEnd - TimeAtStart;

                    Console.Clear();
                    Running = false;
                    Console.WriteLine($"Congratulations, you beat hell in {GameTime.Hours} hours, {GameTime.Minutes} minutes, {GameTime.Seconds} seconds and {GameTime.Milliseconds} milliseconds!");
            }
        }
    }
}


