using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PHStudios.Models;

namespace PHStudios.Controllers
{
	public class SeriesController : Controller
	{
		// GET: Series
		public ActionResult Index()
		{
			List<Series> series = null;

			using (program_phstudiosEntities ctx = new program_phstudiosEntities())
			{
				series = ctx.Series.Where(s => !s.Legacy).ToList();
			}

			return View(series);
		}

		// GET: View
		public ActionResult View(int? id, int? videoID)
		{
			SeriesViewModel seriesViewModel = null;
			if (id != null && id > 0)
			{
				using (program_phstudiosEntities ctx = new program_phstudiosEntities())
				{
					Series s = ctx.Series.FirstOrDefault(series => series.ID == id);
					if (s == null)
					{
						return RedirectToAction("Index", "Series");
					}

					List<Resource> seriesResources = (from sr in ctx.SeriesResources
						join r in ctx.Resources on sr.Resource_ID equals r.ID
						where sr.Series_ID == s.ID
						select r).ToList();

					List<VideoDetailsModel> videos =
						ctx.Videos.Where(v => v.Series_ID == s.ID).Select(v => new VideoDetailsModel {Video = v}).ToList();
					foreach (VideoDetailsModel videoDetails in videos)
					{
						videoDetails.Resources =
							ctx.VideoResources.Where(vr => vr.Video_ID == videoDetails.Video.ID).Select(vr => vr.Resource).ToList();
					}

					seriesViewModel = new SeriesViewModel
					{
						Series = s,
						SeriesResources = seriesResources,
						VideoDetails = videos.OrderBy(v => v.Video.Order).ToList()
					};
				}
			}
			else
			{
				return RedirectToAction("Index", "Series");
			}
			return base.View(seriesViewModel);
		}
	}
}