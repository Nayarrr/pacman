public class Character
{
    public string name;

    public double speed;

    public Way way;

    public int x;

    public int y;

    public Character(string name, double speed,int x, int y)
    {
        this.name = name;
        this.speed = speed;
        this.x = x;
        this.y = y;
    }

    public virtual void Move(Way way)
    {

    }

}