using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicBox.Controllers
{
    public class SearchController : Controller
    {
		private iArtistRepository _artistRepository;
		public SearchController () {
			_artistRepository = new ArtistRepository ();
		}
		public ViewData Index()
		{
			return RedirectToAction("Home");
		}

		[HttpGet]
        public ActionResult Index()
        {
			ViewData = _artistRepository;
			return RedirectToAction("Home");
        }
    }
}
