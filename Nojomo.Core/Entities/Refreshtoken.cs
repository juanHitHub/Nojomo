using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Nojomo.Core.Entities
{
    [Table("refreshtoken")]
    public partial class Refreshtoken
    {
        [Key]
        [Column("token_id")]
        public int TokenId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("token")]
        [StringLength(200)]
        public string Token { get; set; }
        [Column("expiry_date")]
        public DateTime ExpiryDate { get; set; }
        public virtual Usuario User { get; set; }
    }
}
