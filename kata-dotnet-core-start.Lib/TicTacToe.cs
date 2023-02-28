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
        {
            if (ReturnValue(1) == ReturnValue(2) && ReturnValue(2) == ReturnValue(3))
                return true;
        }
        else if (board.ContainsKey(4) && board.ContainsKey(5) && board.ContainsKey(6))
        {
            if (ReturnValue(4) == ReturnValue(5) && ReturnValue(5) == ReturnValue(6))
                return true;
        }
        else if (board.ContainsKey(7) && board.ContainsKey(8) && board.ContainsKey(9))
        {
            if (ReturnValue(7) == ReturnValue(8) && ReturnValue(8) == ReturnValue(9))
                return true;
        }
        else if (board.ContainsKey(1) && board.ContainsKey(4) && board.ContainsKey(7))
        {
            if (ReturnValue(1) == ReturnValue(4) && ReturnValue(4) == ReturnValue(7))
                return true;
        }
        else if (board.ContainsKey(2) && board.ContainsKey(5) && board.ContainsKey(8))
        {
            if (ReturnValue(2) == ReturnValue(5) && ReturnValue(5) == ReturnValue(8))
                return true;
        }
        else if (board.ContainsKey(3) && board.ContainsKey(6) && board.ContainsKey(9))
        {
            if (ReturnValue(3) == ReturnValue(6) && ReturnValue(6) == ReturnValue(9))
                return true;
        }
        else if (board.ContainsKey(1) && board.ContainsKey(5) && board.ContainsKey(9))
        {
            if (ReturnValue(1) == ReturnValue(5) && ReturnValue(5) == ReturnValue(9))
                return true;
        }
        else if (board.ContainsKey(3) && board.ContainsKey(5) && board.ContainsKey(7))
        {
            if (ReturnValue(3) == ReturnValue(5) && ReturnValue(5) == ReturnValue(7))
                return true;
        }
        return false;

        char ReturnValue(int key)
        {
            char result;
            board.TryGetValue(1, out result);
            return result;
        }
    }
}
