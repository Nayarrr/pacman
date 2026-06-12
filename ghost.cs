public class Ghost : Character
{
    private static readonly Random rnd = new Random();
    public Ghost(string name, double speed, Way way, int x, int y) : base(name, speed, way, x, y)
    {
        
    }

    public override void Move(Way way)
    {
        
    }

    private Way RandomizeWay()
    {
        int way = rnd.Next(1,5);
        return (Way) way;
    }

}