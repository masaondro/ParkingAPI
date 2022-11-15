namespace ParkingAPI.Contracts.Parking
{
    public class ParkingDTO : BaseDTO
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