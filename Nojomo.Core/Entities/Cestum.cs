using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nojomo.Core.Entities
{
    [Table("cesta")]
    public partial class Cestum
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("usuarioid")]
        public int? Usuarioid { get; set; }
        [Column("direccionentregaid")]
        public int? Direccionentregaid { get; set; }
        [Column("productos")]
        public int? Productos { get; set; }
        [Column("fechacreacion")]
        public DateTime? Fechacreacion { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("stockreservado")]
        public int? Stockreservado { get; set; }
        [Column("fechaexpiracionstockreservado")]
        public DateTime? Fechaexpiracionstockreservado { get; set; }
    }
}
