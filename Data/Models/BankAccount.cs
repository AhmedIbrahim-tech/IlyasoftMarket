using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("BankAccount")]
public partial class BankAccount
{
    [Key]
    [Column("BankAccountID")]
    public int BankAccountId { get; set; }

    [Column("PaymentTypeID")]
    public int PaymentTypeId { get; set; }

    [StringLength(500)]
    public string BankName { get; set; } = null!;

    [StringLength(500)]
    public string AccountTitle { get; set; } = null!;

    [StringLength(500)]
    public string AccountNo { get; set; } = null!;

    [Column("IBANNo")]
    [StringLength(500)]
    public string Ibanno { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(250)]
    public string CreateBy { get; set; } = null!;

    [ForeignKey("CreateById")]
    [InverseProperty("BankAccounts")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("BankAccounts")]
    public virtual PaymentType PaymentType { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("BankAccounts")]
    public virtual Status Status { get; set; } = null!;
}
