using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using StudyCaseRPL.DAL;
using StudyCaseRPL.Models;

namespace StudyCaseRPL.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            CategoriesDAL catDal = new CategoriesDAL();
            var models = catDal.GetAll();

            return View(models);
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                CategoriesDAL catDal = new CategoriesDAL();
                catDal.Create(category);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
