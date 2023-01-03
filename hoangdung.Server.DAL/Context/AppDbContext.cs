using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hoangdung.Server.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace hoangdung.Server.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}