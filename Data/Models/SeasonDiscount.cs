using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("SeasonDiscount")]
public partial class SeasonDiscount
{
    [Key]
    [Column("SeasonDiscountID")]
    public int SeasonDiscountId { get; set; }

    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    public int DiscountPercent { get; set; }

    [Column("StatusID")]
    public int StatusId { get; set; }

    [Column("SeasonID")]
    public int SeasonId { get; set; }

    [ForeignKey("ProductHeaderId")]
    [InverseProperty("SeasonDiscounts")]
    public virtual ProductHeader ProductHeader { get; set; } = null!;

    [ForeignKey("SeasonId")]
    [InverseProperty("SeasonDiscounts")]
    public virtual Season Season { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("SeasonDiscounts")]
    public virtual Status Status { get; set; } = null!;
}
