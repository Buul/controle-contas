
using controle_contas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace controle_contas.Infra.Data.EntityConfig
{
    public class PessoaJuridicaConfiguration : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaConfiguration()
        {
            HasKey(p => p.Id);

            Property(x => x.Cnpj.Codigo)
               .HasColumnName("Cnpj")
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
               new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = true }));

            Property(c => c.RazaoSocial)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.NomeFantasia)
            .HasMaxLength(150);
        }
    }
}
