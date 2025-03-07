using Microsoft.EntityFrameworkCore;
using StudentDetailsExcersie.Model;


namespace StudentDetailsExcersie.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CurrentAddress> CurrentAddresses { get; set; }
        public DbSet<PermanentAddress> PermanentAddresses { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-one relationships

            // Student -> ContactDetails
            modelBuilder.Entity<Student>()
                .HasOne(s => s.ContactDetails)
                .WithOne()
                .HasForeignKey<Student>(s => s.ContactDetailsId)
                .OnDelete(DeleteBehavior.Cascade);

            // Student -> BloodGroup
            modelBuilder.Entity<Student>()
                .HasOne(s => s.BloodGroup)
                .WithOne()
                .HasForeignKey<Student>(s => s.BloodGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            // Student -> Address
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Address)
                .WithOne()
                .HasForeignKey<Student>(s => s.AddressId)
                .OnDelete(DeleteBehavior.Cascade);

            // Address -> CurrentAddress
            modelBuilder.Entity<Address>()
                .HasOne(a => a.CurrentAddress)
                .WithOne()
                .HasForeignKey<Address>(a => a.CurrentAddressId)
                .OnDelete(DeleteBehavior.Cascade);

            // Address -> PermanentAddress
            modelBuilder.Entity<Address>()
                .HasOne(a => a.PermanentAddress)
                .WithOne()
                .HasForeignKey<Address>(a => a.PermanentAddressId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}