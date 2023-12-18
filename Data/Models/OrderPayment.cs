using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("OrderPayment")]
public partial class OrderPayment
{
    [Key]
    [Column("OrderPaymentID")]
    public int OrderPaymentId { get; set; }

    [Column("OrderHeaderID")]
    public int OrderHeaderId { get; set; }

    public double TotalPayment { get; set; }

    public string PaymentGateway { get; set; } = null!;

    [Column("PaymentTypeID")]
    public int PaymentTypeId { get; set; }

    [Column("PaymentStatusID")]
    public int PaymentStatusId { get; set; }

    [ForeignKey("OrderHeaderId")]
    [InverseProperty("OrderPayments")]
    public virtual OrderHeader OrderHeader { get; set; } = null!;

    [ForeignKey("PaymentStatusId")]
    [InverseProperty("OrderPayments")]
    public virtual PaymentStatus PaymentStatus { get; set; } = null!;

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("OrderPayments")]
    public virtual PaymentType PaymentType { get; set; } = null!;
}
