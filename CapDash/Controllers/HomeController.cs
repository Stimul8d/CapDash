using CapDash.Models;
using CapDash.Services;
using System.Web.Mvc;

namespace CapDash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var csv = new CsvReader();
            var x = csv.GetResults(Server.MapPath("~/Results/20.csv"));
            return View(new HomeModel(x.VirtualUsers, x.MinResponseTime, x.MaxResponseTime, x.TotalResponseTime));
        }
    }
}