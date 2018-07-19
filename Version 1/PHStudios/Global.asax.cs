using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PHStudios
{
	public class MvcApplication : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{
			/*switch (Request.Url.Scheme)
			{
				case "https":
					Response.AddHeader("Strict-Transport-Security", "max-age=31536000");
					break;
				case "http":
					var path = "https://" + Request.Url.Host + Request.Url.PathAndQuery;
					Response.Status = "301 Moved Permanently";
					Response.AddHeader("Location", path);
					break;
			}*/
		}
	}
}