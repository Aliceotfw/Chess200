
using RunChess100;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Transactions;

internal class Game2
{
    /// <summary>
    /// Show in main
    /// </summary>
    public void Game(Coordinates queenCurrent, Coordinates rook1Current, Coordinates rook2Current,
        Coordinates kingBCurrent, Coordinates kingWCurrent)
    {
        Rook rook1 = new Rook();
        Rook rook2 = new Rook();
        King kingW = new King();
        King kingB = new King();
        Queen queen = new Queen();

        bool isValid = true;
        var c = kingWCurrent;
        do
        {
            Console.WriteLine();
            if (isValid == false)
                Console.WriteLine("Invalid coord, Enter White King's coordinate: ");
            else
                Console.Write("Enter White King's coordinate: ");
            kingWCurrent = new Coordinates(Console.ReadLine());
            if (kingW.CheckKingCoord(c, kingWCurrent) == false)
            {
                isValid = false;
            }
            else if (kingW.CheckKingCoord(kingWCurrent, kingBCurrent) || queen.CheckQueenCoord(queenCurrent, kingWCurrent) ||
                rook1.CheckRookCoord(rook1Current, kingWCurrent) || rook2.CheckRookCoord(rook2Current, kingWCurrent))
            {
                isValid = false;
            }
            else isValid = true;

        } while (isValid == false);


        bool isValid1 = true;
        int rowking = kingWCurrent.numberCoord;
        if (rowking == queenCurrent.numberCoord + 1 && rowking == rook1Current.numberCoord - 1 && rook2Current.numberCoord == rowking)
        {
            isValid1 = false;
        }
        else if (rowking == queenCurrent.numberCoord + 1 && rowking == rook1Current.numberCoord - 1)
        {
            rook2Current.numberCoord = rowking;
        }
        else if (rowking == queenCurrent.numberCoord + 1 && rowking != 8)
        {
            rook1Current.numberCoord = rowking + 1;
        }
        else if (rowking != 8)
        {
            queenCurrent.numberCoord = rowking - 1;
        }

        if (isValid1 == true)
        {
            Game2Validation2 main02 = new Game2Validation2();
            main02.Validate(queenCurrent, rook1Current, rook2Current, kingBCurrent, kingWCurrent);
        }
        else
        {
            Console.WriteLine();
            Console.Write("oops, you lose the game!");
        }

    }
}
//if (rowking == queenCurrent.numberCoord + 1 && rowking!=8)
//{
//    rook1Current.numberCoord = rowking + 1;
//}   
//else if(rowking == queenCurrent.numberCoord - 1 && rowking != 1)
//{
//    rook1Current.numberCoord = rowking - 1;
//}
//else if(rowking == rook1Current.numberCoord + 1 && rowking != 8)
//{
//    rook2Current.numberCoord = rowking + 1;
//}
//else if (rowking == rook1Current.numberCoord - 1 && rowking != 1)
//{
//    rook2Current.numberCoord = rowking - 1;
//}
//else if (rowking == rook2Current.numberCoord + 1 && rowking != 8)
//{
//    rook1Current.numberCoord = rowking + 1;
//}
//else if (rowking == rook2Current.numberCoord - 1 && rowking != 1)
//{
//    rook1Current.numberCoord = rowking - 1;
//}