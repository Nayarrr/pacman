public class Pacman : Character
{
    public Pacman(string name, int speed, Way way, int x, int y) : base(name, speed, way, x, y)
    {
        
    }

    public override void Move()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo touche = Console.ReadKey(true);
            switch (touche.Key)
            {
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
            }
        }
    }


}