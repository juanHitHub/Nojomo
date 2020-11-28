using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Core.Entities
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
