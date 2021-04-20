using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vagasemprego.Models;

namespace vagasemprego.Context
{
    public class VagaDbContext : DbContext
    {
        public VagaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<VagaModel> Vagas { get; set; }
    }
}
