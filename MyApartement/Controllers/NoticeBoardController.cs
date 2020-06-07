using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApartement.Controllers
{
    public class NoticeBoardController : Controller
    {
        // GET: NoticeBoardController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NoticeBoardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoticeBoardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoticeBoardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoticeBoardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NoticeBoardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoticeBoardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoticeBoardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
