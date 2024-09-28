namespace EstoqueWEB.Entities.Cadastros
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int? FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
