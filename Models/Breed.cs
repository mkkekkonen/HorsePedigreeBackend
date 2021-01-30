using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace horsesBackend.Models
{
  [Table("Breeds")]
  public class Breed
  {
    [Key]
    public int Id { get; set; }
    public string NameEn { get; set; }
    public Horse[] Horses { get; set; }
  }
}
