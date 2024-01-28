using RunChess100;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace RunChess100;

internal class Game2Validation
{

    public bool Valid(Coordinates queenCurrent, Coordinates rook1Current, Coordinates rook2Current,
        Coordinates kingBCurrent, Coordinates kingWCurrent)
    {
        Rook rook1 = new Rook();
        Rook rook2 = new Rook();
        King kingW = new King();
        King kingB = new King();
        Queen queen = new Queen();
        for (int i=--kingWCurrent.numberCoord; i<=++kingWCurrent.numberCoord; i++)
            for(char j=--kingWCurrent.letterCoord; j<= ++kingWCurrent.letterCoord; j++)
            {
                Coordinates cord = new Coordinates();
                cord.numberCoord = i;
                cord.letterCoord = j;
                if(i!=0 && j!=0 && (queen.CheckQueenCoord(queenCurrent, cord)!=true || rook1.CheckRookCoord(rook1Current, cord) != true
                || rook2.CheckRookCoord(rook2Current, cord) != true || kingB.CheckKingCoord(kingBCurrent, cord) != true))
                {
                    return true;
                }

            }
        return false;
    }
    public void Validate()
    { 

        Game2Board chess = new Game2Board();
        Rook rook1 = new Rook();
        Rook rook2 = new Rook();
        King kingW = new King();
        King kingB = new King();
        Queen queen = new Queen();


        bool isValid1 = true;
        do
        {
            if(isValid1!=true) Console.WriteLine("invalid input!");
            Console.WriteLine();
            Console.Write("Enter Black Queen's coordinate: ");
            queen.current = new Coordinates(Console.ReadLine());
            Console.Write("Enter First BLack Rook's coordinate: ");
            rook1.current = new Coordinates(Console.ReadLine());
            Console.Write("Enter Second Black Rook's coordinate: ");
            rook2.current = new Coordinates(Console.ReadLine());
            Console.Write("Enter Black King's coordinate: ");
            kingB.current = new Coordinates(Console.ReadLine());
            Console.Write("Enter White King's coordinate: ");
            kingW.current = new Coordinates(Console.ReadLine());

            
            if (queen.CheckQueenCoord(queen.current, kingW.current) || rook1.CheckRookCoord(rook1.current, kingW.current)
                || rook2.CheckRookCoord(rook2.current, kingW.current) || kingB.CheckKingCoord(kingB.current, kingW.current))
            {
                isValid1 = false;
            }
            else if(Valid(queen.current, rook1.current, rook2.current, kingB.current, kingW.current)!=true)
            {
                isValid1 = false;
            }
            else isValid1 = true;


        } while (isValid1 == false);

        chess.PrintBoard(queen.current, rook1.current, rook2.current, kingB.current, kingW.current);
    }
}


//if (queen.current.letterCoord == rook1.current.letterCoord || queen.current.letterCoord == rook2.current.letterCoord ||
//                queen.current.letterCoord == kingB.current.letterCoord || queen.current.letterCoord == kingW.current.letterCoord)
//            {
//                isValid = false;
//            }
//            else if (rook1.current.letterCoord == rook2.current.letterCoord || rook1.current.letterCoord == kingB.current.letterCoord
//                        || rook1.current.letterCoord == kingW.current.letterCoord)
//{
//    isValid = false;
//}
//else if (rook2.current.letterCoord == kingB.current.letterCoord || rook2.current.letterCoord == kingW.current.letterCoord)
//{
//    isValid = false;
//}
//else if (kingB.current.letterCoord == kingW.current.letterCoord)
//{
//    isValid = false;
//}
//else { isValid = true; }
//if (queen.current.numberCoord == rook1.current.numberCoord || queen.current.numberCoord == rook2.current.numberCoord ||
//queen.current.numberCoord == kingB.current.numberCoord || queen.current.numberCoord == kingW.current.numberCoord)
//{
//    isValid = false;
//}
//else if (rook1.current.numberCoord == rook2.current.numberCoord || rook1.current.numberCoord == kingB.current.numberCoord
//            || rook1.current.numberCoord == kingW.current.numberCoord)
//{
//    isValid = false;
//}
//else if (rook2.current.numberCoord == kingB.current.numberCoord || rook2.current.numberCoord == kingW.current.numberCoord)
//{
//    isValid = false;
//}
//else if (kingB.current.numberCoord == kingW.current.numberCoord)
//{
//    isValid = false;
//}
//else { isValid = true; }