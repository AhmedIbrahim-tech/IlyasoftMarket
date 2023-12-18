using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("UserStatus")]
public partial class UserStatus
{
    [Key]
    [Column("UserStatusID")]
    public int UserStatusId { get; set; }

    [Column("UserStatus")]
    [StringLength(250)]
    public string UserStatus1 { get; set; } = null!;

    [InverseProperty("UserStatus")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
