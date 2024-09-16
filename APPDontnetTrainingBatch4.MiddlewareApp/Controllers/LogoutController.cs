using Microsoft.AspNetCore.Mvc;

namespace APPDontnetTrainingBatch4.MiddlewareApp.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
}
