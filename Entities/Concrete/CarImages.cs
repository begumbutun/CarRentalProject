﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.CarImages
{
    public class CarImages:IEntity 
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public String ImagePath { get; set; }
        public DateTime Date { get; set; }

    }
}
