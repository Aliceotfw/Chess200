namespace RunChess100;

class Board
{
    /// <summary>
    /// Creating a chess board with figure.
    /// </summary>
    /// <param name="column">figure's coordinate for column</param>
    /// <param name="row">figure's coordinate for row</param>
    /// <param name="figure">figure name</param>
    public void PrintBoard(char column, int row, string figure)
    {
        char chFigure = Convert.ToChar(figure[0]);
        if (figure == "Knight")
            chFigure = 'N';
        char[] ch = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        Console.Write(" ");
        foreach (char ch2 in ch)
            Console.Write(" " + ch2 + " ");

        Console.WriteLine();

        for (int i = 1; i < 9; i++)
        {

            Console.Write(i);
            for (char j = 'A'; j <= 'H'; j++)
            {

                if ((i + (int)j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                if (i == row && j == column)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + chFigure + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("   ");
                }
                Console.ResetColor();

            }


            Console.Write(i);

            Console.WriteLine();
        }

        Console.Write(" ");
        foreach (char ch2 in ch)
            Console.Write(" " + ch2 + " ");
    }
}