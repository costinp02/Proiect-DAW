using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class ProiectContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<GameStore> GameStores { get; set; }

        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //One to one
            builder.Entity<Store>()
                .HasOne(a => a.Address)
                .WithOne(aa => aa.Store)
                .HasForeignKey<Address>(a => a.Id);

            //One to many
            builder.Entity<Publisher>()
                .HasMany(a => a.Games)
                .WithOne(aa => aa.Publisher);

            //many to many 
            builder.Entity<GameStore>().HasKey(ac => new { ac.GameId, ac.StoreId });

            builder.Entity<GameStore>()
                .HasOne<Game>(ac => ac.Game)
                .WithMany(a => a.GameStores)
                .HasForeignKey(ac => ac.GameId);

            builder.Entity<GameStore>()
                .HasOne<Store>(ac => ac.Store)
                .WithMany(a => a.GameStores)
                .HasForeignKey(ac => ac.StoreId);

            base.OnModelCreating(builder);
        }
    }
}
