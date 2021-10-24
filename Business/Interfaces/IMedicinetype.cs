using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IMedicinetype
    {
        Medicinetype Create(Medicinetype medicinetype, string medicinetypeName);

        Medicinetype Delete(int id);

        Medicinetype Update(Medicinetype medicine, string medicineName);

        Medicinetype Get(int id);

        List<Medicinetype> Get(string name);

        List<Medicinetype> GetAll(string medicinename);

        List<Medicinetype> GetAll();




    }
}
