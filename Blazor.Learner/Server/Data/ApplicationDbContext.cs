using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Learner.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Learner.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
    }
}
