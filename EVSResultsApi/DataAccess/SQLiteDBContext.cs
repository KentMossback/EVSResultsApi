using EVSResultsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EVSResultsApi.DataAccess
{
    public class SQLiteDBContext : DbContext, ISQLiteDBContext
    {
        public SQLiteDBContext(DbContextOptions<SQLiteDBContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<pitch> Pitches { get; set; }
        public DbSet<Team> Teams { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Filename=EVSResultsDatabase.db", options =>
        //    {
        //        options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        //    });
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Group>().ToTable("Group", "evs");
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Id);
                //entity.HasIndex(e => e.Title).IsUnique();
                //entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            // Map table names
            modelBuilder.Entity<pitch>().ToTable("Pitch", "evs");
            modelBuilder.Entity<pitch>(entity =>
            {
                entity.HasKey(e => e.Id);
                //entity.HasIndex(e => e.Title).IsUnique();
                //entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Team>().ToTable("Team"
                , "evs");
            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Id);
                //entity.HasIndex(e => e.Title).IsUnique();
                //entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });


            base.OnModelCreating(modelBuilder);
        }

    }
}
