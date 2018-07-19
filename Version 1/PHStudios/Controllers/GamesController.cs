using System.Web.Mvc;

namespace PHStudios.Controllers
{
	public class GamesController : Controller
	{
		// GET: Games
		public ActionResult Index()
		{
			return View();
		}
	}
}