using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("PaymentStatus")]
public partial class PaymentStatus
{
    [Key]
    [Column("PaymentStatusID")]
    public int PaymentStatusId { get; set; }

    [Column("PaymentStatus")]
    [StringLength(250)]
    public string PaymentStatus1 { get; set; } = null!;

    [InverseProperty("PaymentStatus")]
    public virtual ICollection<OrderPayment> OrderPayments { get; set; } = new List<OrderPayment>();
}
