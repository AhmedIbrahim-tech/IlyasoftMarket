using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Brand")]
public partial class Brand
{
    [Key]
    [Column("BrandID")]
    public int BrandId { get; set; }

    [StringLength(250)]
    public string BrandTitle { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [InverseProperty("Brand")]
    public virtual ICollection<ProductHeader> ProductHeaders { get; set; } = new List<ProductHeader>();

    [ForeignKey("StatusId")]
    [InverseProperty("Brands")]
    public virtual Status Status { get; set; } = null!;
}
