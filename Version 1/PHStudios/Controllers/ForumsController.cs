using System.Web.Mvc;

namespace PHStudios.Controllers
{
	public class ForumsController : Controller
	{
		// GET: Forums
		public void Index()
		{
			Response.Redirect("https://www.phscommunity.com", false);
			Response.StatusCode = 301;
			Response.End();
		}
	}
}