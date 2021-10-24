using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;

namespace Business.Servicess
{
    public class MedicinetypeService : IMedicinetype 
    {
        private MedicineTypeRepository medicinetypeRepository { get; }
        private MedicineService medicineService { get; }

        public MedicinetypeService()
        {
            medicinetypeRepository = new MedicineTypeRepository();

            medicineService = new MedicineService();
        }

        public Medicinetype Create(Medicinetype medicinetype, string medicineName)
        {
            //Medicine dbMedicine = medicineService.Get(medicineName);
            //if (dbMedicine != null)
            //{
            //    medicinetype.name = dbMedicine; 
            //}
            //else
            //{
            //    return null;
            }

        }

        public Medicinetype Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Medicinetype Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medicinetype> Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Medicinetype> GetAll(string medicinename)
        {
            throw new NotImplementedException();
        }

        public List<Medicinetype> GetAll()
        {
            throw new NotImplementedException();
        }

        public Medicinetype Update(Medicinetype medicine, string medicineName)
        {
            throw new NotImplementedException();
        }
    }
}
