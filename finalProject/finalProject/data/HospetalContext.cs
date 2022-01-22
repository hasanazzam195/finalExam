using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace finalProject.data
{
    public class HospetalContext:DbContext
    {
        private readonly IConfiguration configuration;

        public HospetalContext()
        {

        }

        public HospetalContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Patiant> patiants { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Bed> beds { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Department> departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("HospetalConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
