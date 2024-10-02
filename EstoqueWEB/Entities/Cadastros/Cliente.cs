namespace EstoqueWEB.Entities.Cadastros
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public Endereco Endereco { get; set; }
    }
}
