using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Nojomo.Core.Entities
{
    [Table("cestaproducto")]
    public partial class Cestaproducto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("skuid")]
        public int? Skuid { get; set; }
        [Column("almacenid")]
        public int? Almacenid { get; set; }
        [Column("cantidad")]
        public int? Cantidad { get; set; }
        [Column("precio", TypeName = "money")]
        public decimal? Precio { get; set; }
        [Column("posicionencesta")]
        public int? Posicionencesta { get; set; }
        [Column("fechaenqueseagrego")]
        public DateTime? Fechaenqueseagrego { get; set; }
        [Column("fechaexpiracionprecio")]
        public DateTime? Fechaexpiracionprecio { get; set; }
    }
}
