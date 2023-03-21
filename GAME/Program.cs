using Game;

//player and goal are assigned coordinates, map is assigned height and width as well as which objects to draw

var dante = new Player(20, 10);
var door = new Goal(3, 10, "_", false);
var limbo = new Map(40, 20, door, dante);
var lust = new Map(60, 30, door, dante);


while (true){

    if (!limbo.Completed)
    {
        lust.draw(limbo, dante, door);
        break;
    }
    else if (limbo.Completed)
    {

        lust.draw(lust, dante, door);

    }
}
