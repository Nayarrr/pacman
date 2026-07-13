public class Pacman : Character
{
    int score;   
    public Pacman(string name, int speed, int x, int y) : base(name, speed, x, y)
    {
        this.score = 0;
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

    public void Eat(CaseType food)
    {
        switch (food)
        {
            case CaseType.PacDot:
                score++;
                break;
            case CaseType.PowerPellet:
                score += 5;
                break;
            default:
                Console.WriteLine("Fonction eat ne prend que ce qu'il y'a a manger !");
                break;
        }
    }


}