using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.EF.Repositories
{
    public class TrainStationRepository : BaseRepository<TrainStation>, ITrainStationRepository
    {
        public TrainStationRepository(HotelDbContext context) : base(context)
        {
        }
    }
}
