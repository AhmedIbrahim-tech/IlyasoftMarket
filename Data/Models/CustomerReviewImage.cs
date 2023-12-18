using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("CustomerReviewImage")]
public partial class CustomerReviewImage
{
    [Key]
    [Column("CustomerReviewImageID")]
    public int CustomerReviewImageId { get; set; }

    [Column("CustomerReviewID")]
    public int CustomerReviewId { get; set; }

    public string ImagePath { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [ForeignKey("CustomerReviewId")]
    [InverseProperty("CustomerReviewImages")]
    public virtual CustomerReview CustomerReview { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("CustomerReviewImages")]
    public virtual Status Status { get; set; } = null!;
}
