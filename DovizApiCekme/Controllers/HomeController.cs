using DovizApiCekme.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DovizApiCekme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<DovizModel> Curlist = null;
            WebClient client = new WebClient();
            var json = client.DownloadString("https://finans.truncgil.com/today.json");
            Curlist = JsonConvert.DeserializeObject<List<DovizModel>>(json);

            if (Curlist == null)
                return null;

            return View(Curlist.ToList());
        }
    }
}