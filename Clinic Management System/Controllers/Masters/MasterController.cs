using Microsoft.AspNetCore.Mvc;

namespace Clinic_Management_System.Controllers.Masters
{
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
