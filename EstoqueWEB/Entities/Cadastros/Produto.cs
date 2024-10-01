using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EstoqueWEB.Entities.Cadastros
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } 

    }
}
