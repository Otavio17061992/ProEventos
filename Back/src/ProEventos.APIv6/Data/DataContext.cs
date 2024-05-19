using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microsoft.EntityFramworkcore;
using ProEventos.Models;

namespace ProEventos.APIv6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public Dbset<Eventos> Eventos { get; set; }
    }
}