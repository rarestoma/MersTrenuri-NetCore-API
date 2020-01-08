using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.EF.Repositories
{
    public class StationRepository : BaseRepository<Station>, IStationRepository
    {
        public StationRepository(HotelDbContext context) : base(context)
        {
        }
    }
}
