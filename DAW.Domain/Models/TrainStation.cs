using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.Models
{
    public class TrainStation
    {
        public int ID { get; set; }
        public int TrainID { get; set; } //FK
        public int StationID { get; set; } //FK

        public int StationNumber { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime LeftTime { get; set; }

        public virtual Station Station { get; set; }

        public virtual Train Train { get; set; }
    }
}
