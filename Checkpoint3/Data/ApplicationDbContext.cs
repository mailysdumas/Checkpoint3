using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint3.Data
{
    public class Checkpoint3DbContext : IdentityDbContext
    {
        public Checkpoint3DbContext(DbContextOptions<Checkpoint3DbContext> options)
            : base(options)
        {
        }
    }
}
