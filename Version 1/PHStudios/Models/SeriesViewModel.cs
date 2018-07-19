using System.Collections.Generic;

namespace PHStudios.Models
{
	public class SeriesViewModel
	{
		public Series Series { get; set; }
		public List<Resource> SeriesResources { get; set; }
		public List<VideoDetailsModel> VideoDetails { get; set; }
		public int? SelectedVideoID { get; set; }
	}
}