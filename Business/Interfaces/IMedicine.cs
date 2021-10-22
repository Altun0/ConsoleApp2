using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IMedicine
    {
        Medicine Create(Medicine medicine);

        Medicine Update(int Id, Medicine medicine);

        Medicine Delete(int Id);

        Medicine Get(int Id);

        Medicine Get(string Name);

        List<Medicine> GetAll();

        List<Medicine> GetAll(int Cost);



    }
}
