namespace MusicHub.Data
{
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;

    public class MusicHubDbContext : DbContext
    {
        public MusicHubDbContext()
        {
        }

        public MusicHubDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Performer> Performers { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SongPerformer> SongsPerformers { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SongPerformer>(e =>
            {
                e.HasKey(sp => new
                {
                    sp.SongId,
                    sp.PerformerId
                });


            });

            builder.Entity<Song>(e =>
            {
                e.Property(s => s.Name)
                .HasMaxLength(20)
                .IsRequired();

                e.Property(s => s.CreatedOn)
                .IsRequired();

                e.Property(s => s.Duration)
                .IsRequired();

                e.Property(s => s.Genre)
                .IsRequired();

            });

            builder.Entity<Album>(e =>
            {
                e.Property(a => a.Name)
                .HasMaxLength(40)
                .IsRequired();

                e.Property(s => s.ReleaseDate)
               .IsRequired();

            });

            builder.Entity<Performer>(e =>
            {
                e.Property(p => p.FirstName)
                .HasMaxLength(20)
                .IsRequired();

                e.Property(p => p.LastName)
                .HasMaxLength(20)
                .IsRequired();

                e.Property(s => s.Age)
               .IsRequired();

                e.Property(s => s.NetWorth)
               .IsRequired();
            });

            builder.Entity<Producer>(e =>
            {
                e.Property(p => p.Name)
                .HasMaxLength(30)
                .IsRequired();
            });

            builder.Entity<Writer>(e =>
            {
                e.Property(e => e.Name)
                .HasMaxLength(20)
                .IsRequired();
            });
        }
    }
}
