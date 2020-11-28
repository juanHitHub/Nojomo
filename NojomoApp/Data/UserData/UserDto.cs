﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NojomoApp.Data.UserData
{
    public class UserDto
    {
            public int Id { get; set; }
        [Required(ErrorMessage = "Alias es requerido")]
        public string Alias { get; set; }
        [Required(ErrorMessage = "Nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Tipo es requerido")]
        [Range(1, 3, ErrorMessage = "Entre 1 y 3")]
        public int? Tipo { get; set; }
        [Required(ErrorMessage = "Precio es requerido")]
        [Range(10, 99999999, ErrorMessage = "Precio no debe ser menor a 10")]
        public decimal? Precio { get; set; }
        [Required(ErrorMessage = "Email es requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefono es requerido")]
        public string Telefono { get; set; }
          
            public DateTime? Fecharegistro { get; set; }
          
            public int? Permisos { get; set; }
           
            public int? Status { get; set; }
        [Required(ErrorMessage = "Password  es requerido")]
        public string Password { get; set; }
           
            public int? Cestas { get; set; }
           
            public int? Direcciones { get; set; }
           
            public int? Direccionpredeterminadaid { get; set; }
          
            public int? Datosfiscales { get; set; }
          
            public int? Datosfiscalespredeterminadosid { get; set; }
           
            public int? Ordenes { get; set; }

        public bool Check { get; set; }

    }
}