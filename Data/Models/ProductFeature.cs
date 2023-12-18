using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("ProductFeature")]
public partial class ProductFeature
{
    [Key]
    [Column("ProductFeatureID")]
    public int ProductFeatureId { get; set; }

    [Column("ProductFeature")]
    public string ProductFeature1 { get; set; } = null!;

    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(150)]
    public string CreateBy { get; set; } = null!;

    [Column("UpdateByID")]
    public int UpdateById { get; set; }

    [StringLength(150)]
    public string UpdateBy { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("CreateById")]
    [InverseProperty("ProductFeatureCreateByNavigations")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [ForeignKey("ProductHeaderId")]
    [InverseProperty("ProductFeatures")]
    public virtual ProductHeader ProductHeader { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ProductFeatures")]
    public virtual Status Status { get; set; } = null!;

    [ForeignKey("UpdateById")]
    [InverseProperty("ProductFeatureUpdateByNavigations")]
    public virtual User UpdateByNavigation { get; set; } = null!;
}
