using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class MedicineRepository : IRepository <Medicinetype>

    {
        public bool Create(Medicinetype entity)
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

        public bool Delete(Medicinetype entity)
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
        

        public Medicinetype Get(Predicate<Medicinetype> filter = null)
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

        public List<Medicinetype> GetAll(Predicate<Medicinetype> filter = null)
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
       
        public bool Update(Medicinetype entity)
        {
            try
            {
                Medicinetype dbmedicine = Get(s => s.Id == entity.Id);
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