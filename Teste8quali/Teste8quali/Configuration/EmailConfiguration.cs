using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste8quali.Models;

namespace Teste8quali.Configuration
{
    public class EmailConfiguration : IEntityTypeConfiguration<EmailModel>
    {
        public void Configure(EntityTypeBuilder<EmailModel> builder)
        {
            builder.HasOne(p=> p.Cliente)
                .WithMany(p=> p.Emails)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
