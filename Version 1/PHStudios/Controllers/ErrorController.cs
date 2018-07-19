using System.Web.Mvc;

namespace PHStudios.Controllers
{
	public class ErrorController : Controller
	{
		// GET: Error
		public ActionResult Index()
		{
			return View();
		}

		// GET:  NotFound
		public ActionResult NotFound()
		{
			return View();
		}
	}
}