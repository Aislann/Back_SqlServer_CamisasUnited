namespace camisas_united.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? Quantidade { get; set; }
        public decimal? Preco { get; set; }
        public int? UnidadesEstoque { get; set; }
        public int? UnidadesEncomenda { get; set; }
        public int? IdFornecedor { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categoria? IdCategoriaNavigation { get; set; }
        public virtual Fornecedor? IdFornecedorNavigation { get; set; }
    }
}
