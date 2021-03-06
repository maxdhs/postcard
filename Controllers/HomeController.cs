using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Aladdin");
      myLetterVariable.SetSender("Jafar");
      return View(myLetterVariable);
    }

    [Route("/form")]
     public ActionResult Form() { return View(); }

    [Route("/journal")]
    public ActionResult Journal() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string item)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(recipient);
      myLetterVariable.SetSender(sender);
      myLetterVariable.SetLocation(location);
      myLetterVariable.SetItem(item);

      return View(myLetterVariable);
    }
  

  }
}