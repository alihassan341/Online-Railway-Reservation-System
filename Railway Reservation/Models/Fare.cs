using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Reservation.Models
{
    public class Fare :BaseDto<int>
    {
        [ForeignKey("Train")]
        public int TrainId { get; set; }
        public Train? Train { get; set; }
        public float EconomyFare { get; set;}
        public float AcStandardFare { get; set; }
        public float BusinessFare { get; set; }
    }
}
