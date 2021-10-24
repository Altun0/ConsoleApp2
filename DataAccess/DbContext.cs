using System;
using System.Collections.Generic;
using Entities.Models;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Medicinetype> Medicines { get; }

        public static List<MedicineType> MedicineTypes { get; }

        static DbContext()
        {
            Medicines = new List<Medicinetype>();

            MedicineTypes = new List<MedicineType>();

        }
    }
}



