using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PrivéController : Controller
    {
        [Authorize(Users = "stijn@voorbeeld.nl")]
        public IActionResult Stijn() => View();

        [Authorize(Users = "jochem@voorbeeld.nl")]
        public IActionResult Jochem() => View();
    }
}
