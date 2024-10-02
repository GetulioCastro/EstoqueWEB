namespace EstoqueWEB.Entities.Cadastros
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
    }
}
