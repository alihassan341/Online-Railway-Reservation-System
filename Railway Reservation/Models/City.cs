namespace Railway_Reservation.Models
{
    public class City :BaseDto<int>
    {
        public string Name { get; set; }
        public float Distance { get; set; }
    }
}
