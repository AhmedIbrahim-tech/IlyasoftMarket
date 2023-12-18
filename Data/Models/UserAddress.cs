using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("UserAddress")]
public partial class UserAddress
{
    [Key]
    [Column("UserAddressID")]
    public int UserAddressId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("AddressTypeID")]
    public int AddressTypeId { get; set; }

    public string FullAddress { get; set; } = null!;

    [Column("CityID")]
    public int CityId { get; set; }

    [StringLength(50)]
    public string PostalCode { get; set; } = null!;

    [StringLength(150)]
    public string ContactNo { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("AddressTypeId")]
    [InverseProperty("UserAddresses")]
    public virtual AddressType AddressType { get; set; } = null!;

    [ForeignKey("CityId")]
    [InverseProperty("UserAddresses")]
    public virtual City City { get; set; } = null!;

    [InverseProperty("UserAddress")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    [ForeignKey("StatusId")]
    [InverseProperty("UserAddresses")]
    public virtual Status Status { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserAddresses")]
    public virtual User User { get; set; } = null!;
}
