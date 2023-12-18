using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Discount")]
public partial class Discount
{
    [Key]
    [Column("DiscountID")]
    public int DiscountId { get; set; }

    [StringLength(250)]
    public string DiscountTitle { get; set; } = null!;

    [StringLength(50)]
    public string CouponCode { get; set; } = null!;

    public string DiscountDescrption { get; set; } = null!;

    public double DiscountPercent { get; set; }

    [Column("StatusID")]
    public int StatusId { get; set; }

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(250)]
    public string CreateBy { get; set; } = null!;

    [Column("UpdateByID")]
    public int UpdateById { get; set; }

    [StringLength(250)]
    public string UpdateBy { get; set; } = null!;

    [InverseProperty("Discount")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    [ForeignKey("CreateById")]
    [InverseProperty("DiscountCreateByNavigations")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [InverseProperty("Discount")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("StatusId")]
    [InverseProperty("Discounts")]
    public virtual Status Status { get; set; } = null!;

    [ForeignKey("UpdateById")]
    [InverseProperty("DiscountUpdateByNavigations")]
    public virtual User UpdateByNavigation { get; set; } = null!;
}
