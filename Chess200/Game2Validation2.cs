namespace RunChess100;

internal class Game2Validation2
{
    public void Validate(Coordinates queenCurrent, Coordinates rook1Current, Coordinates rook2Current,
        Coordinates kingBCurrent, Coordinates kingWCurrent)
    {
        Game2Board chess = new Game2Board();
        chess.PrintBoard(queenCurrent, rook1Current, rook2Current,
        kingBCurrent, kingWCurrent);
    }
}
