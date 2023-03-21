using System;
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
        };

        public Player dante = new Player(20, 5);
        public Goal door = new Goal(3, 10);

        public void Load()
        {
            dante.X = 20;
            dante.Y = 18;
            door.X = 3;
            door.Y = 10;
        }

        public void Draw(Map map)
        {
            Console.Clear();
            Console.WriteLine($" --- {map.Name} --- ");

            for (var row = 0; row < map.Height; row++)
            {
                for (var col = 0; col < map.Width; col++)
                {
                    if (row == door.X && col == door.Y && col == dante.X && row == dante.Y)
                    {
                        map.Completed = true;
                    }

                    if (row == 0 || row == map.Height - 1 || col == 0 || col == map.Width - 1)
                    {
                        Console.Write(".");
                    }
                    else if (col == dante.X && row == dante.Y)
                    {
                        Console.Write("*");
                    }
                    else if (row == door.X && col == door.Y)
                    {
                        Console.Write("-");
                    }


                    else
                    {
                        Console.Write(" ");

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
                        if (dante.X > 1) dante.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (dante.X < map.Width - 2) dante.X++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (dante.Y > 1) dante.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (dante.Y < map.Height - 2) dante.Y++;
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
                Console.WriteLine("Dante = '*'");
                Console.WriteLine("Way out = '-'");

                while (level < 3)
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


// read user input and update character position


//public void draw(Map map, Player player, Goal goal)
//{




//    }