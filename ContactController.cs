using Microsoft.AspNetCore.Mvc;
namespace ContactManager.Controllers
{
    public class ContactController : Controllers
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}