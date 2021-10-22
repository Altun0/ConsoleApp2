using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;



namespace Business.Servicess
{
    public class MedicineService : IMedicine
    {
        public MedicineRepository medicineRepository { get; set; }

        private static int count { get; set; }

        public MedicineService()
        {
            medicineRepository = new MedicineRepository();
        }

        public Medicine Create(Medicine medicine)
        {
            try
            {
                medicine.Id = count;
                Medicine isExit = medicineRepository.Get(g => g.Name.ToLower() == medicine.Name.ToLower());
                if (isExit != null)
                    return null;
                medicineRepository.Create(medicine);
                count++;
                return medicine;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public Medicine Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll(int Cost)
        {
            throw new NotImplementedException();
        }

        public Medicine Update(int Id, Medicine medicine)
        {
            throw new NotImplementedException();
        }
    }
}
