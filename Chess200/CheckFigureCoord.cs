namespace RunChess100;
class CheckFigureCoord
{
    /// <summary>
    /// Show in main
    /// </summary>
    public void ShowInConsole()
    {
        Board chess = new Board();
        Knight knight = new Knight();
        Rook rook = new Rook();
        King king = new King();
        Bishop bishop = new Bishop();
        Queen queen = new Queen();

        Console.Write("Enter Figure name: ");
        string figureName = Console.ReadLine();
        figureName = figureName.ToUpper();

        Console.Write("Enter coordinate1: ");
        Coordinates source = new Coordinates(Console.ReadLine());
        Console.Write("Enter coordinate2: ");
        Coordinates destination = new Coordinates(Console.ReadLine());


        chess.PrintBoard(source.letterCoord, source.numberCoord, figureName);
        Console.WriteLine();

        bool isValidMove = false;
        switch (figureName)
        {
            case "ROOK":
                Console.WriteLine(rook.CheckRookCoord(source, destination));
                isValidMove = rook.CheckRookCoord(source, destination);
                break;
            case "KNIGHT":
                Console.WriteLine(knight.CheckKnightCoord(source, destination));
                isValidMove = knight.CheckKnightCoord(source, destination);
                break;
            case "BISHOP":
                Console.WriteLine(bishop.CheckBishopCoord(source, destination));
                isValidMove = bishop.CheckBishopCoord(source, destination);
                break;
            case "QUEEN":
                Console.WriteLine(queen.CheckQueenCoord(source, destination));
                isValidMove = queen.CheckQueenCoord(source, destination);
                break;
            case "KING":
                Console.WriteLine(king.CheckKingCoord(source, destination));
                isValidMove = king.CheckKingCoord(source, destination);
                break;
        }
        if (isValidMove) chess.PrintBoard(destination.letterCoord, destination.numberCoord, figureName);
    }
}

