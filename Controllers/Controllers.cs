using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class Dojosurvey: Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult input(){
            return View("survey");
        }
        [HttpPost]
        [Route("Submit")]
        public IActionResult submit(string name, string location, string language, string message){
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.message = message;
            return View("all");
        }
        
    }
}