using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("OrderStatus")]
public partial class OrderStatus
{
    [Key]
    [Column("OrderStatusID")]
    public int OrderStatusId { get; set; }

    [StringLength(250)]
    public string OrderStatusTitle { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [InverseProperty("OrderStatus")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [ForeignKey("StatusId")]
    [InverseProperty("OrderStatuses")]
    public virtual Status Status { get; set; } = null!;
}
