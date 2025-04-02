using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class KlasController : Controller
    {
        [Authorize(Roles = "I0SD1")]
        public IActionResult I0SD1() => View();

        [Authorize(Roles = "I0SD3")]
        public IActionResult I0SD3() => View();
    }
}
