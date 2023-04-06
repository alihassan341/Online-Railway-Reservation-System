using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Railway_Reservation.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PassengerDetails : BaseDto<int>
{
   
    [Required]
    //[Index(IsUnique = true)]
    public int PnrNo { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public char Gender { get; set; }

    [Required]
    public int TotalPassenger { get; set; }

    [Required]
    public string DateOfTravel { get; set; }

    [Required]
    public string Class { get; set; }

    [Required]
    public string Password { get; set; }

    public TrainDetail TrainDetails { get; set; }
    public string TrainNo { get; set; }
}
