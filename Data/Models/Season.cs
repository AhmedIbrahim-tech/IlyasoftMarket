using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Season")]
public partial class Season
{
    [Key]
    [Column("SeasonID")]
    public int SeasonId { get; set; }

    [StringLength(500)]
    public string SeasonTitle { get; set; } = null!;

    public DateOnly SeasonStartDate { get; set; }

    public DateOnly SeasonEndDate { get; set; }

    [Column("CreateByID")]
    public int CreateById { get; set; }

    [StringLength(150)]
    public string CreateBy { get; set; } = null!;

    [ForeignKey("CreateById")]
    [InverseProperty("Seasons")]
    public virtual User CreateByNavigation { get; set; } = null!;

    [InverseProperty("Season")]
    public virtual ICollection<SeasonDiscount> SeasonDiscounts { get; set; } = new List<SeasonDiscount>();
}
