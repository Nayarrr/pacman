public class Pacman : Character
{
    public Pacman(string name, int speed, int x, int y) : base(name, speed, x, y)
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