namespace RunChess100;


class King
{
    public char ch = 'K';
    //public const int kingPoint = ;
    public Coordinates current;
    public FigureColor color;

    public King()
    {

    }

    /// <summary>
    /// Chekcks if King can go from source coordinate to destination coordinate.
    /// </summary>
    /// <param name="source">source coordinate</param>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    public bool CheckKingCoord(Coordinates source, Coordinates destination)
    {
        int rowDifference = Math.Abs(destination.numberCoord - source.numberCoord);
        int columnDifference = Math.Abs(destination.letterCoord - source.letterCoord);

        return (rowDifference <= 1 && columnDifference == 1) || (rowDifference == 1 && columnDifference <= 1);
    }

    /// <summary>
    /// Chekcks if King can go from current coordinate to destination coordinate.
    /// </summary>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    //    public bool CheckKingCoord(Coordinates destination)
    //    {
    //        int rowDifference = Math.Abs(destination.numberCoord - current.numberCoord);
    //        int columnDifference = Math.Abs(destination.letterCoord - current.letterCoord);
    //        if (rowDifference == columnDifference) current = destination;

    //        return rowDifference == columnDifference;
    //    }
}

