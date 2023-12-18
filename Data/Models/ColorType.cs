using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("ColorType")]
public partial class ColorType
{
    [Key]
    [Column("ColorTypeID")]
    public int ColorTypeId { get; set; }

    [StringLength(250)]
    public string ColorTitle { get; set; } = null!;

    [StringLength(50)]
    public string ColorCode { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [InverseProperty("ColorType")]
    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();

    [ForeignKey("StatusId")]
    [InverseProperty("ColorTypes")]
    public virtual Status Status { get; set; } = null!;
}
