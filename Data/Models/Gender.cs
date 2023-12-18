using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Gender")]
public partial class Gender
{
    [Key]
    [Column("GenderID")]
    public int GenderId { get; set; }

    [StringLength(250)]
    public string? GenderTitle { get; set; }

    [InverseProperty("Gender")]
    public virtual ICollection<SizeTypeByLevel> SizeTypeByLevels { get; set; } = new List<SizeTypeByLevel>();

    [InverseProperty("Gender")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
