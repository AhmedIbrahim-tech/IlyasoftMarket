using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class OrderDetail
{
    [Key]
    [Column("OrderDetailsID")]
    public int OrderDetailsId { get; set; }

    [Column("OrderHeaderID")]
    public int OrderHeaderId { get; set; }

    [Column("ProductDetailsID")]
    public int ProductDetailsId { get; set; }

    public double UnitPrice { get; set; }

    public int Quantity { get; set; }

    [Column("DiscountID")]
    public int DiscountId { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("OrderDetails")]
    public virtual Discount Discount { get; set; } = null!;

    [ForeignKey("OrderHeaderId")]
    [InverseProperty("OrderDetails")]
    public virtual OrderHeader OrderHeader { get; set; } = null!;

    [ForeignKey("ProductDetailsId")]
    [InverseProperty("OrderDetails")]
    public virtual ProductDetail ProductDetails { get; set; } = null!;
}
