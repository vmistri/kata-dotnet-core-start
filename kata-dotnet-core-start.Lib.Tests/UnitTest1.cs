namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(2)]
    [InlineData(9)]
    public void Given_valid_Input_When_ValidateInput_Then_Accept(int value)
    {
        // act
        var checkInput = TicTacToe.ValidateInput(value);
        // assert
        Assert.Equal(checkInput,true);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-2)]
    [InlineData(10)]
    public void Given_Invalid_Input_When_ValidateInput_Then_Reject(int value)
    {
        // act
        var checkInput = TicTacToe.ValidateInput(value);
        // assert
        Assert.Equal(checkInput,false);
    }
    
    [Fact]
    public void when_All_Position_Is_Filled_Then_Game_Over()
    {
        // act
        for (int i = 0; i < 9; i++)
        {
            TicTacToe.board.Add(i+1,'X');
        }
        // assert
        Assert.Equal(TicTacToe.GameOver(),true);
    }
}