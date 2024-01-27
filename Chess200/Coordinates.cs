using System.Transactions;

namespace RunChess100;

struct Coordinates
{
    public char letterCoord;
    public int numberCoord;
    /// <summary>
    /// Imput coordinate
    /// </summary>
    /// <param name="inputCoordinates"></param>
    public Coordinates(string? inputCoordinates)
    {
        inputCoordinates = inputCoordinates.ToUpper(); ;
        //if(inputCoordinates[0] >= 'A' && inputCoordinates[0] <= 'H' && inputCoordinates[1] >= 1 && inputCoordinates[1] <= 8)
        //{
        char.TryParse(inputCoordinates[0].ToString(), out letterCoord);
        int.TryParse(inputCoordinates[1].ToString(), out numberCoord);
        //}

    }
}