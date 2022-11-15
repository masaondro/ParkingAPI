using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingAPI.Contracts.Parking;

namespace ParkingAPI.AppServices.Services.Parking
{
    /// <summary>
    /// Service for work with parking
    /// </summary>
    public interface IParkingService
    {
        /// <summary>
        /// Return all records.
        /// </summary>
        /// <returns></returns>
        Task<List<ParkingDTO>> GetAllPost();
        
        /// <summary>
        /// Add record.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task AddAsync(ParkingDTO model);
        
        /// <summary>
        /// Update record.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<ParkingDTO> Update(ParkingDTO model);
        
        /// <summary>
        /// Delete record.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
    }
}