using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using horsesBackend.Enums;

namespace horsesBackend.Models
{
  [Table("Horses")]
  public class Horse
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    [ForeignKey("BreedId")]
    public Breed Breed { get; set; }
    public int BreedId { get; set; }
    public Gender Gender { get; set; }
    public string RegistrationNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int HeightCm { get; set; }
    public Color Color { get; set; }
    public string SireName { get; set; }
    [ForeignKey("SireId")]
    public Horse Sire { get; set; }
    public int? SireId { get; set; }
    public string DamName { get; set; }
    [ForeignKey("DamId")]
    public Horse Dam { get; set; }
    public int? DamId { get; set; }
  }
}
