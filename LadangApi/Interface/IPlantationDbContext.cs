using LadangApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LadangApi.Interface
{
    public interface IPlantationDbContext
    {
        DbSet<Plantation> Plantations { get; set; }
    }
}