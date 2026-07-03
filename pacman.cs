public class Pacman : Character
{
    public Pacman(string name, int speed, Way way, int x, int y) : base(name, speed, way, x, y)
    {
        
    }

    public override void Move(Way way)
    {
        switch (way)
        {
            case Way.North:
                y--;
                break;
            case Way.South:
                y++;
                break;
            case Way.East:
                x--;
                break;
            case Way.West:
                x++;
                break;
        }
    }


}