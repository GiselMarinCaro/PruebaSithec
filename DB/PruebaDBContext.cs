using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;


namespace API.DB
{
    public class PruebaDBContext: DbContext
    {
        public PruebaDBContext(DbContextOptions<PruebaDBContext> options) : base(options)
        {
        }
        public DbSet<Humano> Humano { get; set; }
    }
}
