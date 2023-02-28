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
        else if (board.ContainsKey(1) && board.ContainsKey(2) && board.ContainsKey(3))
            return true;
        else if (board.ContainsKey(4) && board.ContainsKey(5) && board.ContainsKey(6))
            return true;
        else if (board.ContainsKey(7) && board.ContainsKey(8) && board.ContainsKey(9))
            return true;
        
        
        return false;
    }
}
