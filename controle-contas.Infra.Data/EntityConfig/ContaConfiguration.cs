
using controle_contas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace controle_contas.Infra.Data.EntityConfig
{
    public class ContaConfiguration : EntityTypeConfiguration<Conta>
    {
        public ContaConfiguration()
        {
            HasKey(p => p.Id);

            Property(x => x.Nome)
               .HasColumnName("Nome")
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
               new IndexAnnotation(new IndexAttribute("IX_Nome", 1) { IsUnique = true }));

            Property(c => c.Status)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.PessoaTipo);

            Property(c => c.Ancestry);

            Property(c => c.IdPessoa)
             .IsRequired();
        }
    }
}
