using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StijnSemester6Controller : Controller
    {
        [HttpGet]
        public IActionResult StijnHashing3()
        {
            return View(new HashingModel());
        }

        [HttpPost]
        public IActionResult StijnHashing3(HashingModel model)
        {
            if (!string.IsNullOrEmpty(model.Tekst) && !string.IsNullOrEmpty(model.GekozenAlgoritme))
            {
                model.GehashteWaarde = HashTekst(model.Tekst, model.GekozenAlgoritme);
            }
            return View(model);
        }

        private string HashTekst(string tekst, string algoritme)
        {
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(tekst);
            byte[] hashBytes;

            switch (algoritme)
            {
                case "MD5":
                    hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(inputBytes);
                    break;
                case "SHA1":
                    hashBytes = System.Security.Cryptography.SHA1.Create().ComputeHash(inputBytes);
                    break;
                case "SHA256":
                    hashBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(inputBytes);
                    break;
                case "SHA512":
                    hashBytes = System.Security.Cryptography.SHA512.Create().ComputeHash(inputBytes);
                    break;
                case "BCrypt":
                    return BCrypt.Net.BCrypt.HashPassword(tekst);
                default:
                    return "Onbekend algoritme";
            }

            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
