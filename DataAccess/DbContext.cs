using System;
using System.Collections.Generic;
using Entities.Models;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Medicine> Medicines { get; }

        public static List<MedicineType> MedicineTypes { get; }

        static DbContext()
        {
            Medicines = new List<Medicine>();
            MedicineTypes = new List<MedicineType>();

        }
    }
}



