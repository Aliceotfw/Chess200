namespace RunChess100;
class Queen
{
    public char ch = 'Q';
    public const int queenPoint = 9;
    public Coordinates current;
    public FigureColor color;
    public Queen()
    {

    }
    /// <summary>
    /// Chekcks if Queen can go from source coordinate to destination coordinate.
    /// </summary>
    /// <param name="source">source coordinate</param>
    /// <param name="destination">destination coordinate</param>
    /// <returns></returns>
    public bool CheckQueenCoord(Coordinates source, Coordinates destination)
    {
        int rowDifference = Math.Abs(destination.numberCoord - source.numberCoord);
        int columnDifference = Math.Abs(destination.letterCoord - source.letterCoord);

        return (rowDifference == columnDifference) || (columnDifference == 0) || (rowDifference == 0);
    }
}