using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [Column("UserTypeID")]
    public int UserTypeId { get; set; }

    [StringLength(150)]
    public string UserName { get; set; } = null!;

    [StringLength(150)]
    public string Password { get; set; } = null!;

    [StringLength(250)]
    public string EmailAddress { get; set; } = null!;

    [StringLength(250)]
    public string FirstName { get; set; } = null!;

    [StringLength(250)]
    public string LastName { get; set; } = null!;

    [StringLength(250)]
    public string ContactNo { get; set; } = null!;

    [Column("GenderID")]
    public int GenderId { get; set; }

    [Column("UserStatusID")]
    public int UserStatusId { get; set; }

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    [InverseProperty("CompareUser")]
    public virtual ICollection<Compare> Compares { get; set; } = new List<Compare>();

    [InverseProperty("CustomerReviewUser")]
    public virtual ICollection<CustomerReview> CustomerReviews { get; set; } = new List<CustomerReview>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<Discount> DiscountCreateByNavigations { get; set; } = new List<Discount>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<Discount> DiscountUpdateByNavigations { get; set; } = new List<Discount>();

    [ForeignKey("GenderId")]
    [InverseProperty("Users")]
    public virtual Gender Gender { get; set; } = null!;

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<MainCategory> MainCategories { get; set; } = new List<MainCategory>();

    [InverseProperty("CustomerUser")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<ProductDetail> ProductDetailCreateByNavigations { get; set; } = new List<ProductDetail>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<ProductDetail> ProductDetailUpdateByNavigations { get; set; } = new List<ProductDetail>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<ProductFeature> ProductFeatureCreateByNavigations { get; set; } = new List<ProductFeature>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<ProductFeature> ProductFeatureUpdateByNavigations { get; set; } = new List<ProductFeature>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<ProductHeader> ProductHeaderCreateByNavigations { get; set; } = new List<ProductHeader>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<ProductHeader> ProductHeaderUpdateByNavigations { get; set; } = new List<ProductHeader>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<Season> Seasons { get; set; } = new List<Season>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

    [InverseProperty("User")]
    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

    [ForeignKey("UserStatusId")]
    [InverseProperty("Users")]
    public virtual UserStatus UserStatus { get; set; } = null!;

    [ForeignKey("UserTypeId")]
    [InverseProperty("Users")]
    public virtual UserType UserType { get; set; } = null!;

    [InverseProperty("WishListUser")]
    public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
}
