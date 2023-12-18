using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Cart")]
public partial class Cart
{
    [Key]
    [Column("CartID")]
    public int CartId { get; set; }

    [Column("ProductDetailsID")]
    public int ProductDetailsId { get; set; }

    public int Quantity { get; set; }

    [Column("DiscountID")]
    public int DiscountId { get; set; }

    [StringLength(50)]
    public string UniqueNo { get; set; } = null!;

    public double UnitPrice { get; set; }

    [ForeignKey("DiscountId")]
    [InverseProperty("Carts")]
    public virtual Discount Discount { get; set; } = null!;

    [ForeignKey("ProductDetailsId")]
    [InverseProperty("Carts")]
    public virtual ProductDetail ProductDetails { get; set; } = null!;
}
