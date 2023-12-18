using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("UserType")]
public partial class UserType
{
    [Key]
    [Column("UserTypeID")]
    public int UserTypeId { get; set; }

    [Column("UserType")]
    [StringLength(250)]
    public string UserType1 { get; set; } = null!;

    [InverseProperty("UserType")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
