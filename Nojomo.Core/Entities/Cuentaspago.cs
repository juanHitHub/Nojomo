using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Entities
{
    [Table("cuentaspago")]
    public partial class Cuentaspago
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("usuarioid")]
        public int? Usuarioid { get; set; }
        [Column("banco")]
        public int? Banco { get; set; }
        [Column("numerocuenta")]
        [StringLength(16)]
        public string Numerocuenta { get; set; }
        [Column("numerointerbancario")]
        [StringLength(18)]
        public string Numerointerbancario { get; set; }
        [Column("pais")]
        public int? Pais { get; set; }
        [Column("beneficiario")]
        [StringLength(100)]
        public string Beneficiario { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("tipo")]
        public int? Tipo { get; set; }
        [Column("direccionbeneficiario")]
        [StringLength(100)]
        public string Direccionbeneficiario { get; set; }
        [Column("emailnotificacion")]
        [StringLength(50)]
        public string Emailnotificacion { get; set; }
    }
}
