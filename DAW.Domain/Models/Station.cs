using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.Models
{
    public class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TrainStation> TrainStations { get; set; }
    }
}
