using Microsoft.AspNetCore.Mvc;

namespace IdentityAjaxClient.Controllers
{
    public class OrchidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
