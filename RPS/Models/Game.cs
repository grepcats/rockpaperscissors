using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
  public class Game
  {
    private string _player1;
    private string _player2;
    private string _winner;

    public Game(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
      _winner = "";
    }

    public string GetPlayer1()
    {
      return _player1;
    }

    public string GetPlayer2()
    {
      return _player2;
    }

    public void SetPlayers(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }
  }
}
