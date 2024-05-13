namespace camisas_united.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Logradouro { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Pais { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
