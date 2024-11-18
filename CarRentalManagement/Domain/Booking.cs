namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime DataOut { get; set; }
        public DateTime DataIn { get; set; }

        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
    }
}
