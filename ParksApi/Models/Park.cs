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
    [Range(4, 14, ErrorMessage = "Must be the full state name.")]
    public string State { get; set; }
  }
}