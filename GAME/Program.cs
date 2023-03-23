using System.Numerics;
using DanteGame;


Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkRed;


var game = new Game();

Console.WriteLine("Welcome to hell, Dante!");
Console.WriteLine("Use the arrows to start climbing. Beware of the flames!");
Console.WriteLine("Dante = '◊'");
Console.WriteLine("Way out = '-'");

var input = Console.ReadKey(true).Key;

if (ConsoleKey.LeftArrow == input ||
    ConsoleKey.RightArrow == input ||
    ConsoleKey.UpArrow == input ||
    ConsoleKey.DownArrow == input)
{
    game.Run();
}








