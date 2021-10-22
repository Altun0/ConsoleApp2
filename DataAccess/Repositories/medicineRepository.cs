using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class MedicineRepository : IRepository <Medicine>

    {
        public bool Create(Medicine entity)
        {
            try
            {
                DbContext.Medicines.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Medicine entity)
        {
            try
            {
                DbContext.Medicines.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public Medicine Get(Predicate<Medicine> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Medicines[0]
                    : DbContext.Medicines.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Medicine> GetAll(Predicate<Medicine> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Medicines
                    : DbContext.Medicines.FindAll(filter);  
            }
            catch (Exception)
            {
                throw;
            }

        }
       
        public bool Update(Medicine entity)
        {
            try
            {
                Medicine dbmedicine = Get(s => s.Id == entity.Id);
                dbmedicine = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}  