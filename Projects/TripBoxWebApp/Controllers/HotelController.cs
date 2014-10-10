using System;
using System.Collections.Generic;
using System.Linq;
using LOGI.Core.Domain.Model.Hotel;
using LOGI.Core.Domain.Model.Hotel.Deals;

namespace TripBoxWebApp.Controllers
{
    using System.Web.Mvc;

    public class HotelController : Controller
    {
        public ActionResult Index()
        {
            var popularDeals = new List<PopularDealModel>();
            var rateValueRandom = new Random();
            var rateCountRandom = new Random();
            var totalRandom = new Random();

            for (int i = 0; i < 6; i++)
            {
                popularDeals.Add(new PopularDealModel()
                {
                    Id = i.ToString(),
                    Currency = "$",
                    ImgUrl = "~/Content/temp/300x160.gif",
                    Title = "Sheraton hanoi Hotel",
                    Subtitle = "Lorem ipsum dolor sit saelas met, consas ecttur ads ipi deese cing elit. Mauris fring illa bibe endums leo consec.",
                    RateValue = (byte)rateValueRandom.Next(1, 5),
                    Total = totalRandom.Next(100, 999),
                    RateCount = rateCountRandom.Next(1, 50),
                    Location = "Sheraton Hotel - Hanoi, Vietnam"
                });
            }
            ViewBag.PopularDeals = popularDeals.OrderBy(x=>x.Total).ToList();
            return View();
        }

        public ActionResult HotelList()
        {
            var hotelItems = new List<HotelItem>();
            var rateValueRandom = new Random();
            var rateCountRandom = new Random();
            var totalRandom = new Random();

            for (int i = 0; i < 6; i++)
            {
                hotelItems.Add(new HotelItem()
                {
                    Id = i.ToString(),
                    Currency = "$",
                    ImgUrl = "~/Content/temp/300x160.gif",
                    Title = "Sheraton hanoi Hotel",
                    Subtitle = "Lorem ipsum dolor sit saelas met, consas ecttur ads ipi deese cing elit. Mauris fring illa bibe endums leo consec.",
                    RateValue = (byte)rateValueRandom.Next(1, 5),
                    Total = totalRandom.Next(100, 999),
                    RateCount = rateCountRandom.Next(1, 50),
                    Location = "Sheraton Hotel - Hanoi, Vietnam"
                });
            }
            ViewBag.HotelItems = hotelItems;
            return View();
        }
    }
}

