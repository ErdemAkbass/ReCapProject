﻿using core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public string BrandName { get; set; }
        public int Id { get; set; }
    }
}
