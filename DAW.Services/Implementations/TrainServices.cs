using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Services.Implementations
{
    public class TrainServices : BaseServices, ITrainServices
    {
        public ITrainRepository TrainRepository { get; }

        public TrainServices(HotelDbContext context, ITrainRepository trainRepository) : base(context)
        {
            TrainRepository = trainRepository;
        }
    }
}
