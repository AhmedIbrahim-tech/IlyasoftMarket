using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("MainCategory")]
public partial class MainCategory
{
    [Key]
    [Column("MainCategoryID")]
    public int MainCategoryId { get; set; }

    [StringLength(250)]
    public string MainCategoryTitle { get; set; } = null!;

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(250)]
    public string CreateBy { get; set; } = null!;

    public DateOnly CreateOn { get; set; }

    public TimeOnly CreateTime { get; set; }

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("CreateById")]
    [InverseProperty("MainCategories")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("MainCategories")]
    public virtual Status Status { get; set; } = null!;

    [InverseProperty("MainCategory")]
    public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}
