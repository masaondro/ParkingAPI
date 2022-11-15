using System;

namespace ParkingAPI.Contracts
{
    /// <summary>
    /// Base class DTO.
    /// </summary>
    public class BaseDTO
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public Guid Id { get; set; }
    }
}