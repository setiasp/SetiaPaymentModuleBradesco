using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetiaPaymentModuleBradesco.Models
{
    public enum StatusBoleto
    {
        GeradoSemRetorno = 10,
        PagoManualmente = 11,
        BoletoGeradoSemInforme = 13,
        BoletoGeradoComInforme = 14,
        BoletoPago = 15,
        BoletoPagoIgual = 21,
        BoletoPagoMenor = 22,
        BoletoPagoMaior = 23,
    }
}
