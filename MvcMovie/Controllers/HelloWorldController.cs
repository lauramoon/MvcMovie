using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        // Note that this controller can serve results to both helloworld/welcome/[id]?name=[name] (default route)
        // and helloworld/welcome/[name]/[id] (added route)
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}