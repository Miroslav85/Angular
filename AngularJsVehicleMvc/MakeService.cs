using AngularJsVehicleMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJsVehicleMvc
{
    public class MakeService
    {

      
        public void AddVehicleMake(VehicleMake VehiceM)
        {
            using (vjezbaEntities db = new vjezbaEntities())
            {
                db.VehicleMakes.Add(VehiceM);
                db.SaveChanges();
             
            }
        }
        public List<VehicleMake> GetMake()
        {
            List<VehicleMake> Vm = new List<VehicleMake>();
            using (vjezbaEntities db = new vjezbaEntities())
            {
                Vm = db.VehicleMakes.ToList();
            }
            return Vm;
        }

        public void DeleteVehicleMake(int VMakeId)
        {

            using (vjezbaEntities db = new vjezbaEntities())
            {
              VehicleMake Make = new VehicleMake();
                Make = db.VehicleMakes.Find(VMakeId);

                db.VehicleMakes.Remove(Make);
                db.SaveChanges();
            }
        }
        public void EditVMake(VehicleMake VMake)
        {


            using (vjezbaEntities db = new vjezbaEntities())
            {
                db.Entry(VMake).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}