using Microsoft.EntityFrameworkCore;

namespace camisas_united.Models
{
    public partial class CamisasUnitedContext : DbContext
    {
        public CamisasUnitedContext()
        {
        }

        public CamisasUnitedContext(DbContextOptions<CamisasUnitedContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<Fornecedor> Fornecedor { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionario { get; set; } = null!;
        public virtual DbSet<Produto> Produto { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source=DESKTOP-CK9G4U8\\SQLEXPRESS; Initial Catalog=SistemaProdutos; Trusted_Connection=TRUE;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Nome).IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Bairro).IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Logradouro).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.NomeEmpresa).IsUnicode(false);

                entity.Property(e => e.Pais).IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TituloContato).IsUnicode(false);
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.ToTable("Fornecedor");

                entity.Property(e => e.Bairro).IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Logradouro).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Pais).IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.ToTable("Funcionario");

                entity.Property(e => e.Bairro).IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.DataContratacao).HasColumnType("datetime");

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.Extensao).IsUnicode(false);

                entity.Property(e => e.Logradouro).IsUnicode(false);

                entity.Property(e => e.Pais).IsUnicode(false);

                entity.Property(e => e.PrimeiroNome).IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo).IsUnicode(false);

                entity.Property(e => e.UltimoNome).IsUnicode(false);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produto");

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Produto__IdCateg__3F466844");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK__Produto__IdForne__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
