namespace kata_dotnet_core_start.Lib;
public class TicTacToe
{
    public static Dictionary<int,char> board = new Dictionary<int,char>();
    public static bool ValidateInput(int value)
    {
        if (value >= 1 && value <= 9)
            return true;
        return false;
    }
    public static bool GameOver()
    {
        if (board.Count == 9)
            return true;
        return false;
    }
}
