﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceUpW.Models
{
    public class Egreso
    {
        public string TipoEgreso { get; set; }
        public string TipoPago { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
