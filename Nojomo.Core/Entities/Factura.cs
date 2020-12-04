using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nojomo.Core.Entities
{
    [Table("factura")]
    public partial class Factura
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("uuid")]
        public int? Uuid { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
