using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Entities
{
    [Table("direccion")]
    public partial class Direccion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("usuarioid")]
        public int? Usuarioid { get; set; }
        [Column("alias")]
        [StringLength(20)]
        public string Alias { get; set; }
        [Column("nombredestinatario")]
        [StringLength(50)]
        public string Nombredestinatario { get; set; }
        [Column("direccion")]
        [StringLength(50)]
        public string Direccion1 { get; set; }
        [Column("referencias")]
        [StringLength(50)]
        public string Referencias { get; set; }
        [Column("referencias2")]
        [StringLength(50)]
        public string Referencias2 { get; set; }
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Column("ciudad")]
        [StringLength(30)]
        public string Ciudad { get; set; }
        [Column("estado")]
        [StringLength(30)]
        public string Estado { get; set; }
        [Column("cp")]
        [StringLength(10)]
        public string Cp { get; set; }
        [Column("pais")]
        [StringLength(30)]
        public string Pais { get; set; }
        [Column("telefono")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("indicacionespaqueteria")]
        [StringLength(50)]
        public string Indicacionespaqueteria { get; set; }
        [Column("tipo")]
        public int? Tipo { get; set; }
    }
}
