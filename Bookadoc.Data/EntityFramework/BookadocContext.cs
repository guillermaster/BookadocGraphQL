using Bookadoc.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Bookadoc.Data.EntityFramework
{
    public class BookadocContext : DbContext
    {
        public readonly ILogger _logger;

        public BookadocContext(DbContextOptions options, ILogger<BookadocContext> logger)
            : base(options)
        {
            _logger = logger;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // doctors
            modelBuilder.Entity<Doctor>().HasKey(c => c.Id);
            modelBuilder.Entity<Doctor>().Property(e => e.Id).ValueGeneratedNever();
            modelBuilder.Entity<Doctor>().HasMany(p => p.PhoneNumbers);

            // patients
            modelBuilder.Entity<Patient>().HasKey(c => c.Id);
            modelBuilder.Entity<Patient>().Property(e => e.Id).ValueGeneratedNever();

            // cities
            modelBuilder.Entity<City>().HasKey(c => c.Id);
            modelBuilder.Entity<City>().Property(e => e.Id).ValueGeneratedNever();

            // states
            modelBuilder.Entity<State>().HasKey(c => c.Id);
            modelBuilder.Entity<State>().Property(e => e.Id).ValueGeneratedNever();

            // degrees
            modelBuilder.Entity<Degree>().HasKey(c => c.Id);
            modelBuilder.Entity<Degree>().Property(e => e.Id).ValueGeneratedNever();

            // diseases
            modelBuilder.Entity<Disease>().HasKey(c => c.Id);
            modelBuilder.Entity<Disease>().Property(e => e.Id).ValueGeneratedNever();

            // specialities
            modelBuilder.Entity<Speciality>().HasKey(c => c.Id);
            modelBuilder.Entity<Speciality>().Property(e => e.Id).ValueGeneratedNever();

            // adresses
            modelBuilder.Entity<Address>().HasKey(c => c.Id);
            modelBuilder.Entity<Address>().Property(e => e.Id).ValueGeneratedNever();

            // phone numbers
            modelBuilder.Entity<Phone>().HasKey(c => c.Id);
            modelBuilder.Entity<Phone>().Property(e => e.Id).ValueGeneratedNever();
            
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
    }
}
