using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SetiaPaymentModuleBradesco.Models
{
    [XmlRoot("Pedido")]
    public class Boleto
    {
        [XmlAttribute(AttributeName = "Numero")]
        public string Pedido { get; set; }

        [XmlAttribute(AttributeName = "LinhaDigitavel")]
        public string Numeracao { get; set; }

        [XmlAttribute(AttributeName = "Valor")]
        public int Valor { get; set; }

        [XmlAttribute(AttributeName = "ValorPago")]
        public int ValorPago { get; set; }

        [XmlAttribute(AttributeName = "Status")]
        public int _Status { get; set; }
        public StatusBoleto Status {
            get { return (StatusBoleto)_Status; }
            set { _Status = Convert.ToInt32(value); }
        }

        [XmlAttribute(AttributeName = "Erro")]
        public int Erro { get; set; }

        [XmlAttribute(AttributeName = "Data")]
        public string _Data { get; set; }
        public DateTime Data {
            get { return Convert.ToDateTime(_Data); }
            set { _Data = value.ToString(CultureInfo.InvariantCulture); }
        }

        [XmlAttribute(AttributeName = "DataPagamento")]
        public string _DataPagamento { get; set; }
        public DateTime DataPagamento
        {
            get { return string.IsNullOrEmpty(_DataPagamento) ? DateTime.Now : Convert.ToDateTime(_DataPagamento); }
            set { _DataPagamento = value.ToString(CultureInfo.InvariantCulture); }
        }
    }
}
