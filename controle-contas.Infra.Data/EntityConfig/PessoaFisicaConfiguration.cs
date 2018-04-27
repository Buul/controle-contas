
using controle_contas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace controle_contas.Infra.Data.EntityConfig
{
    public class PessoaFisicaConfiguration : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfiguration()
        {
            HasKey(p => p.Id);

            Property(x => x.Cpf.Codigo)
               .HasColumnName("Cpf")
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
               new IndexAnnotation(new IndexAttribute("IX_CPF", 1) { IsUnique = true }));

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.DtNascimento);
        }
    }
}
