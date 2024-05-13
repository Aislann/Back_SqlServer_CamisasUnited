namespace camisas_united.Models
{
    public partial class Funcionario
    {
        public int Id { get; set; }
        public string? PrimeiroNome { get; set; }
        public string? UltimoNome { get; set; }
        public string? Titulo { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataContratacao { get; set; }
        public string? Logradouro { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Pais { get; set; }
        public string? Telefone { get; set; }
        public string? Extensao { get; set; }
    }
}
