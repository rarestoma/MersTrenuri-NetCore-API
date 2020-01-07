using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAW.Domain.EF.Repositories
{
    public class TrainRepository : BaseRepository<Train>, ITrainRepository
    {
        public TrainRepository(HotelDbContext context) : base(context)
        {
        }
    }
}
