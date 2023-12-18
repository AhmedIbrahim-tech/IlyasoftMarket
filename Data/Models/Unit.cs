using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Unit")]
public partial class Unit
{
    [Key]
    [Column("UnitID")]
    public int UnitId { get; set; }

    [StringLength(50)]
    public string UnitTitle { get; set; } = null!;

    [InverseProperty("Unit")]
    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
}
