using CovidVaccinationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CovidVaccinationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
    }
}
