namespace camisas_united.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
