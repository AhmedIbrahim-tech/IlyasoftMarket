using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Status")]
public partial class Status
{
    [Key]
    [Column("StatusID")]
    public int StatusId { get; set; }

    [StringLength(150)]
    public string StatusTitle { get; set; } = null!;

    [InverseProperty("Status")]
    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    [InverseProperty("Status")]
    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();

    [InverseProperty("Status")]
    public virtual ICollection<ColorType> ColorTypes { get; set; } = new List<ColorType>();

    [InverseProperty("Status")]
    public virtual ICollection<CustomerReviewImage> CustomerReviewImages { get; set; } = new List<CustomerReviewImage>();

    [InverseProperty("Status")]
    public virtual ICollection<CustomerReview> CustomerReviews { get; set; } = new List<CustomerReview>();

    [InverseProperty("Status")]
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    [InverseProperty("Status")]
    public virtual ICollection<MainCategory> MainCategories { get; set; } = new List<MainCategory>();

    [InverseProperty("Status")]
    public virtual ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductFeature> ProductFeatures { get; set; } = new List<ProductFeature>();

    [InverseProperty("Status")]
    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    [InverseProperty("Status")]
    public virtual ICollection<SeasonDiscount> SeasonDiscounts { get; set; } = new List<SeasonDiscount>();

    [InverseProperty("Status")]
    public virtual ICollection<ShippingFee> ShippingFees { get; set; } = new List<ShippingFee>();

    [InverseProperty("Status")]
    public virtual ICollection<SizeTypeByLevel> SizeTypeByLevels { get; set; } = new List<SizeTypeByLevel>();

    [InverseProperty("Status")]
    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();
}
