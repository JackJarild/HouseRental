using Microsoft.EntityFrameworkCore;

namespace HouseRental.Entities
{
    public class HouseRentalContext : DbContext
    {
        public HouseRentalContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<House>().HasData(
                new House { Id = 1, BaseDayFee = 5, HouseType = HouseType.Apartment },
                new House { Id = 2, BaseDayFee = 112.3, HouseType = HouseType.Bungalow },
                new House { Id = 3, BaseDayFee = 33, HouseType = HouseType.Apartment },
                new House { Id = 4, BaseDayFee = 50, HouseType = HouseType.Bungalow },
                new House { Id = 5, BaseDayFee = 25.5, HouseType = HouseType.Apartment });

            builder.Entity<House>(entity =>
            {
                entity.HasKey(i => i.Id);
            });

            builder.Entity<Reservation>(entity =>
            {
                entity.HasKey(i => i.Id);
                entity.Property(p => p.Email).HasMaxLength(50);
                entity.HasOne<House>()
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(p => p.HouseId);
            });
        }

    }
}
