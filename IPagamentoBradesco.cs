using System;
using SetiaPaymentModuleBradesco.Models;

namespace SetiaPaymentModuleBradesco
{
    /// <summary>
    /// Setia Payment Module - Interface Boleto Bancario Bradesco
    /// </summary>
    public interface IPagamentoBradesco
    {
        /// <summary>
        /// Gerar o XML com os dados do pedido
        /// Estes dados deverão ser fornecidos a plataforma Bradesco por meio de url 
        /// de consulta da cesta de compras, cadastrada no Gerenciador do Lojista
        /// </summary>
        /// <param name="ordemCobranca"></param>
        /// <returns></returns>
        String GerarXml(OrdemCobranca ordemCobranca);
        
    }
}
