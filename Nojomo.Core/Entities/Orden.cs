using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Nojomo.Core.Entities
{
    [Table("orden")]
    public partial class Orden
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("usuarioid")]
        public int? Usuarioid { get; set; }
        [Column("cestaid")]
        public int? Cestaid { get; set; }
        [Column("direccionid")]
        public int? Direccionid { get; set; }
        [Column("datosfiscalesid")]
        public int? Datosfiscalesid { get; set; }
        [Column("facturas")]
        public int? Facturas { get; set; }
        [Column("tipoentrega")]
        public int? Tipoentrega { get; set; }
        [Column("telefono")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Column("nombredestinatario")]
        [StringLength(50)]
        public string Nombredestinatario { get; set; }
        [Column("indicaciones")]
        [StringLength(100)]
        public string Indicaciones { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("pagos")]
        public int? Pagos { get; set; }
    }
}
