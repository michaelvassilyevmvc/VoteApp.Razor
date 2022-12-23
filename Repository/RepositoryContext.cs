using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System.Reflection;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new VoteConfiguration());
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Vote>? Votes { get; set; }
        public DbSet<PoliticCandidate>? PoliticCandidates { get; set; }
        public DbSet<ProductCandidate>? ProductCandidates { get; set; }
    }
}
