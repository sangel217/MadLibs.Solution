using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        // [Route("/story")]
        // public ActionResult Story() {
        // MadWords myMadWords = new MadWords();
        // myMadWords.SetNoun("Dog");
        // myMadWords.SetVerb("pooed");
        // myMadWords.SetAdjective("smelly");
        // return View(myMadWords);
        [Route("/form")]
        public ActionResult Form() { return View(); }
        [Route("/story")]
        public ActionResult Story(string noun, string verb, string adjective) 
        {
            MadWords myMadWords = new MadWords();
            myMadWords.SetNoun(noun);
            myMadWords.SetVerb(verb);
            myMadWords.SetAdjective(adjective);
            return View(myMadWords);
        }
    }
}