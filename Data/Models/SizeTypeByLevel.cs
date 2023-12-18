using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("SizeTypeByLevel")]
public partial class SizeTypeByLevel
{
    [Key]
    [Column("SizeTypeByLevelID")]
    public int SizeTypeByLevelId { get; set; }

    [Column("SizeTypeID")]
    public int SizeTypeId { get; set; }

    [Column("SizeLevelID")]
    public int SizeLevelId { get; set; }

    [StringLength(50)]
    public string SizeLevelValue { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [Column("GenderID")]
    public int GenderId { get; set; }

    [ForeignKey("GenderId")]
    [InverseProperty("SizeTypeByLevels")]
    public virtual Gender Gender { get; set; } = null!;

    [InverseProperty("SizeTypeLevel")]
    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();

    [ForeignKey("SizeLevelId")]
    [InverseProperty("SizeTypeByLevels")]
    public virtual SizeLevel SizeLevel { get; set; } = null!;

    [ForeignKey("SizeTypeId")]
    [InverseProperty("SizeTypeByLevels")]
    public virtual SizeType SizeType { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("SizeTypeByLevels")]
    public virtual Status Status { get; set; } = null!;
}
