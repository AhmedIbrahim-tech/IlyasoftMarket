using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddressType> AddressTypes { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ColorType> ColorTypes { get; set; }

    public virtual DbSet<Compare> Compares { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CustomerReview> CustomerReviews { get; set; }

    public virtual DbSet<CustomerReviewImage> CustomerReviewImages { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<MainCategory> MainCategories { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderHeader> OrderHeaders { get; set; }

    public virtual DbSet<OrderPayment> OrderPayments { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<ProductDetail> ProductDetails { get; set; }

    public virtual DbSet<ProductFeature> ProductFeatures { get; set; }

    public virtual DbSet<ProductHeader> ProductHeaders { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<Season> Seasons { get; set; }

    public virtual DbSet<SeasonDiscount> SeasonDiscounts { get; set; }

    public virtual DbSet<ShippingFee> ShippingFees { get; set; }

    public virtual DbSet<SizeLevel> SizeLevels { get; set; }

    public virtual DbSet<SizeType> SizeTypes { get; set; }

    public virtual DbSet<SizeTypeByLevel> SizeTypeByLevels { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAddress> UserAddresses { get; set; }

    public virtual DbSet<UserStatus> UserStatuses { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<WishList> WishLists { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.BankAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccount_User");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.BankAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccount_PaymentType");

            entity.HasOne(d => d.Status).WithMany(p => p.BankAccounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccount_Status");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasOne(d => d.Status).WithMany(p => p.Brands)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Brand_Status");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasOne(d => d.Discount).WithMany(p => p.Carts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cart_Discount");

            entity.HasOne(d => d.ProductDetails).WithMany(p => p.Carts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cart_ProductDetails");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.Cities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_City_Country");
        });

        modelBuilder.Entity<ColorType>(entity =>
        {
            entity.HasOne(d => d.Status).WithMany(p => p.ColorTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ColorType_Status");
        });

        modelBuilder.Entity<Compare>(entity =>
        {
            entity.HasOne(d => d.CompareUser).WithMany(p => p.Compares)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compare_User");
        });

        modelBuilder.Entity<CustomerReview>(entity =>
        {
            entity.HasOne(d => d.CustomerReviewUser).WithMany(p => p.CustomerReviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReview_User");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.CustomerReviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReview_OrderHeader");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.CustomerReviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReview_ProductHeader");

            entity.HasOne(d => d.Status).WithMany(p => p.CustomerReviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReview_Status");
        });

        modelBuilder.Entity<CustomerReviewImage>(entity =>
        {
            entity.HasOne(d => d.CustomerReview).WithMany(p => p.CustomerReviewImages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReviewImage_CustomerReview");

            entity.HasOne(d => d.Status).WithMany(p => p.CustomerReviewImages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerReviewImage_Status");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.DiscountCreateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discount_User");

            entity.HasOne(d => d.Status).WithMany(p => p.Discounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discount_Status");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.DiscountUpdateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discount_User1");
        });

        modelBuilder.Entity<MainCategory>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.MainCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MainCategory_User");

            entity.HasOne(d => d.Status).WithMany(p => p.MainCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MainCategory_Status");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasOne(d => d.Discount).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Discount");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_OrderHeader");

            entity.HasOne(d => d.ProductDetails).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_ProductDetails");
        });

        modelBuilder.Entity<OrderHeader>(entity =>
        {
            entity.Property(e => e.OrderHeaderId).ValueGeneratedNever();

            entity.HasOne(d => d.CustomerUser).WithMany(p => p.OrderHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHeader_User");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.OrderHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHeader_OrderStatus");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.OrderHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHeader_PaymentType");

            entity.HasOne(d => d.ShippingFee).WithMany(p => p.OrderHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHeader_ShippingFee");

            entity.HasOne(d => d.UserAddress).WithMany(p => p.OrderHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHeader_UserAddress");
        });

        modelBuilder.Entity<OrderPayment>(entity =>
        {
            entity.HasOne(d => d.OrderHeader).WithMany(p => p.OrderPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderPayment_OrderHeader");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.OrderPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderPayment_PaymentStatus");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.OrderPayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderPayment_PaymentType");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasOne(d => d.Status).WithMany(p => p.OrderStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderStatus_Status");
        });

        modelBuilder.Entity<ProductDetail>(entity =>
        {
            entity.HasOne(d => d.ColorType).WithMany(p => p.ProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_ColorType");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.ProductDetailCreateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_User");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.ProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_ProductHeader");

            entity.HasOne(d => d.SizeTypeLevel).WithMany(p => p.ProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_SizeTypeByLevel");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_Status");

            entity.HasOne(d => d.Unit).WithMany(p => p.ProductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_Unit");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.ProductDetailUpdateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductDetails_User1");
        });

        modelBuilder.Entity<ProductFeature>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.ProductFeatureCreateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFeature_User");

            entity.HasOne(d => d.ProductHeader).WithMany(p => p.ProductFeatures)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFeature_ProductHeader");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductFeatures)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFeature_Status");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.ProductFeatureUpdateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductFeature_User1");
        });

        modelBuilder.Entity<ProductHeader>(entity =>
        {
            entity.HasOne(d => d.Brand).WithMany(p => p.ProductHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductHeader_Brand");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.ProductHeaderCreateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductHeader_User");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.ProductHeaderUpdateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductHeader_User1");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.HasOne(d => d.ProductHeader).WithMany(p => p.ProductTags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTag_ProductHeader");

            entity.HasOne(d => d.Status).WithMany(p => p.ProductTags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTag_Status");

            entity.HasOne(d => d.Tag).WithMany(p => p.ProductTags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTag_Tag");
        });

        modelBuilder.Entity<Season>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.Seasons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Season_User");
        });

        modelBuilder.Entity<SeasonDiscount>(entity =>
        {
            entity.HasOne(d => d.ProductHeader).WithMany(p => p.SeasonDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeasonDiscount_ProductHeader");

            entity.HasOne(d => d.Season).WithMany(p => p.SeasonDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeasonDiscount_Season");

            entity.HasOne(d => d.Status).WithMany(p => p.SeasonDiscounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeasonDiscount_Status");
        });

        modelBuilder.Entity<ShippingFee>(entity =>
        {
            entity.HasOne(d => d.City).WithMany(p => p.ShippingFees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingFee_City");

            entity.HasOne(d => d.Status).WithMany(p => p.ShippingFees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShippingFee_Status");
        });

        modelBuilder.Entity<SizeTypeByLevel>(entity =>
        {
            entity.HasOne(d => d.Gender).WithMany(p => p.SizeTypeByLevels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SizeTypeByLevel_Gender");

            entity.HasOne(d => d.SizeLevel).WithMany(p => p.SizeTypeByLevels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SizeTypeByLevel_SizeLevel");

            entity.HasOne(d => d.SizeType).WithMany(p => p.SizeTypeByLevels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SizeTypeByLevel_SizeType");

            entity.HasOne(d => d.Status).WithMany(p => p.SizeTypeByLevels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SizeTypeByLevel_Status");
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.SubCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubCategory_User");

            entity.HasOne(d => d.MainCategory).WithMany(p => p.SubCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubCategory_MainCategory");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Gender).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Gender");

            entity.HasOne(d => d.UserStatus).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_UserStatus");

            entity.HasOne(d => d.UserType).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_UserType");
        });

        modelBuilder.Entity<UserAddress>(entity =>
        {
            entity.HasOne(d => d.AddressType).WithMany(p => p.UserAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAddress_AddressType");

            entity.HasOne(d => d.City).WithMany(p => p.UserAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAddress_City");

            entity.HasOne(d => d.Status).WithMany(p => p.UserAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAddress_Status");

            entity.HasOne(d => d.User).WithMany(p => p.UserAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserAddress_User");
        });

        modelBuilder.Entity<WishList>(entity =>
        {
            entity.HasOne(d => d.ProductHeader).WithMany(p => p.WishLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WishList_ProductHeader");

            entity.HasOne(d => d.WishListUser).WithMany(p => p.WishLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WishList_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
