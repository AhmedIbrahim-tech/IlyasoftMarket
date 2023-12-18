using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Compare")]
public partial class Compare
{
    [Key]
    [Column("CompareID")]
    public int CompareId { get; set; }

    [Column("CompareUserID")]
    public int CompareUserId { get; set; }

    [Column("ProductDetailsID")]
    public int ProductDetailsId { get; set; }

    [ForeignKey("CompareUserId")]
    [InverseProperty("Compares")]
    public virtual User CompareUser { get; set; } = null!;
}
