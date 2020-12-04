using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Nojomo.Core.Entities
{
    [Table("pago")]
    public partial class Pago
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("ordenid")]
        public int? Ordenid { get; set; }
        [Column("formadepago")]
        public int? Formadepago { get; set; }
        [Column("monto", TypeName = "money")]
        public decimal? Monto { get; set; }
        [Column("institucion")]
        [StringLength(30)]
        public string Institucion { get; set; }
        [Column("moneda")]
        public int? Moneda { get; set; }
        [Column("fechaacreditado")]
        public DateTime? Fechaacreditado { get; set; }
        [Column("folio")]
        public int? Folio { get; set; }
        [Column("referencianumerica")]
        public int? Referencianumerica { get; set; }
        [Column("referenciaalfanumerica")]
        [StringLength(40)]
        public string Referenciaalfanumerica { get; set; }
        [Column("comisiones", TypeName = "money")]
        public decimal? Comisiones { get; set; }
        [Column("tipo")]
        public int? Tipo { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("cuentaorigenid")]
        public int? Cuentaorigenid { get; set; }
        [Column("cuentadestinoid")]
        public int? Cuentadestinoid { get; set; }
    }
}
