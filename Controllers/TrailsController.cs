using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LostWoods.Models;

namespace LostWoods.Controllers{
    public class TrailsController: Controller{

        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }
        [HttpGet]
        [Route("NewTrail")]
        public IActionResult NewTrail(){
            return View("NewTrail");
        }
    }
}