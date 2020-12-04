using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Nojomo.Core.Entities
{
    [Table("usuario")]
    public partial class Usuario
    {
        public Usuario()
        {
            RefreshTokens = new HashSet<Refreshtoken>();
        }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("alias")]
        [StringLength(20)]
        public string Alias { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("tipo")]
        public int? Tipo { get; set; }
        [Column("precio", TypeName = "money")]
        public decimal? Precio { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("telefono")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Column("fecharegistro")]
        public DateTime? Fecharegistro { get; set; }
        [Column("permisos")]
        public int? Permisos { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("password")]
        [StringLength(100)]
        public string Password { get; set; }
        [Column("cestas")]
        public int? Cestas { get; set; }
        [Column("direcciones")]
        public int? Direcciones { get; set; }
        [Column("direccionpredeterminadaid")]
        public int? Direccionpredeterminadaid { get; set; }
        [Column("datosfiscales")]
        public int? Datosfiscales { get; set; }
        [Column("datosfiscalespredeterminadosid")]
        public int? Datosfiscalespredeterminadosid { get; set; }
        [Column("ordenes")]
        public int? Ordenes { get; set; }
        public virtual ICollection<Refreshtoken> RefreshTokens { get; set; }
    }
}
