using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using Entities.Interface;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class MedicineTypeRepository : IRepository<MedicineType>
    {
        public bool Create(MedicineType entity)
        {
            try
            {
                DbContext.MedicineTypes.Add(entity);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(MedicineType entity)
        {
            try
            {
                DbContext.MedicineTypes.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public MedicineType Get(Predicate<MedicineType> filter = null)
        {
            try
            {
                return filter==null ? DbContext.MedicineTypes[0]
                    : DbContext.MedicineTypes.Find(filter);

            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<MedicineType> GetAll(Predicate<MedicineType> filter = null)
        {
            try
            {
                return filter == null ? DbContext.MedicineTypes
                    : DbContext.MedicineTypes.FindAll(filter);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(MedicineType entity)
        {
            try
            {
                MedicineType dbMedicinetype = Get(s => s.Id == entity.Id);
                //dbMedicinetype.Name = entity.Name;
                //dbMedicinetype.Cost = entity.Cost;
                dbMedicinetype = entity;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
