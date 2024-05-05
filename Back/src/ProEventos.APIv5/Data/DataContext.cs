using Microsoft.EntityFrameworkCore;
using ProEventos.APIv5.Models;

namespace ProEventos.APIv5.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Eventos> Eventos { get; set; }
    }
}