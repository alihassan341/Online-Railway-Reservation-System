using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Reservation.Models
{
    public class Schedule :BaseDto<int>
    {
        [ForeignKey("Train")]
        public int TrainId { get; set; }
        public Train? Train { get; set; }
        [ForeignKey("CityDesination")]
        public int? Desination { get; set;}
        public City? CityDesination { get; set; }
        //[ForeignKey("CitySource")]
        public int? Source { get; set; }
        //public City? CitySource { get; set; }
        public bool IsUp { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
