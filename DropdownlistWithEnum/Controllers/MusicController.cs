using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropdownlistWithEnum.Models;

namespace DropdownlistWithEnum.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusicGenre")] MusicProfileViewModel profile)
        {
            if (ModelState.IsValid)
            {
                var temp = profile.MusicGenre;
                return RedirectToAction("Index");
            }

            return View(profile);
        }

    }
}