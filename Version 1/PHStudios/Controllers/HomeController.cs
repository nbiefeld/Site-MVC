using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PHStudios.Models;

namespace PHStudios.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			LatestViewModel latestContent = null;

			using (program_phstudiosEntities ctx = new program_phstudiosEntities())
			{
				List<LatestVideo> latestVideos =
					ctx.LatestVideos.OrderByDescending(v => v.ReleaseDate).ThenByDescending(v => v.Order).Take(6).ToList();

				List<LatestProject> latestProjects =
					ctx.LatestProjects.OrderByDescending(p => p.Created).Take(3).ToList();

				latestContent = new LatestViewModel
				{
					LatestVideos = latestVideos,
					LatestProjects = latestProjects
				};
			}

			return View(latestContent);
		}

		// GET: LatestVideos
		public ActionResult LatestVideos()
		{
			List<LatestVideo> latestVideos = null;

			using (program_phstudiosEntities ctx = new program_phstudiosEntities())
			{
				latestVideos =
					ctx.LatestVideos.OrderByDescending(v => v.ReleaseDate).ThenByDescending(v => v.Order).ToList();
			}

			return View(latestVideos);
		}

		public ActionResult LatestProjects()
		{
			List<LatestProject> latestProjects = null;

			using (program_phstudiosEntities ctx = new program_phstudiosEntities())
			{
				latestProjects =
					ctx.LatestProjects.OrderByDescending(p => p.Created).ToList();
			}

			return View(latestProjects);
		}
	}
}