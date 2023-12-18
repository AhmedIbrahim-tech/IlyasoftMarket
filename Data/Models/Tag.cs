using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("Tag")]
public partial class Tag
{
    [Key]
    [Column("TagID")]
    public int TagId { get; set; }

    [StringLength(250)]
    public string TagTitle { get; set; } = null!;

    [InverseProperty("Tag")]
    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
}
