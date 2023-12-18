using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("OrderHeader")]
public partial class OrderHeader
{
    [Key]
    [Column("OrderHeaderID")]
    public int OrderHeaderId { get; set; }

    [Column("CustomerUserID")]
    public int CustomerUserId { get; set; }

    [Column("ShippingFeeID")]
    public int ShippingFeeId { get; set; }

    [Column("UserAddressID")]
    public int UserAddressId { get; set; }

    public double TotalCost { get; set; }

    public double DiscountAmount { get; set; }

    public double TotalPayment { get; set; }

    public DateOnly OrderDate { get; set; }

    public TimeOnly OrderTime { get; set; }

    public DateOnly ShippingDate { get; set; }

    [Column("OrderStatusID")]
    public int OrderStatusId { get; set; }

    [Column("PaymentTypeID")]
    public int PaymentTypeId { get; set; }

    [StringLength(250)]
    public string? TransectionNo { get; set; }

    public DateOnly? TransectionDate { get; set; }

    public TimeOnly? TransectionTime { get; set; }

    public string? PaymentReceiptSinapshot { get; set; }

    [InverseProperty("OrderHeader")]
    public virtual ICollection<CustomerReview> CustomerReviews { get; set; } = new List<CustomerReview>();

    [ForeignKey("CustomerUserId")]
    [InverseProperty("OrderHeaders")]
    public virtual User CustomerUser { get; set; } = null!;

    [InverseProperty("OrderHeader")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [InverseProperty("OrderHeader")]
    public virtual ICollection<OrderPayment> OrderPayments { get; set; } = new List<OrderPayment>();

    [ForeignKey("OrderStatusId")]
    [InverseProperty("OrderHeaders")]
    public virtual OrderStatus OrderStatus { get; set; } = null!;

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("OrderHeaders")]
    public virtual PaymentType PaymentType { get; set; } = null!;

    [ForeignKey("ShippingFeeId")]
    [InverseProperty("OrderHeaders")]
    public virtual ShippingFee ShippingFee { get; set; } = null!;

    [ForeignKey("UserAddressId")]
    [InverseProperty("OrderHeaders")]
    public virtual UserAddress UserAddress { get; set; } = null!;
}
