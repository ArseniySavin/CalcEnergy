using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BerekeEnergy.Data_Layer;
using BerekeEnergy.Models;

namespace BerekeEnergy.Controllers
{
    public class DictController : Controller
    {
        DataAdapter da = DependencyResolver.Current.GetService<DataAdapter>();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Device()
        {
            return View();
        }

        [HttpGet]
        public JsonResult DeviceAjaxHandler()
        {
            var allTypeDevice = da.GetAllDevice();

            return Json(new
            {
                data = allTypeDevice
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeviceAjaxHandler(DDevaceModel data)
        {
            DDevaceModel result = null;

            if(Request.Params.Get("action") == "create")
            {
                result = da.InsertDevice(data);
            }
            else if(Request.Params.Get("action") == "edit")
            {
                result = da.UpdateDevice(data);
            }
            else if(Request.Params.Get("action") == "remove")
            {
                da.DeleteDevice(data);
                result = data;
            }

            return Json(new
            {
                data = result
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TypeDevice()
        {
            return View();
        }

        [HttpGet]
        public JsonResult TypeDeviceAjaxHandler()
        {
            var allTypeDevice = da.GetAllTypeDevice();

            return Json(new
            {
                data = allTypeDevice
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult TypeDeviceAjaxHandler(DTypeDeviceModel data)
        {
            DTypeDeviceModel result = null;

            if(Request.Params.Get("action") == "create")
            {
                result = da.InsertTypeDevice(data);
            }
            else if(Request.Params.Get("action") == "edit")
            {
                result = da.UpdateTypeDevice(data);
            }
            else if(Request.Params.Get("action") == "remove")
            {
                da.DeleteTypeDevice(data);
                result = data;
            }

            return Json(new
            {
                data = result
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Tariff()
        {
            return View();
        }

        [HttpGet]
        public JsonResult TariffAjaxHandler()
        {
            var allTariff = da.GetAllTariff();

            return Json(new
            {
                data = allTariff
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult TariffAjaxHandler(DTariffModel data)
        {
            DTariffModel result = null;

            if(Request.Params.Get("action") == "create")
            {
                result = da.InsertTariff(data);
            }
            else if(Request.Params.Get("action") == "edit")
            {
                result = da.UpdateTariff(data);
            }
            else if(Request.Params.Get("action") == "remove")
            {
                da.DeleteTariff(data);
                result = data;
            }

            return Json(new
            {
                data = result
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTypeDeviceAjaxHandler()
        {
            var allTypeDevice = da.GetAllTypeDeviceForList();

            var a = (from b in allTypeDevice
                     select new 
                     { 
                     b.label,
                     b.value
                     }).ToArray();

            return Json(a, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetTariffAjaxHandler()
        {
            var allTypeDevice = da.GetAllTariffForList();

            var a = (from b in allTypeDevice
                     select new
                     {
                         b.label,
                         b.value
                     }).ToArray();

            return Json(a, JsonRequestBehavior.AllowGet);
        }
    }
}
