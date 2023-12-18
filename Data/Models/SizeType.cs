using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("SizeType")]
public partial class SizeType
{
    [Key]
    [Column("SizeTypeID")]
    public int SizeTypeId { get; set; }

    [Column("SizeType")]
    [StringLength(50)]
    public string SizeType1 { get; set; } = null!;

    [InverseProperty("SizeType")]
    public virtual ICollection<SizeTypeByLevel> SizeTypeByLevels { get; set; } = new List<SizeTypeByLevel>();
}
