using System.Configuration;
using SetiaPaymentModuleBradesco.Communication;
using SetiaPaymentModuleBradesco.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace SetiaPaymentModuleBradesco
{
    /// <summary>
    /// Setia Payment Module - Boleto Bancario Bradesco
    /// </summary>
    public class PagamentoBradesco : IPagamentoBradesco
    {
        private static readonly string UrlBradescoBoleto = ConfigurationManager.AppSettings["BRADESCO_MANAGER_STATUS_BOLETO_URL"];
        private static readonly string UrlBradescoStatusBoleto = UrlBradescoBoleto + "?merchantid={0}&data={1}&Manager={2}&passwd={3}&NumOrder={4}";
        private static readonly string UrlBradescoStatusBoletoLote = UrlBradescoBoleto + "?merchantid={0}&data={1}&Manager={2}&passwd={3}";

        /// <summary>
        /// Gera XML contendo os dados do pedido e da cobranca
        /// </summary>
        /// <param name="ordemCobranca"></param>
        /// <returns></returns>
        public string GerarXml(OrdemCobranca ordemCobranca)
        {
            var xsSubmit = new XmlSerializer(typeof(OrdemCobranca));
            var sww = new StringWriter();
            var writer = XmlWriter.Create(sww);

            xsSubmit.Serialize(writer, ordemCobranca);

            var content = sww.ToString()
                .Replace(" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", string.Empty)
                .Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", string.Empty)
                .Replace("utf-16", "iso-8859-1");

            return content;
        }

        /// <summary>
        /// Obtem o status de pagamento (individual)
        /// </summary>
        /// <param name="mercador"></param>
        /// <param name="periodo"></param>
        /// <param name="administrador"></param>
        /// <param name="senha"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static Boleto ObterStatusBoleto(string mercador, string administrador, string senha, DateTime periodo, string pedido)
        {
            return WebXmlReader.LoadFromInternet<Boleto>(
                string.Format(
                    UrlBradescoStatusBoleto, 
                    mercador, 
                    periodo.ToShortDateString(), 
                    administrador, 
                    senha, 
                    pedido),
                    "DadosFechamento",
                    "Pedido");
        }

        /// <summary>
        /// Obtem o status de pagamento (lote)
        /// </summary>
        /// <param name="mercador"></param>
        /// <param name="periodo"></param>
        /// <param name="administrador"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static List<Boleto> ObterLoteStatusBoleto(string mercador, DateTime periodo, string administrador, string senha)
        {
            return WebXmlReader.LoadFromInternet<Boleto[]>(
                string.Format(
                    UrlBradescoStatusBoletoLote, 
                    mercador, 
                    periodo.ToShortDateString(), 
                    administrador, 
                    senha
                    ), "DadosFechamento")
                .ToList();
        }
    }
}
