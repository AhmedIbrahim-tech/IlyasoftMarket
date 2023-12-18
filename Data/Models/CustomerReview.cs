using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

[Table("CustomerReview")]
public partial class CustomerReview
{
    [Key]
    [Column("CustomerReviewID")]
    public int CustomerReviewId { get; set; }

    [Column("ProductHeaderID")]
    public int ProductHeaderId { get; set; }

    [Column("CustomerReview")]
    public string CustomerReview1 { get; set; } = null!;

    [Column("StatusID")]
    public int StatusId { get; set; }

    [Column("CustomerReviewUserID")]
    public int CustomerReviewUserId { get; set; }

    [Column("OrderHeaderID")]
    public int OrderHeaderId { get; set; }

    [InverseProperty("CustomerReview")]
    public virtual ICollection<CustomerReviewImage> CustomerReviewImages { get; set; } = new List<CustomerReviewImage>();

    [ForeignKey("CustomerReviewUserId")]
    [InverseProperty("CustomerReviews")]
    public virtual User CustomerReviewUser { get; set; } = null!;

    [ForeignKey("OrderHeaderId")]
    [InverseProperty("CustomerReviews")]
    public virtual OrderHeader OrderHeader { get; set; } = null!;

    [ForeignKey("ProductHeaderId")]
    [InverseProperty("CustomerReviews")]
    public virtual ProductHeader ProductHeader { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("CustomerReviews")]
    public virtual Status Status { get; set; } = null!;
}
