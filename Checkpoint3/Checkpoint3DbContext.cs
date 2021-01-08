using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Checkpoint3.Models;

namespace Checkpoint3
{
    public class Checkpoint3DbContext : IdentityDbContext
    {
        public virtual DbSet<Models.ArticlesEdition> Articles { get; set; }

        public Checkpoint3DbContext(DbContextOptions<Checkpoint3DbContext> options)
            : base(options)
        {

        }
    }
}
