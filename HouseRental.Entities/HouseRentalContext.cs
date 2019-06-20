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
                new House { Id = 1, BaseDayFee = 5, HouseType = HouseType.Apartment, ImageUrl = "https://images.unsplash.com/photo-1529408686214-b48b8532f72c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80" },
                new House { Id = 2, BaseDayFee = 112.3, HouseType = HouseType.Bungalow, ImageUrl = "https://images.unsplash.com/photo-1532408840957-031d8034aeef?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1780&q=80" },
                new House { Id = 3, BaseDayFee = 33, HouseType = HouseType.Apartment, ImageUrl = "https://images.unsplash.com/photo-1499916078039-922301b0eb9b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=80" },
                new House { Id = 4, BaseDayFee = 50, HouseType = HouseType.Bungalow, ImageUrl = "https://images.unsplash.com/photo-1464723775205-4af28be57d80?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1266&q=80" },
                new House { Id = 5, BaseDayFee = 25.5, HouseType = HouseType.Apartment, ImageUrl = "https://images.unsplash.com/photo-1460317442991-0ec209397118?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80" },
                new House {Id = 6, BaseDayFee = 45, HouseType = HouseType.Bungalow, ImageUrl = "https://images.unsplash.com/photo-1499793983690-e29da59ef1c2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80" });

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
