using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administrate.Models
{
    public class DepartamentoModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Piso")]
        public int Floor { get; set; }

        [Required]
        [Display(Name = "Letra y/o numero")]
        public string DepartmentNumberLetter { get; set; }

        [Required]
        [Display(Name = "Telefono")]

        public int Telephone { get; set; }

        [Required]
        [Display(Name = "Porcentage de la propiedad")]
        public decimal AreaOfThePropertyCover { get; set; }

        [Required]
        [Display(Name = "Tiene garage?")]
        public bool HasGarage { get; set; }

        [Required]
        [Display(Name = "Tiene baulera")]
        public bool HasStorageRoom { get; set; }

        public int Building_ID { get; set; }



    }
}