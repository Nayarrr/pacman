public class Character
{
    public required string name;
    public double speed;

    public Way way;

    public Character(string name, double speed, Way way)
    {
        this.name = name;
        this.speed = speed;
        this.way = way;
    }

}