using FinanceUpW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceUpW
{
    public static class GlobalData
    {
        public static List<TipoIngreso> TiposIngresos = new List<TipoIngreso>();
        public static List<TipoEgreso> TiposEgresos = new List<TipoEgreso>();
        public static List<TipoPago> TiposPago = new List<TipoPago>();
        public static List<Ingreso> Ingresos = new List<Ingreso>();
        public static List<Egreso> Egresos = new List<Egreso>();
    }
}
