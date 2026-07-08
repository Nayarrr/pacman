public class Ghost : Character
{
    private static readonly Random rnd = new Random();

    public Ghost(string name, double speed, Way way, int x, int y) : base(name, speed, x, y)
    {
        
    }

    public override void Move(Way way)
    {
        way = RandomizeWay();
        switch (way)
        {
            case Way.North:
                y --;
                break;
            case Way.South:
                y ++;
                break;
            case Way.East:
                x ++;
                break;
            case Way.West:
                x --;
                break;
        }
    }

    private Way RandomizeWay()
    {
        int way = rnd.Next(1,5);
        return (Way) way;
    }

}