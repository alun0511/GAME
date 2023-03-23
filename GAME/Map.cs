using System;
namespace DanteGame
{
    public class Map
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        //public Bridge Bridge { get; }


        public Map(
            int width,
            int height,
            string name
            //Bridge bridge
            )
        {
            Width = width;
            Height = height;
            Name = name;
            //Bridge = bridge;

        }

        public int[,] Coordinates(string Name)
        {
            return new int[,]{
            {18, 20}, {18, 19}, {17, 19}, {16, 19}, {16, 18}, {16, 17}, {16, 16}, {16, 15}, {15, 15}, {14, 15},
            {14, 14}, {14, 13}, {15, 13}, {16, 13}, {16, 12}, {16, 11}, {16, 10}, {15, 10}, {14, 10}, {13, 10},
            {13, 9}, {13, 8}, {13, 7}, {14, 7}, {15, 7}, {16, 7}, {17, 7}, {17, 6}, {17, 5}, {17, 4}, {16, 4},
            {15, 4}, {14, 4}, {13, 4}, {13, 3}, {13, 2}, {12, 2}, {11, 2}, {11, 1}, {10, 1}, {9, 1}, {9, 2}, {9, 3},
            {9, 4}, {8, 4}, {7, 4}, {7, 5}, {7, 6}, {6, 6}, {5, 6}, {5, 5}, {5, 4}, {4, 4}, {3, 4}, {2, 4},{2, 5},
            {2, 6}, {2, 7}, {2, 8}, {2, 9}, {2, 10},{3, 10},{4, 10}, {4, 11 }, {4, 12}, {4, 13}, {4, 14}, {4, 15},
            {4, 16},{4, 17},{4, 18}, {4, 19}, {4, 20}, {3, 20}, {2, 20}
        };
        }

    }
}
