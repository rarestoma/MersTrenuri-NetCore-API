using DAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.Models
{
    public class Train : BaseEntity
    {
        //public string ID { get; set; }

        public string Rang { get; set; }

        public virtual ICollection<TrainStation> TrainStations { get; set; }

    }
}
