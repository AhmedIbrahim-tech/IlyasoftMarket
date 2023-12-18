using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("PaymentType")]
public partial class PaymentType
{
    [Key]
    [Column("PaymentTypeID")]
    public int PaymentTypeId { get; set; }

    [Column("PaymentType")]
    [StringLength(250)]
    public string PaymentType1 { get; set; } = null!;

    [InverseProperty("PaymentType")]
    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<OrderPayment> OrderPayments { get; set; } = new List<OrderPayment>();
}
