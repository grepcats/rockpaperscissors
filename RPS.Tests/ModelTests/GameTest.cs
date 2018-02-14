using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void GetPlayer1_FetchPlayerSelection_String()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testSelection = "scissors";

      //act
      string player1Selection = newGame.GetPlayer1();

      //assert
      Assert.AreEqual(testSelection, player1Selection);
    }

    [TestMethod]
    public void GetPlayer2_FetchPlayerSelection_String()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testSelection = "paper";

      //act
      string player2Selection = newGame.GetPlayer2();

      //assert
      Assert.AreEqual(testSelection, player2Selection);
    }
    [TestMethod]
    public void SetPlayers_SetPlayers_Void()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testSelection = "rock";

      //act
      newGame.SetPlayers("scissors", testSelection);
      //assert
      Assert.AreEqual(testSelection, newGame.GetPlayer2());
    }

    [TestMethod]
    public void GetWinner_FetchTheWinner_Void()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string testWinner = "";

      //act
      string winner = newGame.GetWinner();
      //assert
      Assert.AreEqual(winner, testWinner);
    }

    [TestMethod]
    public void SetWinner_CompareRockandScissors_Void()
    {
      //arrange
      Game newGame = new Game("rock", "scissors");
      string winner = "Player1";

      //act
      newGame.SetWinner("rock", "scissors");

      //assert
      Assert.AreEqual(winner, newGame.GetWinner());
    }
    [TestMethod]
    public void SetWinner_CompareScissorsAndPaper_Void()
    {
      //arrange
      Game newGame = new Game("scissors", "paper");
      string winner = "Player1";

      //act
      newGame.SetWinner("scissors", "paper");

      //assert
      Assert.AreEqual(winner, newGame.GetWinner());
    }
    [TestMethod]
    public void SetWinner_ComparePaperandRock_void()
    {
      //arrange
      Game newGame = new Game("paper", "rock");
      string winner = "Player1";

      //act
      newGame.SetWinner("paper", "rock");
      //assert
      Assert.AreEqual(winner, newGame.GetWinner());
    }
    [TestMethod]
    public void SetWinner_Draw_Void()
    {
      //arrange
      Game newGame = new Game("paper", "paper");
      string winner = "DRAW";

      //act
      newGame.SetWinner("paper", "paper");
      //assert
      Assert.AreEqual(winner, newGame.GetWinner());
    }
  }
}
