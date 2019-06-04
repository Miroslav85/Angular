using AngularJsVehicleMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJsVehicleMvc.Controllers
{
    public class ModelController : Controller
    {
        public JsonResult GetModels()
        {
            ModelService ms = new ModelService();
            List<VehicleModel> listModels = ms.GetAllVModel();


            return Json(new { list = listModels }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeletModel(int id)
        {
            ModelService ms = new ModelService();
            ms.DeleteVehicleModel(id);
            return Json(new { status = "Model delete sueccesfully" });
        }

        public JsonResult AddModel(VehicleModel model)
        {
            ModelService ms = new ModelService();
            ms.AddVehicleModel(model);

            return Json(new { status = "Make added sueccesfully" });
        }

        public JsonResult UpdateModel(VehicleModel model)
        {
            ModelService ms = new ModelService();
            ms.EditVModel(model);

            return Json(new { status = "Make update sueccesfully" });


        }

        public JsonResult GetModelById(int id)
        {
            ModelService ms = new ModelService();
            VehicleModel model = new VehicleModel();
               ms.FindByID(id);
               
           return Json(new { model = model }, JsonRequestBehavior.AllowGet);
            
        }
    }
}