using System.ComponentModel.DataAnnotations;

namespace Railway_Reservation.Models
{
    public class BaseDto<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
