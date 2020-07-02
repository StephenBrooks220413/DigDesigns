using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigDesigns.Models
{
    public class Code : Controller
    {
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }

        // GET: Code/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Code/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Code/Create
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

        // GET: Code/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Code/Edit/5
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

        // GET: Code/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Code/Delete/5
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
