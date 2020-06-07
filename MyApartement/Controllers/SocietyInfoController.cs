using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApartement.Controllers
{
    public class SocietyInfoController : Controller
    {
        // GET: SocietyInfoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SocietyInfoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SocietyInfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocietyInfoController/Create
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

        // GET: SocietyInfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SocietyInfoController/Edit/5
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

        // GET: SocietyInfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SocietyInfoController/Delete/5
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
