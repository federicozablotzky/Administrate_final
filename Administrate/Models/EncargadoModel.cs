using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administrate.Models
{
    public class EncargadoModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public int Telephone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int DNI { get; set; }

        [Required]
        public int Cuit { get; set; }

        public int Antiguedad { get; set; }
    }

}