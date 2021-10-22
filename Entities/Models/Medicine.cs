using System;
using Entities.Interface;


namespace Entities.Models
{
    public class Medicine:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
