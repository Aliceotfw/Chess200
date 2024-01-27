
namespace RunChess100;

internal class ChooseGames
{
    public void ChooseGame()
    {
        bool isValidChoose = true;
        while (isValidChoose)
        {
            Console.WriteLine();
            Console.WriteLine("-Check Figure Coord/01");
            Console.WriteLine("-Queen Game/02");
            Console.Write("Choose game: ");
            string a = Console.ReadLine();
            switch (a)
            {
                case "01":
                    CheckFigureCoord main01 = new CheckFigureCoord();
                    main01.ShowInConsole();
                    isValidChoose = false;
                    break;
                case "02":
                    Game2Validation main02 = new Game2Validation();
                    main02.Validate();
                    isValidChoose = false;
                    break;
                default:
                    Console.WriteLine("invalid input, choose again!");
                    break;
            }
        }
    }
}
