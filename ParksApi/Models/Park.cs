using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    [StringLength(15, MinimumLength = 4, ErrorMessage = "Please write out the entire state name.")]
    public string State { get; set; }
    public bool NationalPark { get; set; }
    public bool StatePark { get; set; } = false;
  }
}