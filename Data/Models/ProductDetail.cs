using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class ProductDetail
{
    [Key]
    [Column("ProductDetailsID")]
    public int ProductDetailsId { get; set; }

    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    [Column("ColorTypeID")]
    public int ColorTypeId { get; set; }

    [Column("SizeTypeLevelID")]
    public int SizeTypeLevelId { get; set; }

    [Column("UnitID")]
    public int UnitId { get; set; }

    public int Quantity { get; set; }

    public double UnitPrice { get; set; }

    [StringLength(50)]
    public string BarCode { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(150)]
    public string CreateBy { get; set; } = null!;

    [Column("UpdateByID")]
    public int UpdateById { get; set; }

    [StringLength(150)]
    public string UpdateBy { get; set; } = null!;

    [InverseProperty("ProductDetails")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    [ForeignKey("ColorTypeId")]
    [InverseProperty("ProductDetails")]
    public virtual ColorType ColorType { get; set; } = null!;

    [ForeignKey("CreateById")]
    [InverseProperty("ProductDetailCreateByNavigations")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [InverseProperty("ProductDetails")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("ProductHeaderId")]
    [InverseProperty("ProductDetails")]
    public virtual ProductHeader ProductHeader { get; set; } = null!;

    [ForeignKey("SizeTypeLevelId")]
    [InverseProperty("ProductDetails")]
    public virtual SizeTypeByLevel SizeTypeLevel { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ProductDetails")]
    public virtual Status Status { get; set; } = null!;

    [ForeignKey("UnitId")]
    [InverseProperty("ProductDetails")]
    public virtual Unit Unit { get; set; } = null!;

    [ForeignKey("UpdateById")]
    [InverseProperty("ProductDetailUpdateByNavigations")]
    public virtual User UpdateByNavigation { get; set; } = null!;
}
