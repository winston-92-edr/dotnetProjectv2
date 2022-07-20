using dotNetChallange.Data;
using dotNetChallange.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Timers;
using System.Web;
using System.Web.Mvc;

namespace dotNetChallange.Controllers
{
    public class HomeController : Controller
    {
        private DataDbContext _db = new DataDbContext();
        public ActionResult Index()
        {
            var data = (from s in _db.MyData select s).ToList();

            ViewBag.data = data;
            return View();


        }

        [HttpGet]
        [Route("Last24hData")]
        public ActionResult Last24hData()
        {
            var dt = DateTime.Now.AddHours(-24);
            var data = (from s in _db.MyData where s.dateTime > dt select s).ToList();

            ViewBag.data = data;
            return View();
        }

        public ActionResult Last7DayData()
        {
            ViewBag.data = getDbItems(-7);
            return View();
        }

        public ActionResult Last30DayData()
        {
            ViewBag.data = getDbItems(-24);
            return View();
        }

        private List<DataDbModel> getDbItems(int time)
        {
            var dt = DateTime.Now.AddDays(time);
            var data = (from s in _db.MyData where s.dateTime > dt select s).ToList();

            return data;
        }


    }
}
