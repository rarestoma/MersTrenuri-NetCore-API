using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Services.Implementations
{
    public class StationServices : BaseServices, IStationServices
    {
        public IStationRepository StationRepository { get; }

        public StationServices(HotelDbContext context, IStationRepository stationRepository) : base(context)
        {
            StationRepository = stationRepository;
        }
    }
}
