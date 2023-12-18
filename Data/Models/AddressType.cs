using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("AddressType")]
public partial class AddressType
{
    [Key]
    [Column("AddressTypeID")]
    public int AddressTypeId { get; set; }

    [Column("AddressType")]
    [StringLength(250)]
    public string AddressType1 { get; set; } = null!;

    [InverseProperty("AddressType")]
    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();
}
