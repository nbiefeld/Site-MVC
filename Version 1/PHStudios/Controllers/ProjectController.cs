using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using PHStudios.Models;

namespace PHStudios.Controllers
{
	public class ProjectController : Controller
	{
		// GET: Project
		public ActionResult Index()
		{
			List<Project> projects = null;

			using (program_phstudiosEntities ctx = new program_phstudiosEntities())
			{
				projects = ctx.Projects.ToList();
			}

			return View(projects);
		}

		// Get: View
		public ActionResult View(int? id)
		{
			Project project = null;

			using (program_phstudiosEntities ctx = new program_phstudiosEntities())
			{
				project =
					ctx.Projects.Where(p => p.ID == id).Include(p => p.ProjectFeatures.Select(pf => pf.Feature)).FirstOrDefault();
			}

			if (project == null) return RedirectToAction("Index", "Project");

			return base.View(project);
		}
	}
}