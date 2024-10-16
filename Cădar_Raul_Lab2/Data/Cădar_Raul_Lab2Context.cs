using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cădar_Raul_Lab2.Models;

namespace Cădar_Raul_Lab2.Data
{
    public class Cădar_Raul_Lab2Context : DbContext
    {
        public Cădar_Raul_Lab2Context (DbContextOptions<Cădar_Raul_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cădar_Raul_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Cădar_Raul_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
