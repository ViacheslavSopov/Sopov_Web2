using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{

    public class HospitalContext : DbContext
    {
        public DbSet<Hospital> hospitals { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Lab> labs { get; set; }

        public DbSet<Patient> patients { get; set; }
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

}

