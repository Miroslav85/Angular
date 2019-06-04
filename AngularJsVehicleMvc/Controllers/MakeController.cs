using AngularJsVehicleMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJsVehicleMvc.Controllers
{
    public class MakeController : Controller
    {
     


        public JsonResult GetMakes()
        {
            MakeService ms = new MakeService();
            List<VehicleMake> listMakes = ms.GetMake();

            
            return Json(new { list = listMakes }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeletMake(int id)
        {
            MakeService ms = new MakeService();
            ms.DeleteVehicleMake(id);
            return Json(new { status = "Make delete sueccesfully" });
        }

        public JsonResult AddMake(VehicleMake make)
        {
            MakeService ms = new MakeService();
            ms.AddVehicleMake(make);
            
            return Json(new { status = "Make added sueccesfully" });
        }
        public JsonResult GetMakeById(int id)
        {
            using (vjezbaEntities db= new vjezbaEntities())
            {
                VehicleMake make = new VehicleMake();
               make = db.VehicleMakes.Where(m => m.Id == id).SingleOrDefault();
                return Json(new { make = make }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult UpdateMake(VehicleMake make)
        {
            MakeService ms = new MakeService();
            ms.EditVMake(make);

            return Json(new { status = "Make update sueccesfully" });


        }

    }
}