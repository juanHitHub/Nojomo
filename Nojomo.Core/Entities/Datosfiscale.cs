using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Entities
{
    [Table("datosfiscales")]
    public partial class Datosfiscale
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("tipopersona")]
        public int? Tipopersona { get; set; }
        [Column("razonsocial")]
        [StringLength(50)]
        public string Razonsocial { get; set; }
        [Column("regimenfiscal")]
        public int? Regimenfiscal { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("telefono")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Column("usocfdipredeterminado")]
        [StringLength(50)]
        public string Usocfdipredeterminado { get; set; }
    }
}
