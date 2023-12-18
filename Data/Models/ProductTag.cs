using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("ProductTag")]
public partial class ProductTag
{
    [Key]
    [Column("ProductTagID")]
    public int ProductTagId { get; set; }

    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    [Column("TagID")]
    public int TagId { get; set; }

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("ProductHeaderId")]
    [InverseProperty("ProductTags")]
    public virtual ProductHeader ProductHeader { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ProductTags")]
    public virtual Status Status { get; set; } = null!;

    [ForeignKey("TagId")]
    [InverseProperty("ProductTags")]
    public virtual Tag Tag { get; set; } = null!;
}
