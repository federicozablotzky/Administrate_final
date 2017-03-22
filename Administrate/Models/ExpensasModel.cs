using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administrate.Models
{
    public class ExpensasModel
    {
        [Key]
        public int ID { get; set; }
       
        [Display(Name ="Tipo de Gastos")]
        public TipoDeGastos tipoDeGastos { get; set; }

        [Display(Name = "Categoria")]
        public Categoria categoria { set; get; }

        [Display(Name = "Proveedor")]
        public string proveedor { get; set; }


        [Display(Name = "Concepto o razon")]
        public string concepto { get; set;}


        [Display(Name = "Periodo de facturacion")]
        [DataType(DataType.Date)]
        public DateTime periodoDeFacturacion { get; set; }

        [Display(Name = "Fecha del Gasto")]
        [DataType(DataType.Date)]
        public DateTime FechaDegasto { get; set; }

        [DataType(DataType.Currency)]
        public float monto { get; set; }

        public int Building_ID { get; set; }




    }

   
    public enum Categoria
    {
        Acuerdos,
        Abonos,
        Contratos,
        Deudas,
        Expensas,
        mantenimiento,
        Servicios,
        Sueldos,
        Varios

    }

    public enum TipoDeGastos
    {
        Egreso,
        Ingreso
        
    }
}