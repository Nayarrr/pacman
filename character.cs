public class Character
{
    public required string name;
    public double speed;

    public Way way;

    public int x;

    public int y;

    public Character(string name, double speed, Way way, int x, int y)
    {
        this.name = name;
        this.speed = speed;
        this.way = way;
        this.x = x;
        this.y = y;
    }

    public virtual void Move()
    {
        
    }

}