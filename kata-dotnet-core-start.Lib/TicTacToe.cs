namespace kata_dotnet_core_start.Lib;
public class TicTacToe
{
    public static bool ValidateInput(int value)
    {
        if (value >= 1 && value <= 9)
            return true;
        return false;
    }
}
