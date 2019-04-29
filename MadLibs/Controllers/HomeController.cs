using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        
        [Route("/form")]
        public ActionResult Form() { return View(); }
        [Route("/story")]
        public ActionResult Story(string location, string famousPerson, string adjective1, string sound, string animal1, string animal2, string animal3, string verb1, string typeOfPerson, string noun, string verb2, string store, string race, string goodBad, string famousWoman, string verb3, string group, string place, string game, string setting, string edVerb, string accomplishment, string pluralNoun, string athlete, string adjective2) 
        {
            MadWords myMadWords = new MadWords();
            myMadWords.SetLocation(location);
            myMadWords.SetFamousPerson(famousPerson);
            myMadWords.SetAdjective1(adjective1);
            myMadWords.SetSound(sound);
            myMadWords.SetAnimal1(animal1);
            myMadWords.SetAnimal2(animal2);
            myMadWords.SetAnimal3(animal3);
            myMadWords.SetVerb1(verb1);
            myMadWords.SetTypeOfPerson(typeOfPerson);
            myMadWords.SetNoun(noun);
            myMadWords.SetVerb2(verb2);
            myMadWords.SetStore(store);
            myMadWords.SetRace(race);
            myMadWords.SetGoodBad(goodBad);
            myMadWords.SetFamousWoman(famousWoman);
            myMadWords.SetVerb3(verb3);
            myMadWords.SetGroup(group);
            myMadWords.SetPlace(place);
            myMadWords.SetGame(game);
            myMadWords.SetSetting(setting);
            myMadWords.SetEdVerb(edVerb);
            myMadWords.SetAccomplishment(accomplishment);
            myMadWords.SetPluralNoun(pluralNoun);
            myMadWords.SetAthlete(athlete);
            myMadWords.SetAdjective2(adjective2);
            
            return View(myMadWords);
        }
    }
}