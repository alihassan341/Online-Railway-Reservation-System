using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Railway_Reservation.Models
{
    public class TrainDetail: BaseDto<long>
    {
        [Required]                  
        //[Index(IsUnique = true)]       
        public int TrainNo { get; set; } 
        [Required]
        [StringLength(50)]
        public string TrainName { get; set; }
        [Required]
        [StringLength(50)]
        public string RouteFrom { get; set; } 
        [Required]
        [StringLength(50)]
        public string RouteTo { get; set; } 
        [Required]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; } 
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int TotalCompartments { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int Total1AC { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int Total2AC { get; set; } 
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int Total3AC { get; set; } 
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int TotalSleeper { get; set; } 
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int TotalGeneral { get; set; }
    }


}
