using System.Web.Mvc;
using Interfaces;

namespace DI_BaseProject.Controllers
{
    public class HomeController : Controller
    {
        private ILog Log { get; }

        public HomeController(ILog log)
        {
            Log = log;
        }

        public ActionResult Index()
        {
            Log.EscreveLog("Página INDEX acessada");
            return View();
        }

        public ActionResult Outra()
        {
            Log.EscreveLog("Página OUTRA acessada");
            return View();
        }
    }
}