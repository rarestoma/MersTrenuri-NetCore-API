using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Services.Implementations
{
    public class TrainStationServices : BaseServices, ITrainStationServices
    {
        public ITrainStationRepository TrainStationRepository { get; }

        public TrainStationServices(HotelDbContext context, ITrainStationRepository trainStationRepository) : base(context)
        {
            TrainStationRepository = trainStationRepository;
        }
    }
}
