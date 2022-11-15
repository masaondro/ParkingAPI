using System;

namespace ParkingAPI.Domain.Base
{
    /// <summary>
    /// Base entities class
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public Guid Id { get; set; }
    }
}