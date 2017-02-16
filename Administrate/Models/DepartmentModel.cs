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
        
        public int Floor { get; set; }

        public string DepartmentNumberLetter { get; set; }

        public int Telephone { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:P2}")]
        public decimal AreaOfThePropertyCover { get; set; }
        
        public bool HasGarage { get; set; }

        public int Building_ID { get; set;}



    }
}