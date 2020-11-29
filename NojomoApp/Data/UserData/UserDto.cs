using System;
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
        [EmailAddress(ErrorMessage ="El formato del Email es incorrecto")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefono es requerido [Solo dígitos]")]
        [RegularExpression(@"^[0-9]{10}", ErrorMessage = "El Teléfono debe ser de 10 dígitos")]
        public string Telefono { get; set; }
          
            public DateTime? Fecharegistro { get; set; }
          
            public int? Permisos { get; set; }
           
            public int? Status { get; set; }
        [Required(ErrorMessage = "Password  es requerido")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "El password debe ser de 8 a 15 caracteres,  contener al menos un número, contener al menos una letra mayúscula, contener al menos una letra minúscula y un caracter especial")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmar Password  es requerido")]
        [Compare("Password",ErrorMessage ="Password no coincide")]
        public string ConfirmPassword { get; set; }

        public int? Cestas { get; set; }
           
            public int? Direcciones { get; set; }
           
            public int? Direccionpredeterminadaid { get; set; }
          
            public int? Datosfiscales { get; set; }
          
            public int? Datosfiscalespredeterminadosid { get; set; }
           
            public int? Ordenes { get; set; }

        public bool Check { get; set; }

    }
}
