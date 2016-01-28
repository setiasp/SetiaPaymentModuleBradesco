using System.Xml.Serialization;

namespace SetiaPaymentModuleBradesco.Models
{
    [XmlRoot("ordem_cobranca")]
    public class OrdemCobranca
    {
        public OrdemCobranca()
        {
            Pedido = new Pedido();
            Boleto = new BoletoBancario();
        }

        [XmlElement(ElementName = "pedido")]
        public Pedido Pedido { get; set; }

        [XmlElement(ElementName = "boleto")]
        public BoletoBancario Boleto { get; set; }
    }

    /// <summary>
    /// Dados do Pedido
    /// </summary>
    public class Pedido
    {
        [XmlElement(ElementName = "order_id")]
        public string NumeroPedido { get; set; }

        [XmlArray("item_pedido")]
        [XmlArrayItem("item")]
        public ItemPedido[] Itens { get; set; }

        [XmlArray("item_adicional")]
        [XmlArrayItem("adicional")]
        public ItemAdicionalPedido[] ItemAdicional { get; set; }
    }

    /// <summary>
    /// Dados do Boleto Bancario
    /// </summary>
    public class BoletoBancario
    {
        public BoletoBancario() {}

        [XmlElement(ElementName = "cedente")]
        public string Cedente { get; set; }

        [XmlElement(ElementName = "banco")]
        public string Banco { get; set; }

        [XmlElement(ElementName = "numero_agencia")]
        public string NumeroAgencia { get; set; }

        [XmlElement(ElementName = "numero_conta")]
        public string NumeroConta { get; set; }

        [XmlElement(ElementName = "url_logo_lojista")]
        public string UrlLogotipo { get; set; }

        [XmlElement(ElementName = "mensagem_header_lojista")]
        public string MensagemCabecalho { get; set; }

        [XmlElement(ElementName = "assinatura")]
        public string Assinatura { get; set; }

        [XmlElement(ElementName = "data_emissao")]
        public string DataEmissao { get; set; }

        [XmlElement(ElementName = "data_processamento")]
        public string DataProcessamento { get; set; }

        [XmlElement(ElementName = "data_vencimento")]
        public string DataVencimento { get; set; }

        [XmlElement(ElementName = "nome_sacado")]
        public string NomeSacado { get; set; }

        [XmlElement(ElementName = "cpf_sacado")]
        public string CpfSacado { get; set; }

        [XmlElement(ElementName = "cip")]
        public int CIP { get; set; }

        [XmlElement(ElementName = "ano_nosso_numero")]
        public int AnoNossoNumero { get; set; }

        [XmlElement(ElementName = "cep_sacado")]
        public string CepSacado { get; set; }

        [XmlElement(ElementName = "endereco_sacado")]
        public string EnderecoSacado { get; set; }

        [XmlElement(ElementName = "cidade_sacado")]
        public string CidadeSacado { get; set; }

        [XmlElement(ElementName = "uf_sacado")]
        public string UfSacado { get; set; }

        [XmlElement(ElementName = "numero_pedido")]
        public string NossoNumero { get; set; }

        [XmlElement(ElementName = "valor_documento")]
        public string Valor { get; set; }

        [XmlElement(ElementName = "shopping_id")]
        public int ShoppingId { get; set; }

        [XmlElement(ElementName = "numero_documento")]
        public int NumeroDocumento { get; set; }

        [XmlElement(ElementName = "carteira")]
        public string Carteira { get; set; }

        [XmlArray("instrucao")]
        [XmlArrayItem("descricao")]
        public string[] Descricao { get; set; }
    }

    /// <summary>
    /// Item do pedido
    /// </summary>
    public class ItemPedido
    {
        [XmlElement(ElementName = "descritivo")]
        public string Descritivo { get; set; }

        [XmlElement(ElementName = "quantidade")]
        public int Quantidade { get; set; }

        [XmlElement(ElementName = "unidade")]
        public string Unidade { get; set; }

        [XmlElement(ElementName = "valor")]
        public decimal Valor { get; set; }
    }

    /// <summary>
    /// Item Adicional do pedido
    /// </summary>
    public class ItemAdicionalPedido
    {
        [XmlElement(ElementName = "descricao")]
        public string Descricao { get; set; }

        [XmlElement(ElementName = "valor")]
        public decimal Valor { get; set; }
    }
}
