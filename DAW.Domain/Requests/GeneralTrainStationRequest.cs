using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.Requests
{
    public class GeneralTrainStationRequest
    {
        public int TrainID { get; set; } //FK
        public int StationID { get; set; } //FK

        public int StationNumber { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime LeftTime { get; set; }
    }
}
