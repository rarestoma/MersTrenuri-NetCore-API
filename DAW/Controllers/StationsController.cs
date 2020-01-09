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
    public class StationsController : ControllerBase
    {
        private readonly IStationServices _stationServices;

        public StationsController(IStationServices stationServices)
        {
            _stationServices = stationServices;
        }

        [HttpGet("GetAllStations")]
        public async Task<ObjectResult> GetAllStationsAsync()
        {
            List<Station> result = await _stationServices.StationRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("GetStation/{id}")]
        public async Task<ObjectResult> GetStationAsync([FromRoute] int id)
        {
            Station result = await _stationServices.StationRepository.GetByIdAsync(id);

            return Ok(result);
        }


        [HttpPost("CreateStation")]
        public async Task<ObjectResult> CreateStationAsync([FromBody] GeneralStationRequest request)
        {
            Station result = await _stationServices.StationRepository.CreateAsync(request.ToDTO());
            await _stationServices.CommitChanges();

            return Ok(result);
        }

        [HttpPut("UpdateStation/{id}")]
        public async Task<ObjectResult> UpdateStationAsync([FromBody] GeneralStationRequest request, [FromRoute] int id)
        {
            Station result = _stationServices.StationRepository.Update(request.ToDTO(id));
            await _stationServices.CommitChanges();

            return Ok(result);
        }

        [HttpDelete("DeleteStation/{id}")]
        public async Task<ObjectResult> DeleteStationAsync([FromRoute] int id)
        {
            Station station = await _stationServices.StationRepository.GetByIdAsync(id);
            _stationServices.StationRepository.Delete(station);
            await _stationServices.CommitChanges();

            return Ok(station);
        }
    }
}
