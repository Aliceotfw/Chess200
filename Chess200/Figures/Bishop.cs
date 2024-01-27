using System.Drawing;

namespace RunChess100;

class Bishop
{
    public char ch = 'B';

    public const int bishopPoint = 3;
    public Coordinates current;
    public FigureColor color;
    //guyn, qash, skzbnakanCoord/yntacik, sharjvelubool, boardivratabool

    public Bishop()
    {

    }
    //public Bishop(FigureColor color)
    //{
    //    if(color==FigureColor.Black) 
    //        Console.ForegroundColor = ConsoleColor.Black;
    //    else
    //        Console.ForegroundColor = ConsoleColor.White;
    //}
    /// <summary>
    /// Chekcks if Bishop can go from source coordinate to destination coordinate.
    /// </summary>
    /// <param name="source">source coordinate</param>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    public bool CheckBishopCoord(Coordinates source, Coordinates destination)
    {
        int rowDifference = Math.Abs(destination.numberCoord - source.numberCoord);
        int columnDifference = Math.Abs(destination.letterCoord - source.letterCoord);
        //if (rowDifference == columnDifference) current = destination;

        return rowDifference == columnDifference;
    }
    /// <summary>
    /// Chekcks if Bishop can go from current coordinate to destination coordinate.
    /// </summary>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    //    public bool CheckBishopCoord(Coordinates destination)
    //    {
    //        int rowDifference = Math.Abs(destination.numberCoord - current.numberCoord);
    //        int columnDifference = Math.Abs(destination.letterCoord - current.letterCoord);
    //        if (rowDifference == columnDifference) current = destination;

    //        return rowDifference == columnDifference;
    //    }

}
