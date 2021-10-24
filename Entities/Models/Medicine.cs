using System;
using Entities.Interface;


namespace Entities.Models
{
    public class Medicinetype:IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Cost { get; set; }
    }
}
