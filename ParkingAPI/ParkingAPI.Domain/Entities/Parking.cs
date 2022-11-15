using ParkingAPI.Domain.Base;

namespace ParkingAPI.Domain.Entities
{
    /// <summary>
    /// The parking entity
    /// </summary>
    public class Parking : EntityBase
    {
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// Status
        /// </summary>
        public bool Status { get; set; }
        
        /// <summary>
        /// Usages (How many times it was used)
        /// </summary>
        public int Usages { get; set; }
        
    }
}