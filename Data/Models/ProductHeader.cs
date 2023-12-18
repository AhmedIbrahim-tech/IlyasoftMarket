using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("ProductHeader")]
public partial class ProductHeader
{
    [Key]
    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    [Column("SubCategoryID")]
    public int SubCategoryId { get; set; }

    [StringLength(250)]
    public string ProductTitle { get; set; } = null!;

    [Column("BrandID")]
    public int BrandId { get; set; }

    [Column("UpdateByID")]
    public int UpdateById { get; set; }

    [StringLength(250)]
    public string UpdateBy { get; set; } = null!;

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(250)]
    public string CreateBy { get; set; } = null!;

    public string ProductInformation { get; set; } = null!;

    [Column("SKUCode")]
    [StringLength(50)]
    public string Skucode { get; set; } = null!;

    [ForeignKey("BrandId")]
    [InverseProperty("ProductHeaders")]
    public virtual Brand Brand { get; set; } = null!;

    [ForeignKey("CreateById")]
    [InverseProperty("ProductHeaderCreateByNavigations")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [InverseProperty("ProductHeader")]
    public virtual ICollection<CustomerReview> CustomerReviews { get; set; } = new List<CustomerReview>();

    [InverseProperty("ProductHeader")]
    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();

    [InverseProperty("ProductHeader")]
    public virtual ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();

    [InverseProperty("ProductHeader")]
    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    [InverseProperty("ProductHeader")]
    public virtual ICollection<SeasonDiscount> SeasonDiscounts { get; set; } = new List<SeasonDiscount>();

    [ForeignKey("UpdateById")]
    [InverseProperty("ProductHeaderUpdateByNavigations")]
    public virtual User UpdateByNavigation { get; set; } = null!;

    [InverseProperty("ProductHeader")]
    public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
}
