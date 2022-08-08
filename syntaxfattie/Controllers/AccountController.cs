using Microsoft.AspNetCore.Mvc;
using syntaxfattie.Models;

namespace syntaxfattie.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(SyntaxUser _user)
        {
            _user.IsUserLogin = false;
            return View(_user);
        }
    }
}
