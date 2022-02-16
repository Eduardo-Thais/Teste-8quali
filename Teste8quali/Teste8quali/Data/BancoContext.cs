using Microsoft.EntityFrameworkCore;
using Teste8quali.Models;

namespace Teste8quali.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<EmailModel> Email { get; set; }

        
    }
}
