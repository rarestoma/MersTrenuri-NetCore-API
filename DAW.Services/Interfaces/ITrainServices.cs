using DAW.Domain.EF.IRepositories;
//using System;
//using System.Collections.Generic;
//using System.Text;

namespace DAW.Services.Interfaces
{
    public interface ITrainServices : IBaseServices
    {
        ITrainRepository TrainRepository { get; }
    }
}
