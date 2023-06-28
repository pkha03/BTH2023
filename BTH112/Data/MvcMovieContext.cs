using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTH112.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<BTH112.Models.Sinhvien> Sinhvien { get; set; } = default!;

        public DbSet<BTH112.Models.Lophoc> Lophoc { get; set; } = default!;
    }
}
