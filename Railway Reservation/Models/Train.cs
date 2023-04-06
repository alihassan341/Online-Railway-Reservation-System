namespace Railway_Reservation.Models
{
    public class Train :BaseDto<int>
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public bool IsActive{ get; set; }
        public int EconomySeats{ get; set; }
        public int BusinessSeats { get; set; }
        public int AcStandardSeats { get; set; }


    }
}
