
using core.entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Car: IEntity
    {
        public string CarName { get; set; }
        public int Id { get; set; }
        public int? BrandId { get; set; }
        public int? ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }


    }
}
