using AngularJsVehicleMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJsVehicleMvc
{
    public class ModelService
    {
        public List<VehicleModel> GetAllVModel()
        {
            List<VehicleModel> ListVModel = new List<VehicleModel>();
            using (vjezbaEntities db = new vjezbaEntities())
            {
               ListVModel = db.VehicleModels.ToList();
              List<VehicleMake>  ListVMake = db.VehicleMakes.ToList();

            }

            return ListVModel;
        }

        public VehicleModel DetailsVModel(int id)
        {

            using (vjezbaEntities db = new vjezbaEntities())
            {
                db.VehicleModels.ToList();
                db.VehicleMakes.ToList();
              VehicleModel  vehicleModel = new VehicleModel();
               vehicleModel = db.VehicleModels.Find(id);

                return vehicleModel;

            }
        }

        public void AddVehicleModel(VehicleModel vehiceMod)
        {
            using (vjezbaEntities db = new vjezbaEntities())
            {


                db.VehicleModels.Add(vehiceMod);
                db.SaveChanges();

            }
        }

        public void DeleteVehicleModel(int VModelId)
        {

            using (vjezbaEntities db = new vjezbaEntities())
            {
              VehicleModel  vehicleModel = new VehicleModel();
                vehicleModel = db.VehicleModels.Find(VModelId);

                db.VehicleModels.Remove(vehicleModel);
                db.SaveChanges();
            }
        }

        public VehicleModel FindByID(int id)
        {
          VehicleModel  vehicleModel = new VehicleModel();
            using (vjezbaEntities db = new vjezbaEntities())
            {
                vehicleModel = db.VehicleModels.Find(id);
            }
            return vehicleModel;
        }
        public void EditVModel(VehicleModel VModel)
        {

            using (vjezbaEntities db = new vjezbaEntities())
            {

                db.Entry(VModel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
        }

    }
}