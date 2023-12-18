using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("SubCategory")]
public partial class SubCategory
{
    [Key]
    [Column("SubCategoryID")]
    public int SubCategoryId { get; set; }

    [Column("MainCategoryID")]
    public int MainCategoryId { get; set; }

    [StringLength(350)]
    public string SubCategoryTitle { get; set; } = null!;

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(250)]
    public string CreateBy { get; set; } = null!;

    public DateOnly CreateOn { get; set; }

    public TimeOnly CreateTime { get; set; }

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("CreateById")]
    [InverseProperty("SubCategories")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [ForeignKey("MainCategoryId")]
    [InverseProperty("SubCategories")]
    public virtual MainCategory MainCategory { get; set; } = null!;
}
