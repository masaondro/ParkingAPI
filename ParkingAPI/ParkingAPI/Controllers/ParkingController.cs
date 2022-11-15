using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkingAPI.AppServices.Services.Parking;
using ParkingAPI.Contracts.Parking;

namespace ParkingAPI.Controllers
{
    /// <summary>
    /// Parking
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ParkingController : ControllerBase
    {
        private readonly ILogger<ParkingController> _logger;
        private readonly IParkingService _parkingService;

        public ParkingController(ILogger<ParkingController> logger, IParkingService parkingService)
        {
            _logger = logger;
            _parkingService = parkingService;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _parkingService.GetAllPost();
            return Ok(result);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ParkingDTO model)
        {
            await _parkingService.AddAsync(model);
            return Created(string.Empty, null);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ParkingDTO model)
        {
            var result = await _parkingService.Update(model);
            return Ok(result);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("{id:guid}")]
        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            //Guid.TryParse(id, out var postId);
            await _parkingService.DeleteAsync(id);
            return Ok();
        }
    }
}