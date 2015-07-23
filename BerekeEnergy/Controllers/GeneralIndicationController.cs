using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using BerekeEnergy.Data_Layer;
using BerekeEnergy.Models;

namespace BerekeEnergy.Controllers
{
    public class GeneralIndicationController : Controller
    {
        DataAdapter da = DependencyResolver.Current.GetService<DataAdapter>();

        // GET: GeneralIndication
        public ActionResult GeneralIndex()
        {
            return View();
        }

        // GET: GeneralIndication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneralIndication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneralIndication/Create
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

        // GET: GeneralIndication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneralIndication/Edit/5
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

        // GET: GeneralIndication/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneralIndication/Delete/5
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

        public JsonResult GenIndAjaxHandler(jQueryDataTableParamModel param)
        {
            var allCompanies = da.GetAllTypeDevice();

            var result = from c in allCompanies
                         select new DTypeDeviceModel { 
                
                    Id = c.Id, 
                    code = c.code, 
                    name = c.name
            };

            return Json(new
            {
                data = result
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GenIndAjaxHandler2(DTypeDeviceModel data)
        {
            var allCompanies = da.GetAllTypeDevice();

            var result = from c in allCompanies
                         select new DTypeDeviceModel
                         {

                             Id = c.Id,
                             code = c.code,
                             name = c.name
                         };

            return Json(new
            {
                data = result
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
