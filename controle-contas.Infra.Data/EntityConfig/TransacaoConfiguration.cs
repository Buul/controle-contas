
using controle_contas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace controle_contas.Infra.Data.EntityConfig
{
    public class TransacaoConfiguration : EntityTypeConfiguration<Transacao>
    {
        public TransacaoConfiguration()
        {
            HasKey(p => p.Id);

            Property(x => x.Valor)
               .HasColumnName("Valor")
               .HasColumnAnnotation(IndexAnnotation.AnnotationName,
               new IndexAnnotation(new IndexAttribute("IX_Valor", 1)));

            Property(c => c.CodigoTransacaoEstorno)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.IdContaOrigem);

            Property(c => c.IdContaDestino);

            Property(c => c.ValorContaOrigem);

            Property(c => c.ValorContaDestino);

            Property(c => c.Estorno);

        }
    }
}
