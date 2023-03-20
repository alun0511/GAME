// create two players
var megatron = new Robot("Megatron", 10);
var optimus = new Robot("Optimus Prime", 10);

// create the game
var game = new RobotFightingGame(megatron, optimus);

// play the game until someone wins
while (!game.GameOver)
{
    game.NextRound();
}

if (game.Winner == null)
{
    Console.WriteLine("The game ends in a draw! What a disappointment!");
}
else
{
    Console.WriteLine($"{game.Winner} is the winner!");
}
class Robot
{
    public string Name { get; }
    public int Health { get; set; }

    public Robot(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(Robot robot)
    {
        var hp = robot.Health;
        var damage = Die.Roll();
        robot.Health = hp - damage;
        Console.WriteLine($"{Name} attacks {robot.Name} with {damage} damage");
    }

}

static class Die
{
    static readonly Random _random = new();
    public static int Roll() => _random.Next(1, 7);
}

class RobotFightingGame
{
    public Robot Robot1 { get; }
    public Robot Robot2 { get; }
    public bool GameOver { get; set; }
    public string Winner { get; set; }

    public RobotFightingGame(Robot robot1, Robot robot2)
    {
        Robot1 = robot1;
        Robot2 = robot2;
        GameOver = false;
    }

    public void NextRound()
    {

        if (Robot1.Health != 0 && Robot2.Health != 0)
        {
            Robot1.Attack(Robot2);
            Robot2.Attack(Robot1);
        }
        else if (Robot1.Health == 0 && Robot2.Health == 0)
        {
            GameOver = true;
            Winner = null;
        }
        else if (Robot1.Health == 0 || Robot2.Health == 0)
        {

            GameOver = true;

            if (Robot1.Health == 0)
            {
                Winner = Robot2.Name;
            }
            if (Robot2.Health == 0)
            {
                Winner = Robot1.Name;
            }

        }

    }

}