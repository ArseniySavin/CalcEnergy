using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BerekeEnergy.Models;

namespace BerekeEnergy.Controllers
{
    public class GeneralIndicationController : Controller
    {
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

        //public ActionResult GenIndAjaxHandler(jQueryDataTableParamModel param)
        //{
        //    //var allCompanies = da.IBANValidation();

        //    var result = from c in allCompanies
        //                 select new[] { 
        //        Convert.ToString(c.Id), 
        //        c.loan_contract_number, 
        //        c.Receiver.national_id, 
        //        c.Receiver.name,
        //        c.amount.Value.ToString(),
        //        c.Receiver.bank_bin, 
        //        c.Receiver.bank_code, 
        //        c.Receiver.account_number,
        //        c.Receiver.bank_transit_acc_nb, 
        //        c.value_date.Value.ToString("dd.MM.yyyy"), 
        //        c.z_chanel_type, 
        //        c.operation_type,
        //        c.z_branch, 
        //        c.z_user_cl
        //    };

        //    return Json(new
        //    {
        //        sEcho = param.sEcho,
        //        aaData = result,
        //        iTotalRecords = allCompanies.Count(),
        //        iTotalDisplayRecords = param.iDisplayLength
        //    },
        //                JsonRequestBehavior.AllowGet);
        //}
    }
}
