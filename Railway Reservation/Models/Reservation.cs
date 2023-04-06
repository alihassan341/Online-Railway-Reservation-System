using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace Railway_Reservation.Models
{
    public class Reservation :BaseDto<int>
    {
        [ForeignKey("Train")]
        public int? TrainId { get; set; }
        public Train? Train { get; set; } 

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }
        [ForeignKey("User")]
        public int UserId{ get; set; }
        public User? User { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public float TotalAmount { get; set; }
        public int TrainClass { get; set; }
        

    }
}
