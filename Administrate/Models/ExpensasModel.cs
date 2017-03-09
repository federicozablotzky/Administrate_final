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
        public List<ServiciosPublicosModel> ServP { get; set; }
        public List<AbonoDeServiciosModel> AbonoDeServicios { get; set; }
        public List<MantenimientoDePartesComunesModel> MantenimientoDePartesComunes { get; set; }
        public List<GastosBancariosModel> GastosBancarios { get; set; }
        public List<GastosDeAdmonistracionModel> GastosDeAdmonistracion { get; set; }
        public List<PagoDelPeriodoPorSegurosModel> PagoDelPeriodoPorSeguros { get; set; }

        public List<EstadoFinancieroModel> EstadoFinanciero { get; set; }
        public List<EstadoParimonialModel> EstadoParimonial { get; set; }

    }

    public class ServiciosPublicosModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }

    public class AbonoDeServiciosModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }
    public class MantenimientoDePartesComunesModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }
    public class GastosBancariosModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }
    public class GastosDeAdmonistracionModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }

    public class PagoDelPeriodoPorSegurosModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }
    public class OtrosModel
    {
        [Key]
        public int ID { get; set; }
        public string Detalle { get; set; }
        public float Costo { get; set; }

        public TipoDeGastos tipoDeGastos { get; set; }
    }

    public class EstadoFinancieroModel
    {
        [Key]
        public int ID { get; set; }
        public float IngresoPorExpensas { get; set; }
        public float EgresosPorExpensas { get; set; }

        public float saldoAlcierre { get; set; }
    }

    public class EstadoParimonialModel
    {
        [Key]
        public int ID { get; set; }
        public float SaldoDeDisponibilidadesAlcierre { get; set; }
        public float ExpensasACobrar { get; set; }

        public float saldoAlcierre { get; set; }

    }

    public enum TipoDeGastos
    {
        A,
        B,
        C
    }
}