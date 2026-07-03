public class PacmanGame
{
    CaseType[,] GameGrille = new CaseType[31,31];

    public PacmanGame()
    {
        //Contour
        for (int j = 0; j < GameGrille.GetLength(1); j++)
        {
            GameGrille[0,j] = CaseType.Wall;
            GameGrille[GameGrille.GetLength(0) - 1, j] = CaseType.Wall;
        }
        
        //Contour
        for (int i = 0; i < GameGrille.GetLength(0); i++)
        {
            GameGrille[i,0] = CaseType.Wall;
            GameGrille[i, GameGrille.GetLength(1) - 1] = CaseType.Wall;
        }

        //Rectangle plein haut
        for (int i = 0; i < GameGrille.GetLength(0)/6; i++)
        {
            GameGrille[i,GameGrille.GetLength(1)/2] = CaseType.Wall;
            GameGrille[i,(GameGrille.GetLength(1)/2)-1] = CaseType.Wall;
            GameGrille[i,(GameGrille.GetLength(1)/2)+1] = CaseType.Wall;
        }

        //Rectangle plein bas
        for (int i = GameGrille.GetLength(0) - 1; i > GameGrille.GetLength(0) - GameGrille.GetLength(0)/6; i--)
        {
            GameGrille[i,GameGrille.GetLength(1)/2] = CaseType.Wall;
            GameGrille[i,(GameGrille.GetLength(1)/2)-1] = CaseType.Wall;
            GameGrille[i,(GameGrille.GetLength(1)/2)+1] = CaseType.Wall;
        }

        //Rectangle vide gauche
        for (int j = 0; j < GameGrille.GetLength(1)/6; j++)
        {
            GameGrille[GameGrille.GetLength(0)/3, j] = CaseType.Wall;
            GameGrille[GameGrille.GetLength(0) - GameGrille.GetLength(0)/3, j] = CaseType.Wall;
        }

        //Rectangle vide droit
        for (int j = GameGrille.GetLength(1) - 1; j > GameGrille.GetLength(1) - GameGrille.GetLength(1)/6 - 1; j--)
        {
            GameGrille[GameGrille.GetLength(0)/3, j] = CaseType.Wall;
            GameGrille[GameGrille.GetLength(0) - GameGrille.GetLength(0)/3, j] = CaseType.Wall;
        }

        for (int i = GameGrille.GetLength(0)/3 ; i < GameGrille.GetLength(0) - GameGrille.GetLength(0)/3 + 1; i++)
        {
            GameGrille[i, GameGrille.GetLength(1)/6] = CaseType.Wall;
            GameGrille[i, GameGrille.GetLength(1) - GameGrille.GetLength(1)/6 - 1] = CaseType.Wall;
        }

        for (int j = GameGrille.GetLength(1)/2 - 3; j < GameGrille.GetLength(1)/2 + 3; j++)
        {
            GameGrille[GameGrille.GetLength(0)/3 + 2, j] = CaseType.Wall;
            GameGrille[GameGrille.GetLength(0) - GameGrille.GetLength(0)/3 - 2, j] = CaseType.Wall;
        }

        for (int i = GameGrille.GetLength(0)/3 + 2; i < GameGrille.GetLength(0) - GameGrille.GetLength(0)/3 - 2; i++)
        {
            GameGrille[i, 12] = CaseType.Wall;
            GameGrille[i, 17] = CaseType.Wall;
        }
    }

    public void ShowGame()
    {
        for (int i = 0; i < GameGrille.GetLength(0); i++)
        {
            Console.Write("\n");
            for (int j = 0; j < GameGrille.GetLength(1); j++)
            {
                if(GameGrille[i,j] == CaseType.Wall)
                {
                    Console.Write("■ ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
        }
        Console.Write("\n");
    }
    
    public bool IsPositionValid(int x, int y)
    {
        if (GameGrille[x,y] == CaseType.Wall)
        {
            return false; 
        }
        else
        {
            return true;
        }
    }

    
}       