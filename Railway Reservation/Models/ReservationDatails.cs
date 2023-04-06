using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Reservation.Models
{
    public class ReservationDatails :BaseDto<int>
    {
        [ForeignKey("Reservation")]
        public  int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public int PasengeraName { get; set; }
        public string Cnic { get; set; }
    }
}
