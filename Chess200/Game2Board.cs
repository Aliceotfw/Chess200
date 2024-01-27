using System.Data.Common;

namespace RunChess100;

internal class Game2Board
{
    public void PrintBoard(Coordinates queenCurrent, Coordinates rook1Current, Coordinates rook2Current,
        Coordinates kingBCurrent, Coordinates kingWCurrent)
    {
        Rook rook1 = new Rook();
        Rook rook2 = new Rook();
        King kingW = new King();
        King kingB = new King();
        Queen queen = new Queen();

        queen.color = FigureColor.Black;
        rook1.color = FigureColor.Black;
        rook2.color = FigureColor.Black;
        kingW.color = FigureColor.White;
        kingB.color = FigureColor.Black;

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
                if (i == queenCurrent.numberCoord && j == queenCurrent.letterCoord)
                {
                    if (queen.color == FigureColor.Black) Console.ForegroundColor = ConsoleColor.Black;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + queen.ch + " ");
                }
                else if (i == rook1Current.numberCoord && j == rook1Current.letterCoord)
                {
                    if (rook1.color == FigureColor.Black) Console.ForegroundColor = ConsoleColor.Black;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + rook1.ch + " ");
                }
                else if (i == rook2Current.numberCoord && j == rook2Current.letterCoord)
                {
                    if (rook2.color == FigureColor.Black) Console.ForegroundColor = ConsoleColor.Black;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + rook2.ch + " "); ;
                }
                else if (i == kingBCurrent.numberCoord && j == kingBCurrent.letterCoord)
                {
                    if (kingB.color == FigureColor.Black) Console.ForegroundColor = ConsoleColor.Black;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + kingB.ch + " ");
                }
                else if (i == kingWCurrent.numberCoord && j == kingWCurrent.letterCoord)
                {
                    if (kingW.color == FigureColor.Black) Console.ForegroundColor = ConsoleColor.Black;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + kingW.ch + " ");
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

        Game2 game = new Game2();
        game.Game(queenCurrent, rook1Current, rook2Current, kingBCurrent, kingWCurrent);
    }
}

