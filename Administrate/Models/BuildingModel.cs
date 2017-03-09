using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Administrate.Models
{
    public class BuildingModel
    {

        [Key]
        public int BuildingID { get; set; }

        [Display(Name = "Cuit")]
        public int Cuit { get; set; }

        [Display(Name = "Telefono")]
        public int Telephone { get; set; }

        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Display(Name = "Categoria")]
        public Categorys Category { get; set; }

        public string Identity_ID { get; set; }

        public virtual ICollection<DepartamentoModel> Departments { get; set; }

        public enum Categorys
        {
            Primera,
            Segunda,
            Tercera,
            Cuarta
        }

    }
}