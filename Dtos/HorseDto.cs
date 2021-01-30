using System;

using horsesBackend.Models;
using horsesBackend.Enums;

namespace horsesBackend.Dtos
{
  public class HorseDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int BreedId { get; set; }
    public Gender Gender { get; set; }
    public Color Color { get; set; }
    public string RegistrationNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int HeightCm { get; set; }
    public string SireName { get; set; }
    public int? SireId { get; set; }
    public string DamName { get; set; }
    public int? DamId { get; set; }
  }
}
