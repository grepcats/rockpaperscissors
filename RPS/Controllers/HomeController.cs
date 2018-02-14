using Microsoft.AspNetCore.Mvc;
using RPS.Models;

namespace RPS.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/result")]
    public ActionResult Result()
    {
      string player1 = Request.Form['player1-input'];
      string player2 = Request.Form['player2-input'];

      Game newGame = new Game(string player1, string player2)
      newGame.SetWinner(player1, player2);
      string winner = newGame.GetWinner();
      return View("Index", winner);
    }
  }
}
