using Microsoft.AspNet.Mvc;

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
			ViewBag.Title = "Mes projets";
			ViewBag.Heading = ViewBag.Title;
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
	}
}