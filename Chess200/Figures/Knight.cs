namespace RunChess100;
class Knight
{
    public char chKnight = 'N';
    public const int knightPoint = 3;
    public Coordinates current;
    public FigureColor color;

    public Knight()
    {

    }
    //public Knight(FigureColor color)
    //{
    //    if (color == FigureColor.Black)
    //        Console.ForegroundColor = ConsoleColor.Black;
    //    else
    //        Console.ForegroundColor = ConsoleColor.White;
    //}
    /// <summary>
    /// Chekcks if Knight can go from source coordinate to destination coordinate.
    /// </summary>
    /// <param name="source">source coordinate</param>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    public bool CheckKnightCoord(Coordinates source, Coordinates destination)
    {
        int rowDifference = Math.Abs(destination.numberCoord - source.numberCoord);
        int columnDifference = Math.Abs(destination.letterCoord - source.letterCoord);
        //if (rowDifference == columnDifference) current = destination;

        return (rowDifference == 2 && columnDifference == 1) || (rowDifference == 1 && columnDifference == 2);
    }

    /// <summary>
    /// Chekcks if Knight can go from current coordinate to destination coordinate.
    /// </summary>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    //public bool CheckKnightCoord(Coordinates destination)
    //{
    //    int rowDifference = Math.Abs(destination.numberCoord - current.numberCoord);
    //    int columnDifference = Math.Abs(destination.letterCoord - current.letterCoord);
    //    if (rowDifference == columnDifference) current = destination;

    //    return rowDifference == columnDifference;
    //}
}

