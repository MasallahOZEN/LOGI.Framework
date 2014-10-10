namespace TripBoxWebApp.Controllers
{
    using System;
    using System.Web.Mvc;
    using TripBoxWebApp.Models.Home;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchPanel(MainSearchPanelModel mainSearchPanelModel)
        {
            return Json(mainSearchPanelModel);
        }

        [HttpPost]
        public ActionResult SearchSite(HeaderSearchModel headerSearchModel)
        {
            return Content("Temp:" + headerSearchModel.SearchText);
        }
    }
}

