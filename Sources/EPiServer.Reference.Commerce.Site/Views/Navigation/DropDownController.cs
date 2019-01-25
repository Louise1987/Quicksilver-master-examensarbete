using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Views.Navigation
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index(int? value)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem()
            {
                Text = "Horse rug",
                Value = "1",
                Selected = true
            };
            SelectListItem item2 = new SelectListItem()
            {
                Text = "Saddle pad",
                Value = "2",
                Selected = false
            };
            SelectListItem item3 = new SelectListItem()
            {
                Text = "Horse boots",
                Value = "3",
                Selected = false
            };
                items.Add(item1);
                items.Add(item2);
                items.Add(item3);

            if (value != null)
            {
                items.Where(i => i.Value == value.ToString()).First().Selected = true;
            }
            ViewBag.Horse = items;
            return View();
        }

        // GET: DropDown/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DropDown/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DropDown/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DropDown/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DropDown/Edit/5
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

        // GET: DropDown/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DropDown/Delete/5
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
