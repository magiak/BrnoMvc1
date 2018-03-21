using System.Web.Mvc;

namespace BrnoMvc1.Web.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            string model = "Hello world 2";
            //int model = 
            return View(model: model);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}