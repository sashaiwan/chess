using Chess.Piece;

class Program
{
    static void Main(string[] args)
    {
        Piece pawn = new Pawn("pawn", new int[] {0, 0});
        pawn.GetCoords();
        pawn.Move(new int[] { 0, 1});
        pawn.GetCoords();
        Console.ReadLine();
    }

    static void Draw()
    { 
        Console.SetCursorPosition(0, 0);
        Console.Write("╔");

    }

    static void Render()
    {
        int width = 20;
        string s = "╔";

        for (int i = 0; i < width; i++)
        {
            s += "══";

            if (i == width - 1)
            {
                s += "╗" + "\n";
            } else
            {
                s += "╦";
            }
        }

        for (int i = 0; i < width + 1; i++)
        {
            s += "║" + "  ";
        }

        s += "\n" + "╚";

        for (int i = 0; i < width; i++)
        {
            s += "══";

            if (i == width - 1)
            {
                s += "╝" + "\n";
            } else
            {
                s += "╩";
            }
        }

        Console.Write(s);
    }
};

class Board
{
    private int size;

    Board(int size)
    {
        this.size = size;
    }
}

