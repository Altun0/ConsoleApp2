﻿using System;
namespace Entities.Interface
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }


    }
}
