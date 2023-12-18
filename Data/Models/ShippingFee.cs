using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("ShippingFee")]
public partial class ShippingFee
{
    [Key]
    [Column("ShippingFeeID")]
    public int ShippingFeeId { get; set; }

    [Column("CityID")]
    public int CityId { get; set; }

    [Column("ShippingFee")]
    public double ShippingFee1 { get; set; }

    public int DeliveryTimeDays { get; set; }

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("CityId")]
    [InverseProperty("ShippingFees")]
    public virtual City City { get; set; } = null!;

    [InverseProperty("ShippingFee")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [ForeignKey("StatusId")]
    [InverseProperty("ShippingFees")]
    public virtual Status Status { get; set; } = null!;
}
