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
    public class TrainsController : ControllerBase
    {
        private readonly ITrainServices _trainServices;

        public TrainsController(ITrainServices trainServices)
        {
            _trainServices = trainServices;
        }

        [HttpGet("GetAllTrains")]
        public async Task<ObjectResult> GetAllTrainsAsync()
        {
            List<Train> result = await _trainServices.TrainRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("GetTrain/{id}")]
        public async Task<ObjectResult> GetTrainAsync([FromRoute] int id)
        {
            Train result = await _trainServices.TrainRepository.GetByIdAsync(id);

            return Ok(result);
        }


        [HttpPost("CreateTrain")]
        public async Task<ObjectResult> CreateTrainAsync([FromBody] GeneralTrainRequest request)
        {
            Train result = await _trainServices.TrainRepository.CreateAsync(request.ToDTO());
            await _trainServices.CommitChanges();

            return Ok(result);
        }

        [HttpPut("UpdateTrain/{id}")]
        public async Task<ObjectResult> UpdateTrainAsync([FromBody] GeneralTrainRequest request, [FromRoute] int id)
        {
            Train result = _trainServices.TrainRepository.Update(request.ToDTO(id));
            await _trainServices.CommitChanges();

            return Ok(result);
        }

        [HttpDelete("DeleteTrain/{id}")]
        public async Task<ObjectResult> DeleteTrainAsync([FromRoute] int id)
        {
            Train train = await _trainServices.TrainRepository.GetByIdAsync(id);
            _trainServices.TrainRepository.Delete(train);
            await _trainServices.CommitChanges();

            return Ok(train);
        }
    }
}
