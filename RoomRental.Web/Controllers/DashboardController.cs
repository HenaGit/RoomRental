using Microsoft.AspNetCore.Mvc;

namespace RoomRental.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
