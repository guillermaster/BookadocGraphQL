using Bookadoc.Core;
using Bookadoc.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Bookadoc.Data.EntityFramework
{
    public class BookadocContext : DbContext
    {
        public readonly ILogger _logger;
        private bool _migrations;

        public BookadocContext() : base()
        {
            _migrations = true;
        }

        public BookadocContext(DbContextOptions options, ILogger<BookadocContext> logger)
            : base(options)
        {
            _logger = logger;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_migrations)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Bookadoc;Integrated Security=SSPI;integrated security=true;MultipleActiveResultSets=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // users
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasDiscriminator<int>("UserTypeId")
                .HasValue<Doctor>(Enums.UserType.Supplier)
                .HasValue<Patient>(Enums.UserType.Client)
                .HasValue<User>(Enums.UserType.Administrator);
            modelBuilder.Entity<User>().HasKey(c => c.Id);
            //modelBuilder.Entity<User>().Property(e => e.Id).ValueGeneratedNever();
            modelBuilder.Entity<User>().Property(p => p.Id).UseSqlServerIdentityColumn();

            // doctors
            modelBuilder.Entity<Doctor>().HasBaseType<User>();
            //modelBuilder.Entity<Doctor>().Property(e => e.Id).ValueGeneratedNever();
            modelBuilder.Entity<Doctor>().Property(p => p.Id).UseSqlServerIdentityColumn();
            modelBuilder.Entity<Doctor>().HasMany(p => p.PhoneNumbers);
                            

            // patients
            modelBuilder.Entity<Patient>().HasBaseType<User>();
            //modelBuilder.Entity<Patient>().Property(e => e.Id).ValueGeneratedNever();
            modelBuilder.Entity<Patient>().Property(p => p.Id).UseSqlServerIdentityColumn();

            // cities
            modelBuilder.Entity<City>().HasKey(c => c.Id);
            modelBuilder.Entity<City>().Property(e => e.Id).ValueGeneratedNever();
            modelBuilder.Entity<City>()
                .HasOne(city => city.Country)
                .WithMany(country => country.Cities)
                .HasForeignKey(city => city.IdCountry)
                .HasConstraintName("ForeignKey_City_Country");

            // states
            modelBuilder.Entity<State>().HasKey(c => c.Id);
            modelBuilder.Entity<State>().Property(e => e.Id).ValueGeneratedNever();

            // degrees
            modelBuilder.Entity<Degree>().HasKey(c => c.Id);
            modelBuilder.Entity<Degree>().Property(e => e.Id).ValueGeneratedNever();

            // doctors degrees
            modelBuilder.Entity<DoctorDegree>().HasKey(dd => new { dd.DoctorId, dd.DegreeId });
            modelBuilder.Entity<DoctorDegree>()
                .HasOne(dd => dd.Doctor)
                .WithMany(d => d.DoctorDegrees)
                .HasForeignKey(dd => dd.DoctorId);
            modelBuilder.Entity<DoctorDegree>()
                .HasOne(dd => dd.Degree)
                .WithMany(d => d.DoctorsDegrees)
                .HasForeignKey(dd => dd.DegreeId);

            // diseases
            modelBuilder.Entity<Disease>().HasKey(c => c.Id);
            modelBuilder.Entity<Disease>().Property(e => e.Id).ValueGeneratedNever();

            // patients diseases
            modelBuilder.Entity<PatientDiseaseHistory>().HasKey(pdh => new { pdh.PatientId, pdh.DiseaseId });
            modelBuilder.Entity<PatientDiseaseHistory>()
                .HasOne(pdh => pdh.Patient)
                .WithMany(p => p.PatientsDiseases)
                .HasForeignKey(pdh => pdh.PatientId);
            modelBuilder.Entity<PatientDiseaseHistory>()
                .HasOne(pdh => pdh.Disease)
                .WithMany(d => d.PatientsDiseases)
                .HasForeignKey(pdh => pdh.DiseaseId);

            // specialities
            modelBuilder.Entity<Speciality>().HasKey(c => c.Id);
            modelBuilder.Entity<Speciality>().Property(e => e.Id).ValueGeneratedNever();

            // doctors specialities
            modelBuilder.Entity<DoctorSpeciality>().HasKey(ds => new { ds.DoctorId, ds.SpecialityId });
            modelBuilder.Entity<DoctorSpeciality>()
                .HasOne(ds => ds.Doctor)
                .WithMany(d => d.DoctorSpecialities)
                .HasForeignKey(ds => ds.DoctorId);
            modelBuilder.Entity<DoctorSpeciality>()
                .HasOne(ds => ds.Speciality)
                .WithMany(s => s.DoctorSpecialities)
                .HasForeignKey(ds => ds.SpecialityId);

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
