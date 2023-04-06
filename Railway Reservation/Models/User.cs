namespace Railway_Reservation.Models
{
    public class User :BaseDto<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cnic { get; set; }
        public string Password { get; set; }        
    }
}
