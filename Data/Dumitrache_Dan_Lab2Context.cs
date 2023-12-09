using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dumitrache_Dan_Lab2.Models;

namespace Dumitrache_Dan_Lab2.Data
{
    public class Dumitrache_Dan_Lab2Context : DbContext
    {
        public Dumitrache_Dan_Lab2Context (DbContextOptions<Dumitrache_Dan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dumitrache_Dan_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Dumitrache_Dan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Dumitrache_Dan_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
