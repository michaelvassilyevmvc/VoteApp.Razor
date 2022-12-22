using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;
using VoteApp.Console.Entities;


namespace VoteApp.Console.Data
{
    public class ApplicationDbContext : DbContext
    {
        private IDbContextTransaction _currentTransaction;

        public DbSet<User> Users { get; set; }
        public DbSet<CandidateBase> Candidates { get; set; }
        public DbSet<PoliticCandidate> Politics { get; set; }
        public DbSet<ProductCandidate> Products { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=VoteConsoleDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<CandidateBase>().ToTable("candidates");
            modelBuilder.Entity<PoliticCandidate>().ToTable("politics");
            modelBuilder.Entity<ProductCandidate>().ToTable("products");
            modelBuilder.Entity<Vote>().ToTable("votes").HasKey(x => new
            {
                UserId = x.UserId, CandidateId = x.CandidateId
            });
        }

        public async Task BeginTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                return;
            }

            _currentTransaction = await Database.BeginTransactionAsync(IsolationLevel.ReadCommitted);
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await SaveChangesAsync();

                await (_currentTransaction?.CommitAsync() ?? Task.CompletedTask);
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }
    }
}
