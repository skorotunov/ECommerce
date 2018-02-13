using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new FeaturedProductsViewModel();
            return this.View();
        }
    }
}