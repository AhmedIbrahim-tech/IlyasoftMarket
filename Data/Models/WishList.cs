using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("WishList")]
public partial class WishList
{
    [Key]
    [Column("WishListID")]
    public int WishListId { get; set; }

    [Column("WishListUserID")]
    public int WishListUserId { get; set; }

    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    public DateOnly AddDate { get; set; }

    [ForeignKey("ProductHeaderId")]
    [InverseProperty("WishLists")]
    public virtual ProductHeader ProductHeader { get; set; } = null!;

    [ForeignKey("WishListUserId")]
    [InverseProperty("WishLists")]
    public virtual User WishListUser { get; set; } = null!;
}
