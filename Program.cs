Console.Clear();
Console.CursorVisible = false;

PacmanGame game = new PacmanGame();

game.ShowGame();

Pacman pacman = new Pacman("Nayarr", 1, 2, 2);

if (Console.KeyAvailable)
{
    ConsoleKeyInfo touche = Console.ReadKey(true);
    
    switch (touche.Key)
    {
        case ConsoleKey.LeftArrow:
            pacman.Move(Way.West);
            break;
        case ConsoleKey.RightArrow:
            pacman.Move(Way.East);
            break;
        case ConsoleKey.UpArrow:
            pacman.Move(Way.North);
            break;
        case ConsoleKey.DownArrow:
            pacman.Move(Way.South);
            break;
    }
}