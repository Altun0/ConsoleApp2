using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IMedicine
    {
        Medicinetype Create(Medicinetype medicine);

        Medicinetype Update(int Id, Medicinetype medicine);

        Medicinetype Delete(int Id);

        Medicinetype Get(int Id);

        Medicinetype Get(string Name);

        List<Medicinetype> GetAll();

        List<Medicinetype> GetAll(int Cost);



    }
}
