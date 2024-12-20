using System.Numerics;

namespace ConnectFour.Test;

public class BoardTest
{
    [Fact]
    public void TestNothing()
    {
        Assert.Equal(2, 1 + 1);
    }

    [Fact]
    public void TestError()
    {
        var board = new Board();
        var player = Board.PLAYER_1;

        var exceptionNegativeNumber = Assert.Throws<ArgumentOutOfRangeException>(() => board.MakeMove(player, -1));
        Assert.Equal("Column is out of range. (Parameter 'column')", exceptionNegativeNumber.Message);
    }

    [Fact]
    public void Win()
    {
        var board = new Board();
        var player1 = Board.PLAYER_1;
        var player2 = Board.PLAYER_2;

        board.MakeMove(player1, 0);
        board.MakeMove(player2, 1);
        board.MakeMove(player1, 0);
        board.MakeMove(player2, 2);
        board.MakeMove(player1, 0);
        board.MakeMove(player2, 3);
        board.MakeMove(player1, 0);

        var winner = board.Winner(player1, 0, 0);

        Assert.Equal(player1, winner);
    }
}