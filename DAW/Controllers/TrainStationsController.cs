using DAW.Domain.ExtensionMethods;
using DAW.Domain.Models;
using DAW.Domain.Requests;
using DAW.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

//using System;
//using System.Linq;


namespace DAW.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainStationsController : ControllerBase
    {
        private readonly ITrainStationServices _trainStationServices;

        public TrainStationsController(ITrainStationServices trainStationServices)
        {
            _trainStationServices = trainStationServices;
        }

        [HttpGet("GetAllTrainStations")]
        public async Task<ObjectResult> GetAllTrainStationsAsync()
        {
            List<TrainStation> result = await _trainStationServices.TrainStationRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("GetTrainStation/{id}")]
        public async Task<ObjectResult> GetTrainStationAsync([FromRoute] int id)
        {
            TrainStation result = await _trainStationServices.TrainStationRepository.GetByIdAsync(id);

            return Ok(result);
        }


        [HttpPost("CreateTrainStation")]
        public async Task<ObjectResult> CreateTrainStationAsync([FromBody] GeneralTrainStationRequest request)
        {
            TrainStation result = await _trainStationServices.TrainStationRepository.CreateAsync(request.ToDTO());
            await _trainStationServices.CommitChanges();

            return Ok(result);
        }

        [HttpPut("UpdateTrainStation/{id}")]
        public async Task<ObjectResult> UpdateTrainStationAsync([FromBody] GeneralTrainStationRequest request, [FromRoute] int id)
        {
            TrainStation result = _trainStationServices.TrainStationRepository.Update(request.ToDTO(id));
            await _trainStationServices.CommitChanges();

            return Ok(result);
        }

        [HttpDelete("DeleteTrainStation/{id}")]
        public async Task<ObjectResult> DeleteTrainStationAsync([FromRoute] int id)
        {
            TrainStation trainStation = await _trainStationServices.TrainStationRepository.GetByIdAsync(id);
            _trainStationServices.TrainStationRepository.Delete(trainStation);
            await _trainStationServices.CommitChanges();

            return Ok(trainStation);
        }
    }
}
