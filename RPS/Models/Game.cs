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

    public string GetWinner()
    {
      return _winner;
    }

    public void SetWinner(string player1, string player2)
    {
      if (player1 == "rock" && player2 == "scissors")
      {
        _winner = "Player 1 WINS";
      }
      else if (player1 == "scissors" && player2 == "rock")
      {
        _winner = "Player 2 WINS";
      }
      else if (player1 == "scissors" && player2 == "paper")
      {
        _winner = "Player 1 WINS";
      }
      else if (player1 == "paper" && player2 == "scissors")
      {
        _winner = "Player 2 WINS";
      }
      else if (player1 == "paper" && player2 == "rock")
      {
        _winner = "Player 1 WINS";
      }
      else if (player1 == "rock" && player2 == "paper")
      {
        _winner = "Player 2 WINS";
      }
      else if ((player1 == "rock" && player2 == "rock") || (player1 == "paper" && player2 == "paper") || (player1 == "scissors" && player2 == "scissors"))
      {
        _winner = "DRAW";
      }
      else
      {
        _winner = "you screwed up";
      }



    }
  }
}
