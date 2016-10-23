using Newtonsoft.Json;
using RetroTip.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RetroTip.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Main()
        {
            // Get the users predicted history from Synchrony

            try
            {
                HttpClient client = new HttpClient();
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://syf2020.syfwebservices.com/syf/nextMostLikelyPurchase"),
                    Method = HttpMethod.Post
                };

                request.Headers.Add("username", "giveitatry");
                request.Headers.Add("password", "Sh0wT!me");
                request.Headers.Add("Content-Type", "application/json");

                var response = client.SendAsync(request).Result;

                response.EnsureSuccessStatusCode();

                LikelyPurchase likelyPurchases = JsonConvert.DeserializeObject<LikelyPurchase>(response.Content.ReadAsStringAsync().Result);

                
            }
            catch
            {

            }

            // Match with users show a few of the matches

            return View();
        }

        public ActionResult TipTimeline()
        {
            return View();
        }

        public ActionResult CheckBalance()
        {
            return View();
        }
    }
}
