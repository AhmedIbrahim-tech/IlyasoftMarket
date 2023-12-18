using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("SizeLevel")]
public partial class SizeLevel
{
    [Key]
    [Column("SizeLevelID")]
    public int SizeLevelId { get; set; }

    [Column("SizeLevel")]
    [StringLength(50)]
    public string SizeLevel1 { get; set; } = null!;

    [InverseProperty("SizeLevel")]
    public virtual ICollection<SizeTypeByLevel> SizeTypeByLevels { get; set; } = new List<SizeTypeByLevel>();
}
