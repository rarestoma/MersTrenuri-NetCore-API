using System;
using System.Collections.Generic;
using System.Text;
using DAW.Domain.Models.BaseModels;

namespace DAW.Domain.Models
{
    public class Station : BaseEntity
    {
        //public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TrainStation> TrainStations { get; set; }
    }
}
