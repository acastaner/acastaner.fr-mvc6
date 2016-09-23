using Microsoft.AspNetCore.Mvc;

namespace acastaner.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Accueil";
			ViewBag.Heading = "Bienvenue";
			ViewBag.SubHeading = "Sur mon coin d'Internet";
			ViewBag.HeaderImage = "welcome-bg.jpg";
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Title = "A propos";
			ViewBag.Heading = ViewBag.Title;
			ViewBag.SubHeading = "Ce qu'il y a sous le capot";
			ViewBag.HeaderImage = "about-bg.jpg";
			return View();
		}

        public ActionResult Curriculum()
        {
            ViewBag.Title = "Mon CV";
            ViewBag.Heading = ViewBag.Title;
            ViewBag.SubHeading = "Ce que j'ai fait de ma vie";
            ViewBag.HeaderImage = "projects-bg.jpg";
            return View();
        }

		public ActionResult Projects()
		{
			ViewBag.Title = "Projets";
			ViewBag.Heading = "Mes Projets";
			ViewBag.SubHeading = "Ce qui occupe mes soirées";
			ViewBag.HeaderImage = "projects-bg.jpg";
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Title = "Contact";
			ViewBag.Heading = ViewBag.Title;
			ViewBag.SubHeading = "Vieille école mais fort pratique";
			ViewBag.HeaderImage = "contact-bg.jpg";
			return View();
		}

        public ActionResult Tools()
        {
            ViewBag.Title = "Outils";
            ViewBag.Heading = ViewBag.Title;
            ViewBag.SubHeading = "(Aucune de ces informations n'est enregistrée)";
            ViewBag.HeaderImage = "tools-bg.png";

            ViewBag.RemoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.BrowserUserAgent = HttpContext.Request.Headers["User-Agent"].ToString();
            ViewBag.IsTls = HttpContext.Request.IsHttps;
            
            return View();
        }
	}
}