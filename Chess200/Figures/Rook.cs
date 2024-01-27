namespace RunChess100;

class Rook
{
    public char ch = 'R';
    public const int rookPoint = 5;
    public Coordinates current;
    public FigureColor color;
    public Rook()
    {

    }
    //public Rook(FigureColor color)
    //{
    //    if (color == FigureColor.Black)
    //        Console.ForegroundColor = ConsoleColor.Black;
    //    else
    //        Console.ForegroundColor = ConsoleColor.White;
    //}
    /// <summary>
    /// Chekcks if Rook can go from source coordinate to destination coordinate.
    /// </summary>
    /// <param name="source">source coordinate</param>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    public bool CheckRookCoord(Coordinates source, Coordinates destination)
    {
        int rowDifference = Math.Abs(destination.numberCoord - source.numberCoord);
        int columnDifference = Math.Abs(destination.letterCoord - source.letterCoord);
        //if (rowDifference == columnDifference) current = destination;

        return (rowDifference == 0 && columnDifference != 0) || (rowDifference != 0 && columnDifference == 0);
    }

    /// <summary>
    /// Chekcks if Rook can go from current coordinate to destination coordinate.
    /// </summary>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    //public bool CheckRookCoord(Coordinates destination)
    //{
    //    int rowDifference = Math.Abs(destination.numberCoord - current.numberCoord);
    //    int columnDifference = Math.Abs(destination.letterCoord - current.letterCoord);
    //    if (rowDifference == columnDifference) current = destination;

    //    return rowDifference == columnDifference;
    //}
}