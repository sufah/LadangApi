using LadangApi.Interface;
using LadangApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LadangApi.Data
{
    public class PlantationDbContext : DbContext, IPlantationDbContext
    {
        public PlantationDbContext(DbContextOptions<PlantationDbContext> options) : base(options)
        {
        }

        public DbSet<Plantation> Plantations { get; set; }
    }
}