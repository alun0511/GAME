using System;
namespace DanteGame
{
    public class Map
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        //public Goal Goal { get; set; }
        //public Player Player { get; set; }
        public bool Completed { get; set; }

        public Map(
            int width,
            int height,
            string name
            //Goal goal,
            //Player player
            )
        {
            Width = width;
            Height = height;
            Name = name;
            //Goal = goal;
            //Player = player;
        }

    }
}
